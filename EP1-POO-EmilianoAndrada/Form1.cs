using EP1_POO_EmilianoAndrada.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EP1_POO_EmilianoAndrada
{
    public partial class Form1 : Form
    {
        EntidadFinanciera entidadFinanciera = new EntidadFinanciera();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.ShowDialog();
            if (cliente.rCliente().nombre != "" || cliente.rCliente().apellido != "" || cliente.rCliente().tipoDocumento != "" || cliente.rCliente().nroDocumento != "")
            {
                entidadFinanciera.AgregarCliente(cliente.rCliente());
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = entidadFinanciera.Clientes;
            
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entidadFinanciera.Clientes.Remove((Cliente)dataGridView1.SelectedRows[0].DataBoundItem);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = entidadFinanciera.Clientes;
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("No se Puede Quitar Cliente"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int filaseleecionada = dataGridView1.SelectedRows[0].Index;
                MessageBox.Show("LLene los datos que desea modificar");
                DatosCliente formulario = new DatosCliente();
                formulario.ShowDialog();
                dataGridView1.Rows[filaseleecionada].Selected = true;
                entidadFinanciera.ModificarCliente((Cliente)dataGridView1.SelectedRows[0].DataBoundItem, formulario.rCliente());
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = entidadFinanciera.Clientes;
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("No se Puede Modificar Persona"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatosTarjeta Tarjeta = new DatosTarjeta();
            Tarjeta.ShowDialog();
            if (Tarjeta.rTarjeta().NroTarjeta != "")
            {
                entidadFinanciera.AgregarTarjeta(Tarjeta.rTarjeta());
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = entidadFinanciera.rVistaTarjeta();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                VistaTarjeta aux = (VistaTarjeta)dataGridView2.SelectedRows[0].DataBoundItem;
                entidadFinanciera.Tarjetas.RemoveAll(x => x.NroTarjeta == aux.NroTarjeta);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = entidadFinanciera.rVistaTarjeta();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("No se Puede Quitar Tarjeta"); }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView3.DataSource = null;
                dataGridView3.Refresh();
                dataGridView3.DataSource = ((Cliente)(dataGridView1.SelectedRows[0].DataBoundItem)).Tarjetas;
            }
            catch { }

        }


            private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int filaseleecionada = dataGridView2.SelectedRows[0].Index;
                MessageBox.Show("LLene los datos que desea modificar");
                DatosTarjeta formulario = new DatosTarjeta();
                formulario.ShowDialog();
                dataGridView2.Rows[filaseleecionada].Selected = true;
                entidadFinanciera.ModificarTarjeta((VistaTarjeta)dataGridView2.SelectedRows[0].DataBoundItem, formulario.rTarjeta());
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = entidadFinanciera.rVistaTarjeta();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("No se Puede Modificar Persona"); }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente sCliente = (Cliente) (dataGridView1.SelectedRows[0].DataBoundItem);
                try
                {
                    VistaTarjeta aux = (VistaTarjeta)(dataGridView2.SelectedRows[0].DataBoundItem);
                    Tarjeta sTarjeta = entidadFinanciera.Tarjetas.Find(x => x.NroTarjeta == aux.NroTarjeta);
                    if (sTarjeta.setTitular(sCliente)) { sCliente.Tarjetas.Add(sTarjeta); }
                    dataGridView3.DataSource = null;
                    dataGridView3.Refresh();
                    dataGridView3.DataSource = ((Cliente)(dataGridView1.SelectedRows[0].DataBoundItem)).Tarjetas;
                    

                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cliente sCliente = (Cliente)(dataGridView1.SelectedRows[0].DataBoundItem);
            Tarjeta sTarjeta = (Tarjeta)(dataGridView3.SelectedRows[0].DataBoundItem);
            Tarjeta aux = entidadFinanciera.Tarjetas.Find(x => x.NroTarjeta == sTarjeta.NroTarjeta);
            if (aux.consumoPesos == 0 && aux.consumoDolares == 0)
            {
                sCliente.Tarjetas.RemoveAll(x => x.NroTarjeta == sTarjeta.NroTarjeta);
                int indice = entidadFinanciera.Tarjetas.FindIndex(x => x.NroTarjeta == sTarjeta.NroTarjeta);
                entidadFinanciera.Tarjetas[indice].setTitular(null);
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = ((Cliente)(dataGridView1.SelectedRows[0].DataBoundItem)).Tarjetas;
            }
            else { MessageBox.Show("No se Puede Desvincular Tarjeta El cliente posee Conumos");}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                VistaTarjeta consumo = (VistaTarjeta)(dataGridView2.SelectedRows[0].DataBoundItem);
                Tarjeta aux = entidadFinanciera.Tarjetas.Find(x => x.NroTarjeta == consumo.NroTarjeta);
                DialogResult resultado = MessageBox.Show("Desea que el consumo sea en pesos", "Pesos", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                   string valorConsumo = Interaction.InputBox("Consumo en Pesos", "Ingrese el Valor del consumo", "");
                    aux.GastoExcesivoPesos += GastoExcesivoPesos;
                    aux.AgregarConsumoPesos(Int32.Parse(valorConsumo));
                    aux.GastoExcesivoPesos -= GastoExcesivoPesos;
                }
                else
                {
                    DialogResult resultado2 = MessageBox.Show("Desea que el consumo sea en dolares", "Dolares", MessageBoxButtons.YesNo);
                    if (resultado2 == DialogResult.Yes) {
                        string valorConsumo = Interaction.InputBox("Consumo en Dolares", "Ingrese el Valor del consumo", "");
                        aux.GastoExcesivoDolares += GastoExcesivoDolares;
                        aux.AgregarConsumoDolares(Int32.Parse(valorConsumo));
                        aux.GastoExcesivoDolares -= GastoExcesivoDolares;

                    }

                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = entidadFinanciera.rVistaTarjeta();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Seleecione Una Tarjeta Para el consumo"); }
            
            
            



        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                VistaTarjeta pagos = (VistaTarjeta)(dataGridView2.SelectedRows[0].DataBoundItem);
                Tarjeta aux = entidadFinanciera.Tarjetas.Find(x => x.NroTarjeta == pagos.NroTarjeta);
                DialogResult resultado = MessageBox.Show("Desea que el Pago sea en pesos", "Pesos", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    string valorPago = Interaction.InputBox("Pago en Pesos", "Ingrese el Valor del Pago", "");
                    if (aux is TarjetaPlata) { TarjetaPlata aux1 = (TarjetaPlata)aux; aux1.PagoTarjetaPesos(Int32.Parse(valorPago)); }
                    if (aux is TarjetaGold) { TarjetaGold aux1 = (TarjetaGold)aux; aux1.PagoTarjetaPesos(Int32.Parse(valorPago)); }
                    if (aux is TarjetaPlatinum) { TarjetaPlatinum aux1 = (TarjetaPlatinum)aux; aux1.PagoTarjetaPesos(Int32.Parse(valorPago)); }
                }
                else
                {
                    DialogResult resultado2 = MessageBox.Show("Desea que el consumo sea en dolares", "Dolares", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        string valorpago = Interaction.InputBox("Consumo en Dolares", "Ingrese el Valor del consumo", "");
                        if (aux is TarjetaPlata) { TarjetaPlata aux1 = (TarjetaPlata)aux; aux1.PagoTarjetaDolares(Int32.Parse(valorpago)); }
                        if (aux is TarjetaGold) { TarjetaGold aux1 = (TarjetaGold)aux; aux1.PagoTarjetaDolares(Int32.Parse(valorpago)); }
                        if (aux is TarjetaPlatinum) { TarjetaPlatinum aux1 = (TarjetaPlatinum)aux; aux1.PagoTarjetaDolares(Int32.Parse(valorpago)); }

                    }

                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = entidadFinanciera.rVistaTarjeta();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Seleecione Una Tarjeta Para el consumo"); }

        }

        private void GastoExcesivoPesos(object sender, GastoExcesivoPesosEventsArgs e)
        {
            MessageBox.Show($"La compra de: ({e.valorSobrecarga.ToString()})  supero el limite de la tarjeta, su limite restante es de: ({e.saldoRestante.ToString()}) ");
            
        }

        private void GastoExcesivoDolares(Object sender, GastoExcesivoDolaresEventsArgs e)
        {
            MessageBox.Show($"La compra de: ({e.valorSobrecarga.ToString()})  supero el limite de la tarjeta, su limite restante es de: ({e.saldoRestante.ToString()}) ");
        }
    }
}
