﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj == null)
            {
                Mensaje += "Es necesario rellenar los campos\n";
                return 0;
            }

            if (obj.Documento == string.Empty)
            {
                Mensaje += "Es necesario el Documento del Usuario\n";
            }

            if (obj.NombreCompleto == string.Empty)
            {
                Mensaje += "Es necesario el nombre del Usuario\n";
            }

            if (obj.Clave == string.Empty)
            {
                Mensaje += "Es necesaria la Clave del Usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == string.Empty)
            {
                Mensaje += "Es necesario el Documento del Usuario\n";
            }

            if (obj.NombreCompleto == string.Empty)
            {
                Mensaje += "Es necesario el nombre del Usuario\n";
            }

            if (obj.Clave == string.Empty)
            {
                Mensaje += "Es necesaria la Clave del Usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj,out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
