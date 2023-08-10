using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj == null)
            {
                Mensaje += "Es necesario rellenar los campos\n";
                return 0;
            }

            if (obj.Documento == string.Empty)
            {
                Mensaje += "Es necesario el Documento del Proveedor\n";
            }

            if (obj.RazonSocial == string.Empty)
            {
                Mensaje += "Es necesaria la Razon Social del Proveedor\n";
            }

            if (obj.Correo == string.Empty)
            {
                Mensaje += "Es necesario el Correo del Proveedor\n";
            }

            if (obj.Telefono == string.Empty)
            {
                Mensaje += "Es necesario el Telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == string.Empty)
            {
                Mensaje += "Es necesario el Documento del Proveedor\n";
            }

            if (obj.RazonSocial == string.Empty)
            {
                Mensaje += "Es necesaria la Razon Social del Proveedor\n";
            }

            if (obj.Correo == string.Empty)
            {
                Mensaje += "Es necesario el Correo del Proveedor\n";
            }

            if (obj.Telefono == string.Empty)
            {
                Mensaje += "Es necesario el Telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
