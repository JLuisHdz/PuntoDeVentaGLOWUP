using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmImpresion : Form
    {
        public DataTable DatosVenta { get; set; }
        public List<CD_Imprimir> lista = new List<CD_Imprimir>();
        public FrmImpresion()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void FrmImpresion_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            dgvdata.Rows.Clear();
            foreach (var dato in lista)
            {
                dgvdata.Rows.Add(dato.IdProducto, dato.Producto, dato.Precio, dato.Cantidad, dato.SubTotal, dato.Descuento);
            }

            // Asegurarse de que el ComboBox tenga elementos
            cboImpresoras.BeginUpdate();

            // Establecer "Impresora58" como valor predeterminado
            cboImpresoras.Items.Add("POS58 Printer");

            // Agregar las demás impresoras
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                // Omitir agregar "Impresora58" nuevamente
                if (printer != "POS58 Printer")
                {
                    cboImpresoras.Items.Add(printer);
                }
            }

            // Establecer el valor predeterminado seleccionado en "Impresora58"
            cboImpresoras.SelectedIndex = 0;

            // Finalizar la actualización del ComboBox
            cboImpresoras.EndUpdate();

            bool obtenido = true;
            byte[] byteimage = new CN_LogoImp().ObtenerLogo(out obtenido);

            if (obtenido)
                pictureBoxLogo.Image = ByteToImage(byteimage);

            LogoImp datos = new CN_LogoImp().ObtenerDatos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //printDocument1 = new PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += ImprimirPagina;
            //printDocument1.Print();


            string impresoraSeleccionada = cboImpresoras.SelectedItem.ToString();

            // Obtener la información del DataGridView y TextBox
            //DataTable datos = DatosVenta;
            //string descuentos = txtDescuentosImprimir.Text;
            //string totalPagar = txtTotalPagarImprimir.Text;
            //string pagaCon = txtPagaConImprimir.Text;
            //string cambio = txtCambioImprimir.Text;

            // Obtener la cantidad total de filas en tu fuente de datos
            // Altura estimada de cada fila (ajústala según tus necesidades)
            // Calcular la altura total necesaria

            // Establecer la altura del papel en la configuración de PaperSize


            // Configurar la impresión
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = impresoraSeleccionada;


            // Asignar el evento PrintPage para especificar el contenido del ticket
            printDocument.PrintPage += (s, args) =>
            {
                Graphics graphics = args.Graphics;

                DataTable datos = DatosVenta;
                int alturaFila = 20;
                int totalFilas = datos.Rows.Count;
                int alturaTotal = totalFilas * alturaFila;
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, alturaTotal);
                string formatoTabla = " {0,-18}  {1,-9}  {2,-4}  {3,-3}";
                Font font = new Font("Courier New", 5); // Fuente de monoespacio
                Font fontdos = new Font("Courier New", 5); // Fuente de monoespacio
                Font fonttres = new Font("Courier New", 6); // Fuente de monoespacio
                Font fontNegrita = new Font("Arial", 6, FontStyle.Bold);
                string totalPagarTexto = "Total a Pagar:";
                int ancho = 200;
                int y = 20;

                string descuentos = txtDescuentosImprimir.Text;
                string totalPagar = txtTotalPagarImprimir.Text;
                string pagaCon = txtPagaConImprimir.Text;
                string cambio = txtCambioImprimir.Text;
                string fecha = txtFecha.Text;
                string Producto = "Producto";
                string Precio = "Precio";
                string Cantidad = "Cantidad";
                string Descuento = "Descuento";

                // Imprimir el logo
                Image logo = pictureBoxLogo.Image;
                if (logo != null)
                {
                    graphics.DrawImage(logo, new Rectangle(0, y, ancho - 20, 110));
                    y += 80;
                }

                // Imprimir el encabezado de la tabla
                y += 20;
                graphics.DrawString("GLOW UP", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("CC. VILLA TEXTIL LOC. 105", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("CONTACTANOS POR WHATSAPP", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("4951097927 Y 4951070513", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 20;


                graphics.DrawString("Fecha:" + fecha, font, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 20;

                graphics.DrawString("--------------------------------------------", font, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 20;

                graphics.DrawString("  Producto          Precio  Cantidad  Dto.", font, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 20;

                foreach (DataRow row in datos.Rows)
                {
                    string producto = row["Producto"].ToString();
                    string precio = row["Precio"].ToString();
                    string cantidad = row["Cantidad"].ToString();
                    string descuento = row["Descuento"].ToString();

                    string lineaTabla = string.Format(formatoTabla, producto, precio, cantidad, descuento);
                    graphics.DrawString(lineaTabla, font, Brushes.Black, new RectangleF(0, y, ancho, 20));
                    y += 20;
                }

                graphics.DrawString("-------------------------------------------", font, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 10;

                graphics.DrawString(totalPagarTexto + totalPagar.ToString(), fontNegrita, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 10;

                graphics.DrawString("Descuento:" + descuentos.ToString(), fontdos, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 10;

                graphics.DrawString("Pago Con:" + pagaCon.ToString(), fontdos, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 10;

                graphics.DrawString("Cambio:" + cambio.ToString(), fontdos, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 20;

                graphics.DrawString("  CAMBIOS SOLO POR COLOR Y/O TALLA", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("       EN UN LAPSO DE 7 DIAS", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString(" POR FAVOR VERIFIQUE EL ESTADO DE SU", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("MERCANCIA ANTES DE SALIR DE LA TIENDA.", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("      !GRACIAS POR SU COMPRA!", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("                     ", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
                graphics.DrawString("                     .", fonttres, Brushes.Black, new RectangleF(0, y, ancho, 20));
                y += 8;
            };

            //    int x = 20; // Ajusta la posición horizontal
            //    int currentY = 10; // Ajusta la posición vertical
            //    int lineHeightContenido = 20; // Ajusta la altura de cada línea de contenido
            //    int lineHeightSubtitulo = 25; // Ajusta la altura de cada línea de subtitulo

            //    // Ajusta los tamaños de fuente según tus necesidades
            //    Font fontContenido = new Font("Arial", 8);
            //    Font fontSubtitulo = new Font("Arial", 10, FontStyle.Bold);

            //    foreach (DataRow row in datos.Rows)
            //    {
            //        //string producto = row["Producto"].ToString();
            //        //SizeF sizeProducto = graphics.MeasureString(producto, fontContenido);
            //        //if (sizeProducto.Width > 200) // Ajusta el ancho máximo permitido
            //        //{
            //        //    producto = producto.Substring(0, Math.Min(producto.Length, 15)) + "...";
            //        //}
            //        //graphics.DrawString(producto, fontContenido, Brushes.Black, x + 100, currentY);

            //        string idProducto = row["IdProducto"].ToString();
            //        string producto = row["Producto"].ToString();
            //        string precio = row["Precio"].ToString();
            //        string cantidad = row["Cantidad"].ToString();
            //        string subTotal = row["SubTotal"].ToString();
            //        string descuento = row["Descuento"].ToString();

            //        graphics.DrawString(idProducto, fontContenido, Brushes.Black, x, currentY);
            //        graphics.DrawString(producto, fontContenido, Brushes.Black, x + 100, currentY);
            //        graphics.DrawString(precio, fontContenido, Brushes.Black, x + 300, currentY);
            //        graphics.DrawString(cantidad, fontContenido, Brushes.Black, x + 400, currentY);
            //        graphics.DrawString(subTotal, fontContenido, Brushes.Black, x + 500, currentY);
            //        graphics.DrawString(descuento, fontContenido, Brushes.Black, x + 600, currentY);

            //        currentY += lineHeightContenido;
            //    }

            //    graphics.DrawString("Descuentos:", fontSubtitulo, Brushes.Black, x, currentY);
            //    graphics.DrawString(descuentos, fontContenido, Brushes.Black, x + 100, currentY);

            //    currentY += lineHeightSubtitulo;
            //    graphics.DrawString("Total a Pagar:", fontSubtitulo, Brushes.Black, x, currentY);
            //    graphics.DrawString(totalPagar, fontContenido, Brushes.Black, x + 100, currentY);

            //    currentY += lineHeightSubtitulo;
            //    graphics.DrawString("Paga Con:", fontSubtitulo, Brushes.Black, x, currentY);
            //    graphics.DrawString(pagaCon, fontContenido, Brushes.Black, x + 100, currentY);

            //    currentY += lineHeightSubtitulo;
            //    graphics.DrawString("Cambio:", fontSubtitulo, Brushes.Black, x, currentY);
            //    graphics.DrawString(cambio, fontContenido, Brushes.Black, x + 100, currentY);
            //};

            //// Iniciar la impresión
            printDocument.Print();

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            DataTable datos = DatosVenta;
            Font font = new Font("Arial", 5);
            Font fontdos = new Font("Arial", 4);
            int ancho = 200;
            int y = 20;
            int ydos = 100;
            string descuentos = txtDescuentosImprimir.Text;
            string totalPagar = txtTotalPagarImprimir.Text;
            string pagaCon = txtPagaConImprimir.Text;
            string cambio = txtCambioImprimir.Text;

            e.Graphics.DrawString("--- Tienda Deportiva GLOW ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("#############################", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            foreach (DataRow row in datos.Rows)
            {
                e.Graphics.DrawString(" | " +
                row["Producto"].ToString() + " | " +
                row["Precio"].ToString() + " | " +
                row["Cantidad"].ToString() + " | " +
                row["SubTotal"].ToString() + " | " +
                row["Descuento"].ToString() + " | ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }
            e.Graphics.DrawString("Descuento:" + descuentos.ToString(), fontdos, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Total a Pagar" + totalPagar.ToString(), fontdos, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Pago Con" + pagaCon.ToString(), fontdos, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cambio" + cambio.ToString(), fontdos, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    pictureBoxLogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}