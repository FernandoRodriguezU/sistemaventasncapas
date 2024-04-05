using SistemasVentas.VISTA.GerenteVistas;
using SistemasVentas.VISTA.inicio;
using SistemasVentas.VISTA.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemasVentas.VISTA.iniciovistas
{
    public partial class InicioVista : Form
    {
        public InicioVista()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InicioVista_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GerenteLoginVistas listarvista = new GerenteLoginVistas();
            listarvista.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            In formulario = new In();
            formulario.Show();
        }
    }
}
