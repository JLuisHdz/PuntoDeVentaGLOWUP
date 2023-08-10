using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
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
    public partial class frmVentas : Form
    {
        private const decimal PORCENTAJE_DESCUENTO = 10m; // 10% de descuento
        private Usuario _Usuario;
        private int cantidadTotalRopa = 0;
        private decimal subtotalTotalRopa = 0;
        private int cantidadTotal = 0;
        private string categoriaProducto = "";
        private int cantidadProductosTotal = 0;
        private int cantidadProductoRopa = 0;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDoc.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDoc.DisplayMember = "Texto";
            cboTipoDoc.ValueMember = "Valor";
            cboTipoDoc.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProducto.Text = "0";

            txtPagaCon.Text = "0";
            txtCambio.Text = "0";
            txtTotalPagar.Text = "0";
            txtDescuentos.Text = "0";

            cantidadTotalRopa = 0;
            subtotalTotalRopa = 0;
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
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIdProducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                );

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                    txtIdProducto.Text, //Id
                    txtProductos.Text, //Nombre Producto
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

                }
            }
        }

        private void VerificarAplicarDescuentoRopa()
        {
            if (cantidadTotalRopa >= 6)
            {
                decimal descuentoPorProducto = 10m;
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells["categoria"].Value.ToString() == "Ropa")
                    {
                        row.Cells["Descuento"].Value = descuentoPorProducto;
                    }
                }
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

                if (cantidadTotal >= 6)
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
            txtProductos.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                        CalcularTotal(true);
                    }
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
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularcambio()
        {
            if (txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existe producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));
            detalle_venta.Columns.Add("Descuento", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(
                    new object[]
                    {
                        row.Cells["IdProducto"].Value.ToString(),
                        row.Cells["Precio"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["SubTotal"].Value.ToString(),
                        row.Cells["Descuento"].Value.ToString()
                    });
            }
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:0000000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cboTipoDoc.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoPago = Convert.ToDecimal(txtPagaCon.Text),
                Descuento = Convert.ToDecimal(txtDescuentos.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        private DataTable datos;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            datos = new DataTable();
            datos.Columns.Add("IdProducto", typeof(int));
            datos.Columns.Add("Producto", typeof(string));
            datos.Columns.Add("Precio", typeof(decimal));
            datos.Columns.Add("Cantidad", typeof(int));
            datos.Columns.Add("SubTotal", typeof(decimal));
            datos.Columns.Add("Descuento", typeof(decimal));

            FrmImpresion form = new FrmImpresion();
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                CD_Imprimir dt = new CD_Imprimir();
                int idProducto = Convert.ToInt32(fila.Cells[0].Value.ToString());
                dt.IdProducto = idProducto;
                string producto = fila.Cells[1].Value.ToString();
                dt.Producto = producto;
                decimal precio = Convert.ToDecimal(fila.Cells[2].Value.ToString());
                dt.Precio = precio;
                int cantidad = Convert.ToInt32(fila.Cells[3].Value.ToString());
                dt.Cantidad = cantidad;
                decimal subTotal = Convert.ToDecimal(fila.Cells[4].Value.ToString());
                dt.SubTotal = subTotal;
                decimal descuento = Convert.ToDecimal(fila.Cells[5].Value.ToString());
                dt.Descuento = descuento;
                form.lista.Add(dt);
                datos.Rows.Add(idProducto, producto, precio, cantidad, subTotal, descuento);
            }
            dgvdata.DataSource = datos;
            form.DatosVenta = (DataTable)dgvdata.DataSource;
            //dgvdata.Rows = datos;
            //FrmImpresion form = new FrmImpresion();
            //foreach (DataGridViewRow fila in dgvdata.Rows)
            //{
            //    CD_Imprimir dt = new CD_Imprimir();
            //    if (fila.Cells[0].Value != null)
            //    {
            //        dt.IdProducto = Convert.ToInt32(fila.Cells[0].Value.ToString());
            //    }
            //    else
            //    {
            //        // Manejar el caso cuando no hay un valor en la celda
            //        // Puedes asignar un valor predeterminado o hacer alguna acción necesaria
            //        dt.IdProducto = 0; // Por ejemplo, asignar un valor predeterminado de 0
            //    }
            //    dt.Producto = fila.Cells[1].Value.ToString();
            //    dt.Precio = Convert.ToDecimal(fila.Cells[2].Value.ToString());
            //    dt.Cantidad = Convert.ToInt32(fila.Cells[3].Value.ToString());
            //    dt.SubTotal = Convert.ToDecimal(fila.Cells[4].Value.ToString());
            //    dt.Descuento = Convert.ToDecimal(fila.Cells[5].Value.ToString());
            //    form.lista.Add(dt);
            //}
            form.txtDescuentosImprimir.Text = txtDescuentos.Text;
            form.txtTotalPagarImprimir.Text = txtTotalPagar.Text;
            form.txtPagaConImprimir.Text = txtPagaCon.Text;
            form.txtCambioImprimir.Text = txtCambio.Text;
            form.Show();
            this.Hide();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdata_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string categoriaProductoEliminar = e.Row.Cells["Categoria"].Value.ToString();
            int cantidadEliminar = Convert.ToInt32(e.Row.Cells["Cantidad"].Value);

            if (categoriaProductoEliminar == "Ropa")
            {
                cantidadTotal -= cantidadEliminar;
                cantidadProductoRopa -= cantidadEliminar; // Decrementar el contador para la categoría "Ropa"

                if (cantidadTotal < 6)
                {
                    foreach (DataGridViewRow row in dgvdata.Rows)
                    {
                        string categoriaProducto = row.Cells["Categoria"].Value.ToString();
                        if (categoriaProducto == "Ropa")
                        {
                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal subTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                            decimal descuentoProducto = 10 * cantidad;
                            row.Cells["Descuento"].Value = descuentoProducto.ToString("0.00");
                            row.Cells["SubTotal"].Value = (subTotal - descuentoProducto).ToString("0.00");
                        }
                    }
                }
            }

            CalcularTotal(true);
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
                    txtProductos.Text = modal._Producto.Nombre;
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

        private void txtCodigoProducto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigoProducto.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProductos.Text = oProducto.Nombre;
                    txtPrecio.Text = oProducto.PrecioVenta?.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();
                    txtCategoria.Text = oProducto.oCategoria.Descripcion.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigoProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProductos.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    txtCategoria.Text = "";
                    txtCantidad.Value = 1;
                }
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//private DataTable datos;
//// Crear un DataTable con las columnas necesarias
//datos = new DataTable();
//datos.Columns.Add("IdProducto", typeof(int));
//datos.Columns.Add("Producto", typeof(string));
//datos.Columns.Add("Precio", typeof(decimal));
//datos.Columns.Add("Cantidad", typeof(int));
//datos.Columns.Add("SubTotal", typeof(decimal));
//datos.Columns.Add("Descuento", typeof(decimal));

//// Obtener los datos del DataGridView existente y agregarlos al DataTable
//foreach (DataGridViewRow fila in dgvdata.Rows)
//{
//    int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
//    string producto = fila.Cells["Producto"].Value.ToString();
//    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
//    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
//    decimal subTotal = Convert.ToDecimal(fila.Cells["SubTotal"].Value);
//    decimal descuento = Convert.ToDecimal(fila.Cells["Descuento"].Value);

//    datos.Rows.Add(idProducto, producto, precio, cantidad, subTotal, descuento);
//}

//// Asignar datos como origen de datos del DataGridView
//dgvdata.DataSource = datos;