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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaInsertarVistas : Form
    {
        public MarcaInsertarVistas()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = textBox4.Text;

            bss.InsertarMarcaBss(marca);

            MessageBox.Show("Se guardo correctamente");
        }

        private void MarcaInsertarVistas_Load(object sender, EventArgs e)
        {

        }
    }
}
