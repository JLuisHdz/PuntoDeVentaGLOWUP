using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCotizacion : Form
    {
        private const decimal PORCENTAJE_DESCUENTO = 0.10m; // 10% de descuento
        private decimal descuentoTotal = 0;
        private Usuario _Usuario;
        private int cantidadTotalRopa = 0;
        private decimal subtotalTotalRopa = 0;
        private int cantidadTotal = 0;
        private string categoriaProducto = "";
        private int cantidadProductosTotal = 0;
        private int cantidadProductoRopa = 0;
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString();
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCategoria.Text = modal._Producto.oCategoria.Descripcion.ToString();
                    categoriaProducto = modal._Producto.oCategoria.Descripcion.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio Compra - El formato de la moneda es incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            txtCantidad.Maximum = 999999;
            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[] {
                    txtIdProducto.Text, //Id
                    txtProducto.Text, //Nombre Producto
                    precio.ToString("0.00"), //Precio
                    txtCantidad.Value.ToString(), //Cantidad
                    (txtCantidad.Value * precio).ToString("0.00"), //SubTotal
                    CalcularDescuento(Convert.ToInt32(txtCantidad.Value), Convert.ToDecimal(txtCantidad.Value * precio), categoriaProducto),
                    txtCategoria.Text

                });
                // Aplicar cálculos para productos de categoría "Ropa"
                if (categoriaProducto == "Ropa")
                {
                    cantidadTotalRopa += Convert.ToInt32(txtCantidad.Value);
                    subtotalTotalRopa += (txtCantidad.Value * precio);

                }


                CalcularTotal();
                LimpiarProducto();
                txtCodigoProducto.Select();

                //}
            }
        }
        private decimal CalcularDescuento(int Cantidad, decimal SubTotal, string categoriaProducto)
        {
            decimal descuentoTotal = 0;

            if (Cantidad >= 6 && categoriaProducto == "Ropa")
            {
                descuentoTotal = 10m * (Cantidad / 6) * SubTotal;
            }

            return descuentoTotal;
        }

        private void CalcularTotal(bool sEliminar = false)
        {
            decimal total = 0;
            decimal descuentoTotal = 0;
            int cantidadTotal = 0;
            cantidadProductoRopa = 0;

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());

                    int Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    cantidadTotal += Cantidad;
                    string CategoriaBD = row.Cells["Categoria"].Value.ToString();
                    if (CategoriaBD == "Ropa")
                    {
                        cantidadProductoRopa = cantidadProductoRopa + Cantidad;
                    }
                }

                if (cantidadTotal >= 6 && categoriaProducto == "Ropa")
                {
                    foreach (DataGridViewRow row in dgvdata.Rows)
                    {
                        int Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        string CategoriaBD = row.Cells["Categoria"].Value.ToString();
                        decimal descuentoProducto = 0;
                        if (CategoriaBD == "Ropa" && cantidadProductoRopa >= 6)
                        {
                            descuentoProducto = 10 * Cantidad;
                        }
                        else if (CategoriaBD == "Ropa" && cantidadProductoRopa < 6 && sEliminar == true)
                        {
                            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                            SubTotal = Cantidad * Precio;
                        }
                        descuentoTotal += descuentoProducto;

                        row.Cells["Descuento"].Value = descuentoProducto.ToString("0.00");
                        row.Cells["SubTotal"].Value = (SubTotal - descuentoProducto).ToString("0.00");
                    }
                }
            }

            total -= descuentoTotal;

            txtTotalPagar.Text = total.ToString("0.00");
            txtDescuentos.Text = descuentoTotal.ToString("0.00");
        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void dgvdata_Click(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Delete20.Width;
                var h = Properties.Resources.Delete20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Delete20, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            string Texto_Html = Properties.Resources.PlantillaCotizacion.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descuento"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@DescuentoTotal", txtDescuentos.Text);
            Texto_Html = Texto_Html.Replace("@montototal", txtTotalPagar.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteCotizacion_{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy"));
            savefile.Filter = "Pdf files | *.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString();
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCategoria.Text = modal._Producto.oCategoria.Descripcion.ToString();
                    categoriaProducto = modal._Producto.oCategoria.Descripcion.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProd_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtProd.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtProd.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecio.Text = oProducto.PrecioVenta?.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();
                    txtCategoria.Text = oProducto.oCategoria.Descripcion.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtProd.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    txtCategoria.Text = "";
                    txtCantidad.Value = 1;
                }
            }
        }
    }
}
