using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Detalle_Salida
    {
        public int IdDetalleSalida { get; set; }
        public int Monto { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
