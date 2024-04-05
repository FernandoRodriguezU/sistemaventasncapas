using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "SELECT VENTA.IDVENTA, CLIENTE.TIPOCLIENTE, USUARIO.NOMBREUSER, " +
                                "VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO\r\n" +
                                "FROM     VENTA INNER JOIN\r\n                  " +
                                "CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE INNER JOIN\r\n                  " +
                                "USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values (" + venta.IdCliente + ", "
                                                          + venta.IdVendedor + ", " +
                                                          "'" + venta.Fecha + "',"
                                                           + venta.Total + ",'"
                                                           + venta.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public Venta ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                venta.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idvendedor"]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                venta.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                venta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return venta;
        }
        public void EditarVentaDal(Venta venta)
        {
            string consulta = "update venta set idcliente=" + venta.IdCliente + "," +
                                                        "idvendedor=" + venta.IdVendedor + "," +
                                                        "fecha='" + venta.Fecha + "', " +
                                                        "total=" + venta.Total + "," +
                                                        "estado='" + venta.Estado + "' " +
                                                "where idventa=" + venta.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
