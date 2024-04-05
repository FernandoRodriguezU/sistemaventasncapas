using SistemasVentas.BSS;
using SistemasVentas.DAL;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVistas : Form
    {
        int idx = 0;
        UsuarioRol usuarioRol = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();
        public UsuarioRolEditarVistas(int id )
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssu = new UsuarioBss();
        public static int IdRolSeleccionado = 0;
        RolBss bssr = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            usuarioRol.IdUsuario = IdUsuarioSeleccionado;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bss.EditarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Datos Actualizados");
        }

        private void UsuarioRolEditarVistas_Load(object sender, EventArgs e)
        {
            usuarioRol = bss.ObtenerUsuarioRolIdBss(idx);
            textBox2.Text = usuarioRol.IdUsuario.ToString();
            textBox3.Text = usuarioRol.IdRol.ToString();
            dateTimePicker1.Value = usuarioRol.FechaAsigna;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssu.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssr.ObtenerIdBss(IdRolSeleccionado);
                textBox3.Text = rol.Nombre;
            }
        }
    }
}
