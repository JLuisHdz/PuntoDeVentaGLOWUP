using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Salida
    {
        public int IdSalida { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public string Descripcion { get; set; }
        
        public string FechaRegistro { get; set; }
    }
}
