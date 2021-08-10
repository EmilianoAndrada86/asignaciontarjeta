using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1_POO_EmilianoAndrada.Clases
{
    public class VistaTarjeta
    {
        public string NroTarjeta { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string tipoTarjeta { get; set; }
        public int SaldoPesos { get; set; }
        public int SaldoDolares { get; set; }

        public VistaTarjeta(string nTarjeta, DateTime FO, DateTime FV, string tTarjeta, int SP, int SD)
        { NroTarjeta = nTarjeta; FechaOtorgamiento = FO; FechaVencimiento = FV; tipoTarjeta = tTarjeta; SaldoPesos = SP; SaldoDolares = SD; }

        public List<VistaTarjeta> vista(List<Tarjeta> lTarjeta)
        {
            List<VistaTarjeta> aux = null;

            return aux;
        }

    }
}
