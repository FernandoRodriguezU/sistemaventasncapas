using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING, INGRESO.TOTAL AS INGRESO, " +
                                   "PRODUCTO.NOMBRE AS PRODUCTO, DETALLEING.FECHAVENC, DETALLEING.CANTIDAD, " +
                                   "DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, \r\n                  DETALLEING.ESTADO\r\n" +
                                   "FROM     DETALLEING INNER JOIN\r\n                  " +
                                   "INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN\r\n                  " +
                                   "PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdIngreso + "," +
                                                            "" + detalleing.IdProducto + "," +
                                                            "'" + detalleing.FechaVenc + "'," +
                                                            "" + detalleing.Cantidad + "," +
                                                            "" + detalleing.PrecioCosto + "," +
                                                            "" + detalleing.PrecioVenta + "," +
                                                            "" + detalleing.SubTotal + "," +
                                                            "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public DetalleIng ObtenerDetalleIngIdDal(int id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleIng detalleing = new DetalleIng();
            if (tabla.Rows.Count > 0)
            {
                detalleing.IdDetalleing = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
                detalleing.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                detalleing.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                detalleing.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
                detalleing.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleing.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
                detalleing.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                detalleing.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleing.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleing;
        }
        public void EditarDetalleIngDal(DetalleIng detalleing)
        {
            string consulta = "update detalleing set idingreso=" + detalleing.IdIngreso + "," +
                                                        "idproducto=" + detalleing.IdProducto + "," +
                                                        "fechavenc='" + detalleing.FechaVenc + "'," +
                                                        "cantidad=" + detalleing.Cantidad + "," +
                                                        "preciocosto=" + detalleing.PrecioCosto + "," +
                                                        "precioventa=" + detalleing.PrecioVenta + "," +
                                                        "subtotal=" + detalleing.SubTotal + " " +
                                                "where iddetalleing=" + detalleing.IdDetalleing;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
