using EjBasicosPOO_1.Clases;


internal class Program
{
    private static void Main(string[] args)
    {

        Coche c = new Coche(20, "Ford", "Ka", 20000, 10000, true);          // Cuando pongo true --> se modifica el precio
        Moto m = new Moto(20, "Kawasaki", "ZX-600", 25000, 15000, false);

        Console.WriteLine($"Precio coche : {c.Precio}");
        Console.WriteLine($"Precio moto : {m.Precio}\n");

        Console.WriteLine(c.ToString());
        Console.WriteLine(m.ToString());    

        //Vehiculo c1 = new Vehiculo(1, "Ford", "Kuga", 20000, 35200);
        //Console.WriteLine(c.Precio);

        //c.Precio = 15000;       //Así se accede y modifican los atributos de los objetos
        //Console.WriteLine($"Otra vez precio modif : {c.Precio}");

        /* *****PRIMERA PARTE : ANTES DE HACER HERENCIA DE VEHILULO Y CREAR LAS CLASES COCHE Y MOTO***
         
        Consecionario concesionario= new Consecionario(10, 0);

        Vehiculo c2 = new Vehiculo(2, "Ford", "Ka", 20000, 8200);
        Vehiculo c3 = new Vehiculo(3, "Ford", "Fiesta", 25000, 15200);
        Vehiculo c4 = new Vehiculo(4, "Ford", "Orion", 24000, 25000);
        Vehiculo c5 = new Vehiculo(5, "Ford", "Sierra", 21000, 25200);

        concesionario.AñadirCoche(c1);
        concesionario.AñadirCoche(c2);
        concesionario.AñadirCoche(c3);
        concesionario.AñadirCoche(c4);
        concesionario.AñadirCoche(c5);

        Console.WriteLine("\nLos coches que tiene el concesionario son :");
        concesionario.MostrarCoches();
        Console.WriteLine("\nPulsa TECLA para seguir -->");
        Console.ReadKey();

        concesionario.QuitarCoche(c3);

        Console.WriteLine("\nLos coches que quedan en el concesionario son :");
        concesionario.MostrarCoches();
        Console.WriteLine("\nPulsa TECLA para seguir -->");
        Console.ReadKey();

        concesionario.QuitarCoche(c1);

        Console.WriteLine("\nLos coches que quedan en el concesionario son :");
        concesionario.MostrarCoches();
        Console.WriteLine("\nPulsa TECLA para seguir -->");
        Console.ReadKey();


        concesionario.AñadirCoche(c3);
        Console.WriteLine("\nLos coches que quedan en el concesionario son :");
        concesionario.MostrarCoches();
        Console.WriteLine("\nPulsa TECLA para seguir -->");
        Console.ReadKey();

        Console.WriteLine("\nSe van a quitar todos los coches.");
        concesionario.VaciarCoches();

        Console.WriteLine("\nLos coches que quedan en el concesionario son :");
        concesionario.MostrarCoches();
        Console.WriteLine("\nPulsa TECLA para seguir -->");
        Console.ReadKey();

        ******                  ***********
        *
        */



        Console.WriteLine("\nPulsa TECLA para finalizar X");
        Console.ReadKey();
    }
}

