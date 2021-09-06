using System;

namespace ExcepcionFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {

                string linea;

                int contador = 0;

                string path = @"C:\Users\Usuario\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea=archivo.ReadLine())!= null)
                {

                    Console.WriteLine(linea);

                    contador++;
                }

            }
            catch(Exception e)
            {

                Console.WriteLine("Error con la lectura del archivo");

            }
            finally
            {

                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexion con el fichero cerrada");

            }
            //esto que sigue son los servicios que tengo que pagar de la casa, nota
            int epec = 1212;

            int ecogas = 965;

            int servicios = epec + ecogas;

            int MiMitad = servicios / 2;

            Console.WriteLine(MiMitad);
        }
    }
}
