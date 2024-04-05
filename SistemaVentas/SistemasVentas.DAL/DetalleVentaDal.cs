using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.TOTAL AS VENTA, " +
                                "PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO\r\n" +
                                "FROM     DETALLEVENTA INNER JOIN\r\n                  " +
                                "VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\r\n                  " +
                                "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleventa values(" + detalleVenta.IdVenta + "," +
                                                            "" + detalleVenta.IdProducto + "," +
                                                            "" + detalleVenta.Cantidad + "," +
                                                            "" + detalleVenta.PrecioVenta + "," +
                                                            "" + detalleVenta.SubTotal + "," +
                                                            "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleVenta.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                detalleVenta.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleVenta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleVenta;
        }
        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "update detalleventa set idventa=" + detalleVenta.IdVenta + "," +
                                                        "idproducto=" + detalleVenta.IdProducto + "," +
                                                        "cantidad=" + detalleVenta.Cantidad + "," +
                                                        "precioventa=" + detalleVenta.PrecioVenta + "," +
                                                        "subtotal=" + detalleVenta.SubTotal + " " +
                                                "where iddetalleventa=" + detalleVenta.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
