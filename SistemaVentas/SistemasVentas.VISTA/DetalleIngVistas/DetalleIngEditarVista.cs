using SistemasVentas.BSS;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngEditarVista : Form
    {
        int idx = 0;
        DetalleIng detalleIng = new DetalleIng();
        DetalleIngBss bss = new DetalleIngBss();
        public DetalleIngEditarVista(int id )
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssin = new IngresoBss();
        private void DetalleIngEditarVista_Load(object sender, EventArgs e)
        {
            detalleIng = bss.ObtenerDetalleIngIdBss(idx);
            textBox1.Text = detalleIng.IdIngreso.ToString();
            textBox2.Text = detalleIng.IdProducto.ToString();
            dateTimePicker1.Value = detalleIng.FechaVenc;
            textBox4.Text = detalleIng.Cantidad.ToString();
            textBox6.Text = detalleIng.PrecioCosto.ToString();
            textBox3.Text = detalleIng.PrecioVenta.ToString();
            textBox5.Text = detalleIng.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(textBox4.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(textBox6.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(textBox3.Text);
            detalleIng.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleIngBss(detalleIng);

            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssin.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox1.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
