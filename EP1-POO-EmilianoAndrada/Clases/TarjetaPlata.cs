using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1_POO_EmilianoAndrada.Clases
{
    class TarjetaPlata : Tarjeta
    {
        public TarjetaPlata (string nTarjeta, DateTime FO, DateTime FV, int SMP, int SMD, int cP, int cD)
        { NroTarjeta = nTarjeta; FechaOtorgamiento = FO; FechaVencimiento = FV; Saldo_Maximo_Pesos = 75000; Saldo_Maximo_Dolares = 1000; consumoPesos = cP; consumoDolares = cD; }
        
        public TarjetaPlata() { Saldo_Maximo_Pesos = 75000; Saldo_Maximo_Dolares = 1000; }

        public void PagoTarjetaPesos(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 30;
            consumoPesos -= (Pago-pagoDescuento);
        }
        public void PagoTarjetaDolares(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 3;
            consumoDolares -= Pago - pagoDescuento;
        }
    }
}
