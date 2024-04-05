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
    public partial class DetalleVentaEditar : Form
    {
        int idx = 0;
        DetalleVenta detalleVenta = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditar(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdVentaSeleccionado = 0;
        VentaBss bssv = new VentaBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            detalleVenta.IdVenta = IdVentaSeleccionado;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(textBox4.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(textBox3.Text);
            detalleVenta.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(detalleVenta);

            MessageBox.Show("Datos Actualizados");
        }

        private void DetalleVentaEditar_Load(object sender, EventArgs e)
        {
            detalleVenta = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = detalleVenta.IdVenta.ToString();
            textBox2.Text = detalleVenta.IdProducto.ToString();
            textBox4.Text = detalleVenta.Cantidad.ToString();
            textBox3.Text = detalleVenta.PrecioVenta.ToString();
            textBox5.Text = detalleVenta.SubTotal.ToString();
        }
    }
}
