using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miarchivo = new ManejoArchivos();

            miarchivo.mensaje();
        }
    }

    class ManejoArchivos
    {

        StreamReader archivos = null;

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {

            archivos = new StreamReader(@"c:\texto.txt");

            while ((linea = archivos.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        ~ManejoArchivos()
        {
            archivos.Close();
        }
            

    }


}
