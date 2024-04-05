using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.inicio
{
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void Vendedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DetalleIngBss bss = new DetalleIngBss();
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RolBss bss = new RolBss();
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            UsuarioRolBss bss = new UsuarioRolBss();
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ProveeBss bss = new ProveeBss();
            dataGridView1.DataSource = bss.ListarProveeBss();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DetalleVentaBss bss = new DetalleVentaBss();
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PersonaBss bss = new PersonaBss();

                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PersonaBss bss = new PersonaBss();
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PersonaBss bss = new PersonaBss();
                bss.EliminarPersonaBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }
    }
}
