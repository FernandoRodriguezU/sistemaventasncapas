using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, TIPOPROD.NOMBRE AS TIPO_PRODUCTO, " +
                                "MARCA.NOMBRE AS MARCA, PRODUCTO.NOMBRE AS PRODUCTO, PRODUCTO.CODIGOBARRA, " +
                                "PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO\r\n" +
                                "FROM     PRODUCTO INNER JOIN\r\n                  " +
                                "TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN\r\n" +
                                "MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProducto + "," +
                                                            "" + producto.IdMarca + "," +
                                                            "'" + producto.Nombre + "'," +
                                                            "'" + producto.CodigoBarra + "'," +
                                                            "" + producto.Unidad + "," +
                                                            "'" + producto.Descripcion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                producto.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                producto.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                producto.Nombre = tabla.Rows[0]["nombre"].ToString();
                producto.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                producto.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                producto.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                producto.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return producto;
        }
        public void EditarProductoDal(Producto producto)
        {
            string consulta = "update producto set idtipoprod=" + producto.IdTipoProducto + "," +
                                                        "idmarca=" + producto.IdMarca + "," +
                                                        "nombre='" + producto.Nombre + "'," +
                                                        "codigobarra='" + producto.CodigoBarra + "'," +
                                                        "unidad=" + producto.Unidad + "," +
                                                        "descripcion='" + producto.Descripcion + "'," +
                                                        "estado='" + producto.Estado + "' " +
                                                "where idproducto=" + producto.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
