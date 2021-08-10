using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP1_POO_EmilianoAndrada.Clases
{
    public class Tarjeta
    {
        public string NroTarjeta { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Saldo_Maximo_Pesos { get; set; }
        public int Saldo_Maximo_Dolares { get; set; }
        public int consumoPesos = 0;
        public int consumoDolares = 0;
        Cliente Titular;

        public Tarjeta(string nTarjeta, DateTime FO, DateTime FV, int SMP, int SMD, int cP, int cD) 
        { NroTarjeta = nTarjeta;FechaOtorgamiento = FO; FechaVencimiento = FV; Saldo_Maximo_Pesos = SMP; Saldo_Maximo_Dolares= SMD; consumoPesos = cP; consumoDolares = cD;}
        
        public Tarjeta() { }

        public bool setTitular(Cliente titular)
        {
            if (Titular == null || titular == null) { Titular = titular; return true; }
            else { MessageBox.Show("Error esta tarjeta ya posee titular"); return false; }
        }
        public void AgregarConsumoPesos(int consumo)
        {
            consumoPesos += consumo;
            if(consumoPesos > Saldo_Maximo_Pesos) { consumoPesos -= consumo; GastoExcesivoPesos?.Invoke(this, new GastoExcesivoPesosEventsArgs(consumo, Saldo_Maximo_Pesos - consumoPesos ));  }
            
        }

        public void AgregarConsumoDolares(int consumo)
        {
            consumoDolares += consumo;
            if (consumoDolares > Saldo_Maximo_Dolares) { consumoDolares -= consumo; GastoExcesivoDolares?.Invoke(this, new GastoExcesivoDolaresEventsArgs(consumo, Saldo_Maximo_Dolares - consumoDolares)); }
        }

        public event EventHandler<GastoExcesivoPesosEventsArgs> GastoExcesivoPesos;
        public event EventHandler<GastoExcesivoDolaresEventsArgs> GastoExcesivoDolares;

    }

    public class GastoExcesivoPesosEventsArgs : EventArgs 
        {
        public int valorSobrecarga;
        public int saldoRestante;
        public GastoExcesivoPesosEventsArgs(int valor, int saldo) { valorSobrecarga = valor; saldoRestante = saldo; }
    
    
        }

    public class GastoExcesivoDolaresEventsArgs : EventArgs
    {
        public int valorSobrecarga;
        public int saldoRestante;
        public GastoExcesivoDolaresEventsArgs(int valor, int saldo) { valorSobrecarga = valor; saldoRestante = saldo; }
    
    }


}
