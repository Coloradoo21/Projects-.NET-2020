using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {
       
        public AvisosTrafico()
        {
            Remitente = "DGT";

            Mensaje = "Sancion cometida. Pague antes de tres dias y se beneficiara en una reduccion de la sancion del 50%";

            Fecha = "";
        }

        public AvisosTrafico(string Remitente, string Mensaje, string Fecha)
        {
            this.Remitente = Remitente;
            this.Mensaje = Mensaje;
            this.Fecha = Fecha;
        }

        
        public string getFecha()
        {
            return Fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2},",Mensaje, Remitente, Fecha);
        }

        private string Remitente;

        private string Mensaje;

        private string Fecha;
    }
}
