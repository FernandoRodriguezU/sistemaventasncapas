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
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(cliente);

            MessageBox.Show("Datos Actualizados");
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
