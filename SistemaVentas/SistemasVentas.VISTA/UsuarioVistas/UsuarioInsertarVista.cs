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
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSelecionada = 0;
        UsuarioBss bssu = new UsuarioBss();
        PersonaBss bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSelecionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssuser.InsertarUsuarioBss(usuario);

            MessageBox.Show("Usuario Registrado");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        UsuarioBss bssuser = new UsuarioBss();

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
