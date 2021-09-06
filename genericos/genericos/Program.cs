using System;

namespace genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            /* archivos.agregar("Juan");

             archivos.agregar("Fede");

             archivos.agregar("Erwin");

             archivos.agregar("Marcia");*/

            archivos.agregar(new Empleado(1500));

            archivos.agregar(new Empleado(2500));

            archivos.agregar(new Empleado(3500));

            archivos.agregar(new Empleado(4500));

            string nombrePersona =(string) archivos.getElemento(2);

            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new object[z];
        }

        public void agregar(object obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public object getElemento(int i)
        {
            return datosElemento[i];
        }


        private object[] datosElemento;

        private int i = 0;
    }

    class Empleado
    {
        public double getSalario()
        {
            return salario;
        }
        
        private double salario;

        public Empleado(double salario)
        {

            this.salario = salario;

        }
    }
    
}
