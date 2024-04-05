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

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssp = new ProductoBss();
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssig = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng detalleIng = new DetalleIng();
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(textBox4.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(textBox7.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(textBox3.Text);
            detalleIng.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleIngBss(detalleIng);

            MessageBox.Show("Se guardó correctamente a Detalle Ing");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetalleIngInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssp.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssig.ObtenerIngresoIdBss(IdProductoSeleccionado);
                textBox2.Text = ingreso.IdIngreso.ToString();
            }
        }
    }
    }

   

