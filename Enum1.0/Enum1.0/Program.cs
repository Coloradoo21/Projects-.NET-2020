using System;

namespace Enum1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado(Bonus.Extra, 1950);

            Console.WriteLine("El salario del empleado es:" + Juan.getSalario());

        }



    }

    class Empleado
    {
        public Empleado (Bonus bonusEmpleado, double salario)
        {

            bonus = (double)bonusEmpleado;

            this.salario = salario;

        }

        public double getSalario()
        {
            return salario+bonus;
        }
        
        private double salario, bonus;


    }

    enum Bonus{Bajo=500, Normal=1000, Bueno=1500, Extra=3000};

}
