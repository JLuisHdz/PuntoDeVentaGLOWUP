using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Salida
    {
        private CD_Salida objcd_salida = new CD_Salida();

        public List<Salida> Listar()
        {
            return objcd_salida.Listar();
        }


        public int Registrar(Salida obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj == null)
            {
                Mensaje += "Es necesario rellenar los campos\n";
                return 0;
            }
            
            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el nombre del producto\n";
            }

            if (obj.Monto == 0)
            {
                Mensaje += "Es necesario el monto del producto\n";
            }

            if (string.IsNullOrEmpty(obj.Descripcion))
            {
                Mensaje += "Es necesaria la descripcion del producto\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_salida.Registrar(obj, out Mensaje);
            }
        }


        public bool Editar(Salida obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del producto\n";
            }

            if (obj.Descripcion == string.Empty)
            {
                Mensaje += "Es necesaria la descripcion del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_salida.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Salida obj, out string Mensaje)
        {
            return objcd_salida.Eliminar(obj, out Mensaje);
        }
    }
}

