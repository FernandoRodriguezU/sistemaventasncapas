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

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdEliminarVistar : Form
    {
        int idx = 0;
        TipoProd tipoProd = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEliminarVistar(int id )
        {
            idx = id;
            InitializeComponent();
        }

        private void TipoProdEliminarVistar_Load(object sender, EventArgs e)
        {
            tipoProd = bss.ObtenerTipoProdIdBss(idx);
            textBox1.Text = tipoProd.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoProd.Nombre = textBox1.Text;

            bss.EditarTipoProdBss(tipoProd);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
