using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EP1_POO_EmilianoAndrada.Clases
{
    class TarjetaGold : Tarjeta
    {
        public TarjetaGold(string nTarjeta, DateTime FO, DateTime FV, int SMP, int SMD, int cP, int cD)
        { NroTarjeta = nTarjeta; FechaOtorgamiento = FO; FechaVencimiento = FV; Saldo_Maximo_Pesos = 150000; Saldo_Maximo_Dolares = 2000; consumoPesos = cP; consumoDolares = cD; }
        public TarjetaGold() { Saldo_Maximo_Pesos = 150000; Saldo_Maximo_Dolares = 2000; }
        public void PagoTarjetaPesos(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 20;
            consumoPesos -= (Pago - pagoDescuento);
        }
        public void PagoTarjetaDolares(int Pago)
        {
            int pagoDescuento = (Pago / 100) * 2;
            consumoDolares -= Pago - pagoDescuento;
        }
    }
}
