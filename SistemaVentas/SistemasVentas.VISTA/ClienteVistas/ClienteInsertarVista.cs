using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
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



namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        public void button1_Click(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            C.TipoCliente = textBox1.Text;
            C.CodigoCliente = textBox2.Text;
            C.IdCliente = Convert.ToInt32(textBox3.Text);
            bss.InsertarClienteBss(C);
            MessageBox.Show("El cliente se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
