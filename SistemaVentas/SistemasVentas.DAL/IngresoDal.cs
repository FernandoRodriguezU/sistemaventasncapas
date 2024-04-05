using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "SELECT INGRESO.IDINGRESO, PROVEEDOR.NOMBRE AS PROVEEDOR, " +
                                "INGRESO.FECHAINGRESO, INGRESO.TOTAL, INGRESO.ESTADO\r\n" +
                                "FROM     INGRESO INNER JOIN\r\n                  " +
                                "PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                            "'" + ingreso.FechaIngreso + "'," +
                                                            "" + ingreso.Total + "," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Ingreso ObtenerIngresoIdDal(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso ingreso = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                ingreso.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                ingreso.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                ingreso.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                ingreso.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                ingreso.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return ingreso;
        }
        public void EditarIngresoDal(Ingreso ingreso)
        {
            string consulta = "update ingreso set idproveedor=" + ingreso.IdProveedor + "," +
                                                        "fechaingreso='" + ingreso.FechaIngreso + "'," +
                                                        "total=" + ingreso.Total + "," +
                                                        "estado='" + ingreso.Estado + "' " +
                                                "where idingreso=" + ingreso.IdIngreso;
            conexion.Ejecutar(consulta);
        }
        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
