using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class UsuarioDal
    {
        public DataTable LIstarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + usuario.IdPersona + " , " +
                                                            " '" + usuario.NombreUser + "' , " +
                                                            " '" + usuario.Contraseña + "' , " +
                                                            " '" + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
        public DataTable UsuarioDatosDal()
        {
            string consulta = "SELECT      USUARIO.IDUSUARIO, PERSONA.NOMBRE, PERSONA.APELLIDO, ROL.NOMBRE AS Rol, USUARIOROL.FECHAASIGNA, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG\r\nFROM            USUARIO INNER JOIN\r\n                         PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA INNER JOIN\r\n                         USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\r\n                         ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
