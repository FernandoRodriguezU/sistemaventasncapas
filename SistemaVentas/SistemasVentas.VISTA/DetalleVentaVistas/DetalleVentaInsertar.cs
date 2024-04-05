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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertar : Form
    {
        public DetalleVentaInsertar()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        public static int IdVentaSeleccionado = 0;
        VentaBss bssv = new VentaBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.IdVenta = Convert.ToInt32(textBox1.Text);
            detalleVenta.IdProducto = Convert.ToInt32(textBox2.Text);
            detalleVenta.Cantidad = Convert.ToInt32(textBox4.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(textBox3.Text);
            detalleVenta.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(detalleVenta);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DetalleVentaInsertar_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
