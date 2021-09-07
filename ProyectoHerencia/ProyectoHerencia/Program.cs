using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballos miBabieca = new Caballos("Babieca");

            IMamiferosTerrestres Imibabieca = miBabieca;
            
            Humano miJuan = new Humano("Juan");
            Gorila miHarambe = new Gorila("Harambe");

            
            Object miAnimal = new Caballos("Bucefalo");

            Object miPersona = new Humano("Ricardo");

            Object miMamifero = new Mamíferos("Willy");

            Mamíferos[] almacenDeAnimales = new Mamíferos[3];

            almacenDeAnimales[0] = miBabieca;
            almacenDeAnimales[1] = miJuan;
            almacenDeAnimales[2] = miHarambe;

            for (int i=0; i < 3; i++)
            {
                almacenDeAnimales[i].pensar();
            }

            /*almacenDeAnimales[1].getNombre();*/


            /*Mamíferos animal = new Mamíferos("Bucefalo");

            Caballos Bucefalo = new Caballos("Bucefalo");

            animal = Bucefalo;*/


            /*Mamíferos animal = new Caballos("Bucefalo");

            Mamíferos persona = new Humano("Erwin");

            Mamíferos primate = new Gorila("Copito");*/



            /* miJuan.getNombre();
             miBabieca.getNombre();
             miHarambe.getNombre();
            Ballena miWally = new Ballena("Wally");
            miWally.nadar();
            Console.WriteLine("Numero de patas de babieca "+Imibabieca.numeroPatas());*/
            Lagartija Juancho = new Lagartija("Juancho");
            Juancho.getNombre();

            Humano Juan = new Humano("Juan");
            Juan.getNombre();
        }
    }
    interface IMamiferosTerrestres
    {

        int numeroPatas();

    }

    interface IAnimalesYDeportes
    {
        string TipoDeporte();

        bool EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }

    abstract class Animales 
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
      



    }

    class Lagartija:Animales
    {
        public Lagartija (string nombre)
        {
            nombreReptil = nombre;
        }


        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es:"+nombreReptil);

        }
        private string nombreReptil;
    }
    
    
    
    class Mamíferos:Animales
    {
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del mamifero es: {nombreSerVivo}");
        } 
        public Mamíferos(String nombre)
        {

            nombreSerVivo = nombre;

        }

        private string nombreSerVivo;


        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas.");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo.");
        }
    }
    class Ballena : Mamíferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballos:Mamíferos,IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar.");
        }

        public Caballos(String nombreCaballo) : base(nombreCaballo)
        {

        }
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public string TipoDeporte()
        {
            return "Se utiliza en polo.";
        }

        public bool EsOlimpico()
        {
            return true;
        }
    }
    class Humano : Mamíferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar.");
        }
    }
    /*class Adolescente:Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con claridad");
        }
    }*/
    class Gorila : Mamíferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar.");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado.");
        }
        public int numeroPatas()
        {
            return 2;
        }
        class Chimpance:Gorila
        {
            public Chimpance(string nombreChimpance) : base(nombreChimpance)
            {

            }
        }
    }
}
