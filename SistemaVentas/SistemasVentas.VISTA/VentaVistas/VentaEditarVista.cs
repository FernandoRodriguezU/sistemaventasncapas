using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta venta = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        public static int IdVendedorSeleccionado = 0;
        UsuarioBss bssus = new UsuarioBss();

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            venta = bss.ObtenerVentaIdBss(idx);
            textBox1.Text = venta.IdCliente.ToString();
            textBox2.Text = venta.IdVendedor.ToString();
            dateTimePicker1.Value = venta.Fecha;
            textBox4.Text = venta.Total.ToString();
            textBox3.Text = venta.Estado;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
