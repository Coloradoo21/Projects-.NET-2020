using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] edades;
            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;
            edades[4] = 91;

            int[] edades =new int [5] { 15, 27, 19, 80,13};

            Console.WriteLine(edades[2]);*/

            //array implicito

            //var datos = new[] { "Juan","Perez",15};

            var valores = new[] { 15, 28, 75.5, 30.30 };//todo a double

            //array de objetos

            Empleados Ana = new Empleados("Ana", 17);

            Empleados[] arrayEmpleados = new Empleados[3];

                arrayEmpleados[0] = new Empleados("Sara",17);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 51);

            //array de tipos o clases anonimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=35},

                new{Nombre="Ana", Edad=22},

                new{Nombre="Erwin", Edad=25}

            };
            
               
            /*for(int i = 0; i <arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }

        }
    }

    class Empleados
    {
        public Empleados (String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string getInfo()
        {
            return "Nombre del empleado: " + nombre + " Edad: " + edad;
        }
        private String nombre;
        private int edad;
    }
}
