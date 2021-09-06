using System;
using System.Text.RegularExpressions;

namespace Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi web es: http://pildorasinformaticas.es";

            string patron = "https://(www.)?pildorasinformaticas.es";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrdo web");
            
                else Console.WriteLine("No se ha encontrado web");
            
        }
    }
}
