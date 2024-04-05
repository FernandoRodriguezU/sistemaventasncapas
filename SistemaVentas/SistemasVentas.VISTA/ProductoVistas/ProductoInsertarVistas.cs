using SistemasVentas.BSS;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
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
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss bsstp = new TipoProdBss();
        public static int IdMarcaSeleccionado = 0;
        MarcaBss bssm = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProducto = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionado;
            producto.Nombre = textBox4.Text;
            producto.CodigoBarra = textBox3.Text;
            producto.Unidad = Convert.ToInt32(textBox5.Text);
            producto.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(producto);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = bsstp.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        private void ProductoInsertarVistas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVista fr = new MarcaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssm.ObtenerMarcaIdBss(IdMarcaSeleccionado);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
