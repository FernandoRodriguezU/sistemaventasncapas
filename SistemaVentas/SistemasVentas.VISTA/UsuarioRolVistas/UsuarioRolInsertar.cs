using SistemasVentas.BSS;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertar : Form
    {
        public UsuarioRolInsertar()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssu = new UsuarioBss();
        public static int IdRolSeleccionado = 0;
        RolBss bssr = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = Convert.ToInt32(textBox2.Text);
            usuarioRol.IdRol = Convert.ToInt32(textBox3.Text);
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Se guardó correctamente a UsuarioRol");
        }

        private void UsuarioRolInsertar_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssu.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }
    }
}
