using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistas;
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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        public static int IdClienteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        public static int IdVendedorSeleccionado = 0;
        UsuarioBss bssus = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.IdCliente = IdClienteSeleccionado;
            venta.IdVendedor = IdVendedorSeleccionado;
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox3.Text);
            venta.Estado = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentaInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssus.ObtenerUsuarioIdBss(IdVendedorSeleccionado);
                textBox2.Text = usuario.IdUsuario.ToString();
            }
        }
    }
}
