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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoEditarVistas : Form
    {
        int idx = 0;
        Ingreso ingreso = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void IngresoEditarVistas_Load(object sender, EventArgs e)
        {
            ingreso = bss.ObtenerIngresoIdBss(idx);
            textBox1.Text = ingreso.IdProveedor.ToString();
            dateTimePicker1.Value = ingreso.FechaIngreso;
            textBox2.Text = ingreso.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso.IdProveedor = IdProveedorSeleccionado;
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToDecimal(textBox2.Text);

            bss.EditarIngresoBss(ingreso);

            MessageBox.Show("Datos Actualizados");
        }
    }
}
