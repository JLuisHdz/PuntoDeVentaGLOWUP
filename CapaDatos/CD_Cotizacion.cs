using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cotizacion
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from PRODUCTO");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        //public Venta ObtenerCotizacion(string numero)
        //{
            //Venta obj = new Venta();
            //using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            //{
            //    try
            //    {
            //        oconexion.Open();
            //        StringBuilder query = new StringBuilder();
            //        query.AppendLine("select v.IdVenta, u.NombreCompleto,");
            //        query.AppendLine("v.TipoDocumento, v.NumeroDocumento,");
            //        query.AppendLine("v.MontoPago, v.Descuento, v.MontoCambio, v.MontoTotal,");
            //        query.AppendLine("convert(char(10), v.FechaRegistro, 103)[FechaRegistro]");
            //        query.AppendLine("from VENTA v");
            //        query.AppendLine("inner join USUARIO u on u.IdUsuario = V.IdUsuario");
            //        query.AppendLine("where v.NumeroDocumento = @numero");

            //        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
            //        cmd.Parameters.AddWithValue("@numero", numero);
            //        cmd.CommandType = System.Data.CommandType.Text;

            //        using (SqlDataReader dr = cmd.ExecuteReader())
            //        {

            //            while (dr.Read())
            //            {

            //                obj = new Venta()
            //                {
            //                    IdVenta = Convert.ToInt32(dr["IdVenta"]),
            //                    oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
            //                    TipoDocumento = dr["TipoDocumento"].ToString(),
            //                    NumeroDocumento = dr["NumeroDocumento"].ToString(),
            //                    MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
            //                    Descuento = Convert.ToDecimal(dr["Descuento"].ToString()),
            //                    MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
            //                    MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
            //                    FechaRegistro = dr["FechaRegistro"].ToString(),

            //                };
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        obj = new Venta();
            //    }
            //}

            //return obj;
        //}
    }
}
