using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT USUARIOROL.IDUSUARIOROL, (USUARIO.NOMBREUSER +'  /  '+ " +
                                "USUARIO.CONTRASEÑA)USUARIO_Y_CONTRASEÑA, ROL.NOMBRE AS ROL, " +
                                "USUARIOROL.FECHAASIGNA AS FECHA_ASIGNADA, USUARIOROL.ESTADO\r\n" +
                                "FROM     USUARIOROL INNER JOIN\r\n                 " +
                                "USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n" +
                                "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + "," +
                                                            "" + usuarioRol.IdRol + "," +
                                                            "'" + usuarioRol.FechaAsigna + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            UsuarioRol usuarioRol = new UsuarioRol();
            if (tabla.Rows.Count > 0)
            {

                usuarioRol.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                usuarioRol.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                usuarioRol.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                usuarioRol.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                usuarioRol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return usuarioRol;
        }
        public void EditarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "update usuariorol set idusuario=" + usuarioRol.IdUsuario + "," +
                                                        "idrol=" + usuarioRol.IdRol + "," +
                                                        "fechaasigna='" + usuarioRol.FechaAsigna + "', " +
                                                        "estado='" + usuarioRol.Estado + "' " +
                                                "where idusuariorol=" + usuarioRol.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
