using SistemasVentas.DAL;
using SistemasVentas.VISTA.GerenteVistas;
using SistemasVentas.VISTA.inicio;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemasVentas.VISTA.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
          
                this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string usuario = user.Text;
            string contraseña = pass.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                GerenteLoginVistas formulario = new GerenteLoginVistas();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string usuario = user.Text;
            string contraseña = pass.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                GerenteLoginVistas formulario = new GerenteLoginVistas();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}