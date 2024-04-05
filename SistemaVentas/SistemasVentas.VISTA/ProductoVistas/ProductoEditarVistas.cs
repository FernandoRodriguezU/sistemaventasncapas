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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVistas : Form
    {
        int idx = 0;
        Producto producto = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVistas(int id)
        {
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss bsstp = new TipoProdBss();
        public static int IdMarcaSeleccionado = 0;
        MarcaBss bssm = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            producto.IdTipoProducto = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionado;
            producto.Nombre = textBox4.Text;
            producto.CodigoBarra = textBox3.Text;
            producto.Unidad = Convert.ToInt32(textBox5.Text);
            producto.Descripcion = textBox6.Text;

            bss.EditarProductoBss(producto);

            MessageBox.Show("Datos Actualizados");
        }

        private void ProductoEditarVistas_Load(object sender, EventArgs e)
        {
            producto = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = producto.IdTipoProducto.ToString();
            textBox2.Text = producto.IdMarca.ToString();
            textBox4.Text = producto.Nombre;
            textBox3.Text = producto.CodigoBarra;
            textBox5.Text = producto.Unidad.ToString();
            textBox6.Text = producto.Descripcion;
        }
    }
}
