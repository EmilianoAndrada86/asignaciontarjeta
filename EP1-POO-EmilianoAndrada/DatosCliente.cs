using EP1_POO_EmilianoAndrada.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP1_POO_EmilianoAndrada
{
    public partial class DatosCliente : Form
    {
        Cliente nuevo = new Cliente();


        public DatosCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo.nombre = (string)textBox1.Text;
            nuevo.apellido = (string)textBox2.Text;
            nuevo.tipoDocumento = (string)textBox3.Text;
            nuevo.nroDocumento = (string) textBox4.Text;
            this.Close();
        }
        public Cliente rCliente()
        {
            return nuevo;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
