using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_LogoImp
    {
        private CD_LogoImp objcd_logoimp = new CD_LogoImp();

        public LogoImp ObtenerDatos()
        {
            return objcd_logoimp.ObtenerDatos();
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_logoimp.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_logoimp.ActualizarLogo(imagen, out mensaje);
        }
    }
}
