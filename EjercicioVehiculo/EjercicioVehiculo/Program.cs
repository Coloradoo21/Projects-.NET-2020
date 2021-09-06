using System;

namespace EjercicioVehiculo
{
    //Crear 3 clases(vehiculo, avion, coche)Metodos comunes a las 3 clases(arrancar y parar motor) Metodo virtual conducir.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avion");
            Avion miAvion = new Avion();
            miAvion.ArrancarMotor();
            miAvion.despegar();
            miAvion.conducir();
            miAvion.aterrizar();
            miAvion.pararMotor();

            Console.WriteLine();
            Console.WriteLine("Probando el coche");
            Coche miCoche = new Coche();
            miCoche.ArrancarMotor();
            miCoche.acelerar();
            miCoche.conducir();
            miCoche.frenar();
            miCoche.pararMotor();

            Console.WriteLine();
            Console.WriteLine("Polimorfismo en accion");

            Vehiculo miVehiculo = miCoche;
            miVehiculo.conducir();
            miVehiculo = miAvion;
            miAvion.conducir();
        }
    }
    class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine($"Has encendido el motor de tu vehiculo");
        }
        public void pararMotor()
        {
            Console.WriteLine("Has detenido el motor de tu vehiculo");
        }
        public virtual void conducir()
        {
            Console.WriteLine("Estas conduciendo tu vehiculo");
        }

        
    }

    class Coche : Vehiculo
    {
        public override void conducir()
        {
            Console.WriteLine("Estas conduciendo tu automovil");
        }
        public void acelerar()
        {
            Console.WriteLine("El coche está acelerando");
        }
        public void frenar()
        {
            Console.WriteLine("El coche esta frenando");
        }
    }
    class Avion : Vehiculo
    {
        public override void conducir()
        {
            Console.WriteLine("Estas conduciendo un avion");
        }
        public void aterrizar()
        {
            Console.WriteLine("El avion esta aterrizando");
        }
        public void despegar()
        {
            Console.WriteLine("Despegando");
        }
    }
}
