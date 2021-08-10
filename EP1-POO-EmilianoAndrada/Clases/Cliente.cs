using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1_POO_EmilianoAndrada.Clases
{
   public class Cliente
    {
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Tarjeta> Tarjetas = new List<Tarjeta>();

        
        public Cliente() { }

        public Cliente(string tDoc, string nDoc, string nombre, string apellido)
        {
            this.tipoDocumento = tDoc;
            this.nroDocumento = nDoc;
            this.nombre = nombre;
            this.apellido = apellido;

        }



        

    }

}

    
