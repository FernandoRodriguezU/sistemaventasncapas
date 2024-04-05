using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVistas : Form
    {
        int idx = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox4.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(usuario);

            MessageBox.Show("Datos Actualizados");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        private void UsuarioEditarVistas_Load(object sender, EventArgs e)
        {
            usuario = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = usuario.IdPersona.ToString();
            textBox2.Text = usuario.NombreUser;
            textBox4.Text = usuario.Contraseña;
            dateTimePicker1.Value = usuario.FechaReg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerIdBss(IdPersonaSeleccionada);
                textBox2.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
