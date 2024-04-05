using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                            "'" + proveedor.Telefono + "'," +
                                                            "'" + proveedor.Direccion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Proveedor ObtenerProveedorIdDal(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor proveedor = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                proveedor.Nombre = tabla.Rows[0]["nombre"].ToString();
                proveedor.Telefono = tabla.Rows[0]["telefono"].ToString();
                proveedor.Direccion = tabla.Rows[0]["direccion"].ToString();
                proveedor.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return proveedor;
        }
        public void EditarProveedorDal(Proveedor proveedor)
        {
            string consulta = "update proveedor set nombre='" + proveedor.Nombre + "'," +
                                                        "telefono='" + proveedor.Telefono + "'," +
                                                        "direccion='" + proveedor.Direccion + "'," +
                                                        "estado='" + proveedor.Estado + "' " +
                                                "where idproveedor=" + proveedor.IdProveedor;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
