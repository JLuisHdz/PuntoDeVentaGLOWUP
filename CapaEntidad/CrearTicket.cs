using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace CapaEntidad
{
    public class CrearTicket
    {
        public string Empresa { get; set; }
        public string Dirccion { get; set; }
        public string Telefono { get; set; }
        public Image Logotipo { get; set; }

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();
        public void imprimir(Producto p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimeticket);
        }

        public void imprimeticket(object sender, PrintPageEventArgs e)
        {

        }
    }
}
