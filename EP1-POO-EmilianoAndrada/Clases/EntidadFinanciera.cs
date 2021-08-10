using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP1_POO_EmilianoAndrada.Clases
{
    public class EntidadFinanciera
    {
        public List<Tarjeta> Tarjetas = new List<Tarjeta>();
        public List<Cliente> Clientes = new List<Cliente>();

        public void AgregarCliente(Cliente Persona)
        {
            if (Persona.apellido != null || Persona.nombre != null || Persona.nroDocumento != null || Persona.tipoDocumento != null)
            {
                Cliente aux = Clientes.Find(x => x.nroDocumento == Persona.nroDocumento);
                if (aux == null) Clientes.Add(Persona); 

                else  MessageBox.Show("Error DNI Existente"); 
            }

        }

        public void ModificarCliente(Cliente aModificar, Cliente Modificada)
        {
            Cliente aux = Clientes.Find(x => x.nroDocumento == Modificada.nroDocumento);
            if (aux != null) { MessageBox.Show("Error DNI Existente"); }
            else
            {
                if (Modificada != null)
                {
                    int indice = Clientes.IndexOf(aModificar);
                    if (Modificada.nombre != null && (Clientes.ElementAt(indice).nombre != Modificada.nombre && Modificada.nombre != "")) { Clientes.ElementAt(indice).nombre = Modificada.nombre; }
                    if (Modificada.apellido != null && Clientes.ElementAt(indice).apellido != Modificada.apellido && Modificada.apellido != "") { Clientes.ElementAt(indice).apellido = Modificada.apellido; }
                    if (Modificada.nroDocumento != null && Clientes.ElementAt(indice).nroDocumento != Modificada.nroDocumento && Modificada.nroDocumento != "") { Clientes.ElementAt(indice).nroDocumento = Modificada.nroDocumento; }
                    if (Modificada.tipoDocumento != null && Clientes.ElementAt(indice).tipoDocumento != Modificada.tipoDocumento && Modificada.tipoDocumento != "") { Clientes.ElementAt(indice).tipoDocumento = Modificada.tipoDocumento; }
                }
            }
        }

        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            if (tarjeta.NroTarjeta != null || tarjeta.FechaOtorgamiento !=null || tarjeta.FechaVencimiento != null)
            {
                Tarjeta aux = Tarjetas.Find(x => x.NroTarjeta == tarjeta.NroTarjeta);
                if(aux == null ) { Tarjetas.Add(tarjeta); }
                else { MessageBox.Show("Error Numero de Tarjeta Existente"); }

            }
        }
        public void ModificarTarjeta(VistaTarjeta aModificar, Tarjeta Modificada)
        {
            Tarjeta aux = Tarjetas.Find(x => x.NroTarjeta == Modificada.NroTarjeta);
            if (aux != null) { MessageBox.Show("Error Numero de Tarjeta Existente o Numero de Tarjeta Vacio"); }
            else
            {
                if (Modificada != null)
                {
                    int indice = Tarjetas.IndexOf(Tarjetas.Find(x => x.NroTarjeta == aModificar.NroTarjeta));
                    if (Modificada.NroTarjeta != null && (Tarjetas.ElementAt(indice).NroTarjeta != Modificada.NroTarjeta && Modificada.NroTarjeta != "")) { Tarjetas.ElementAt(indice).NroTarjeta = Modificada.NroTarjeta; }
                    if (Modificada.FechaOtorgamiento != new DateTime(0001,1,1,00,00,00) && Tarjetas.ElementAt(indice).FechaOtorgamiento != Modificada.FechaOtorgamiento && Modificada.FechaOtorgamiento != null) { Tarjetas.ElementAt(indice).FechaOtorgamiento = Modificada.FechaOtorgamiento; }
                    if (Modificada.FechaVencimiento != new DateTime(0001, 1, 1, 00, 00, 00) && Tarjetas.ElementAt(indice).FechaVencimiento != Modificada.FechaVencimiento && Modificada.FechaVencimiento != null) { Tarjetas.ElementAt(indice).FechaVencimiento = Modificada.FechaVencimiento; }
                 
                }
            }
        }

        public List<VistaTarjeta> rVistaTarjeta()
        {
            List<VistaTarjeta> _r = new List<VistaTarjeta>();

            foreach(Tarjeta c in Tarjetas)
            {
                if (c is TarjetaPlata) { _r.Add(new VistaTarjeta(c.NroTarjeta, c.FechaOtorgamiento, c.FechaVencimiento, "Plata", c.Saldo_Maximo_Pesos - c.consumoPesos, c.Saldo_Maximo_Dolares - c.consumoDolares)); }
                if (c is TarjetaGold) { _r.Add(new VistaTarjeta(c.NroTarjeta, c.FechaOtorgamiento, c.FechaVencimiento, "Gold", c.Saldo_Maximo_Pesos - c.consumoPesos, c.Saldo_Maximo_Dolares - c.consumoDolares)); }
                if (c is TarjetaPlatinum) { _r.Add(new VistaTarjeta(c.NroTarjeta, c.FechaOtorgamiento, c.FechaVencimiento, "Platinum", c.Saldo_Maximo_Pesos - c.consumoPesos, c.Saldo_Maximo_Dolares - c.consumoDolares)); }
            }

            return _r;
        }

        

    }
}
