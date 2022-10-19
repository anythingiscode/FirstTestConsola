using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    static void staircase (int n)
    {
        StringBuilder sb = new StringBuilder ();    //Es un generador de cadenas de caracteres

        for (int i = 0; i < n; i++)
        {
            sb.Append (' ', n - (i + 1));        //Append : Añade caracteres una cantida de veces determinada 
            sb.Append ('#', i +1);
            Console.WriteLine (sb.ToString ()); //Tenemos que convertir los caracteres a string para poder imprimirlos en consola
            sb.Clear ();                        //Ya impreso lo borramos para poder generar la siguiente cadena de caracteres
        }
    }

    static void miEscalera(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = n - i - 1; j > 0; j--)
            {
                Console.Write(".");
            }
            for (int k = i + 1; k > 0; k--)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        
        int n = 0;      ///Num de peldaños
        Console.WriteLine("Hola. introduzca el número de peldaños entre 0 y 100 para la escalera :");
        n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("\nSolución 1 : \n");
        staircase(n);
        Console.WriteLine("\n\n mi solución :\n");
        miEscalera(n);  


       
        Console.ReadKey();
    }
}