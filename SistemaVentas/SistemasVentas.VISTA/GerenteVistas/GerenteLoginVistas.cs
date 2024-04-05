using SistemasVentas.DAL;
using SistemasVentas.VISTA.inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.GerenteVistas
{
    public partial class GerenteLoginVistas : Form
    {
        public GerenteLoginVistas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = user.Text;
            string contraseña = pass.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                In formulario = new In();
                formulario.Show();

                // Aquí puedes abrir el formulario principal o realizar cualquier otra acción después del inicio de sesión exitoso
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

            }
        }
    }
}
