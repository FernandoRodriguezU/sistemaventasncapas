using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioVistas;
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
    public partial class GerenteVista : Form
    {
        public GerenteVista()
        {
            InitializeComponent();
        }

        private void GerenteVista_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioListarVista user = new UsuarioListarVista();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioListarVista user = new UsuarioListarVista();
            user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipoProdListarVista tipoProd = new TipoProdListarVista();
            tipoProd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaListarVista marca = new MarcaListarVista();
            marca.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteListarVista cliente = new ClienteListarVista();
            cliente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveedorListarVista proveedor = new ProveedorListarVista();
            proveedor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IngresoListarVista ingreso = new IngresoListarVista();
            ingreso.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductoListarVista producto = new ProductoListarVista();
            producto.Show();
        }
    }
}
