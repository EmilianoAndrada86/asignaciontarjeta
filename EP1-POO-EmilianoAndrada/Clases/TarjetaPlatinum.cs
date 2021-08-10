using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1_POO_EmilianoAndrada.Clases
{
    class TarjetaPlatinum : Tarjeta
    {
        public TarjetaPlatinum(string nTarjeta, DateTime FO, DateTime FV, int SMP, int SMD, int cP, int cD)
        { NroTarjeta = nTarjeta; FechaOtorgamiento = FO; FechaVencimiento = FV; Saldo_Maximo_Pesos = 200000; Saldo_Maximo_Dolares = 3000; consumoPesos = cP; consumoDolares = cD; }
        
        public TarjetaPlatinum() { Saldo_Maximo_Pesos = 200000; Saldo_Maximo_Dolares = 3000; }

        public void PagoTarjetaPesos(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 10;
            consumoPesos -= (Pago - pagoDescuento);
        }
        public void PagoTarjetaDolares(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 1;
            consumoDolares -= Pago - pagoDescuento;
        }
    }
}
