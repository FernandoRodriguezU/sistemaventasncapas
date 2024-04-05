using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProveedorVistas;
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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVistas : Form
    {
        public IngresoInsertarVistas()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdProveedor = Convert.ToInt32(textBox1.Text);
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToDecimal(textBox2.Text);

            bss.InsertarIngresoBss(ingreso);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bsspv.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox1.Text = proveedor.Nombre;
            }
        }

        private void IngresoInsertarVistas_Load(object sender, EventArgs e)
        {

        }
    }
}
