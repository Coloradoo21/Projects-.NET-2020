using System;

namespace PracticaProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");
            Juan.SALARIO = 1200;

            Console.WriteLine("El salario del empleado es de:" + Juan.SALARIO);

        }
    }

    class Empleado
    {
        private string Nombre;
        private double Salario;
        public Empleado(string nombre)
        {

            this.Nombre = nombre;

        }

       /* public double SALARIO
        {
            get{ return this.Salario; }
            set { this.Salario = EvaluaSalario(value); }

        }*/

        public double SALARIO
        {
            get => this.Salario;

            set => this.Salario = EvaluaSalario(value);


        }

        private double EvaluaSalario(double Salario)
        {
            if (Salario < 0) return 0;
            else return Salario;
        }

        /*public void SetSalario(double Salario)
        {
            if (Salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo, se asigno salario 0.");
                this.Salario = 0;
            }
            else 
            {
                this.Salario = Salario;
            }


        }
        public double GetSalario()
        {
            return Salario;
        }*/


    }
}
