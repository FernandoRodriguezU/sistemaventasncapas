using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Marca ObtenerMarcaIdDal(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Marca marca = new Marca();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                marca.Nombre = tabla.Rows[0]["nombre"].ToString();
                marca.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return marca;
        }
        public void EditarMarcaDal(Marca marca)
        {
            string consulta = "update marca set nombre='" + marca.Nombre + "'," +
                                                        "estado='" + marca.Estado + "' " +
                                                "where idmarca=" + marca.IdMarca;
            conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
