using SistemasVentas.VISTA.administrador;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.GerenteVistas;
using SistemasVentas.VISTA.iniciovistas;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.inicio
{
    public partial class In : Form
    {
        public In()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GerenteLoginVistas formulario = new GerenteLoginVistas();
            formulario.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GerenteVista listarvista = new GerenteVista();
            listarvista.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedor formulario = new Vendedor();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
