using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE +' '+ PERSONA.APELLIDO)NOMBRE_COMPLETO, " +
                                    "CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO\r\n" +
                                    "FROM     CLIENTE INNER JOIN\r\n" +
                                    "PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                            "'" + cliente.TipoCliente + "'," +
                                                            "'" + cliente.CodigoCliente + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                cliente.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                cliente.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                cliente.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return cliente;
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update cliente set idpersona=" + cliente.IdPersona + "," +
                                                        "tipocliente='" + cliente.TipoCliente + "'," +
                                                        "codigocliente='" + cliente.CodigoCliente + "'" +
                                                "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}

