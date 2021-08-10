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
    public partial class DatosTarjeta : Form
    {
        Tarjeta nTarjeta = new Tarjeta();

        public DatosTarjeta()
        {
            InitializeComponent();
        }

        private void DatosTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux = textBox1.Text.Substring(0, 4);
                switch (aux)
                {
                case "9999":
                    TarjetaPlatinum tarjetaP = new TarjetaPlatinum();
                    tarjetaP.NroTarjeta = textBox1.Text;
                    tarjetaP.FechaOtorgamiento = dateTimePicker1.Value;
                    tarjetaP.FechaVencimiento = dateTimePicker2.Value;
                    nTarjeta = tarjetaP;
                    
                    break;
                case "8888":
                    TarjetaGold tarjetaG = new TarjetaGold();
                    tarjetaG.NroTarjeta = textBox1.Text;
                    tarjetaG.FechaOtorgamiento = dateTimePicker1.Value;
                    tarjetaG.FechaVencimiento = dateTimePicker2.Value;
                    nTarjeta = tarjetaG;
                    
                    break;
                case "7777":
                    TarjetaPlata TarjetaPl = new TarjetaPlata();

                    TarjetaPl.NroTarjeta = textBox1.Text;
                    TarjetaPl.FechaOtorgamiento = dateTimePicker1.Value;
                    TarjetaPl.FechaVencimiento = dateTimePicker2.Value;
                    nTarjeta = TarjetaPl;
                    break;
                default:
                    MessageBox.Show("Error Numero de Tarjeta Invalido");
                    break;

                    
                }
            this.Close();

        }
        public Tarjeta rTarjeta()
        {
            return nTarjeta;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
