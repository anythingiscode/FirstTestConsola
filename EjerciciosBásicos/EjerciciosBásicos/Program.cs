using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Detectar si un num es primo o no:
        int n;
        n = int.Parse(Console.ReadLine());
        if (PrimoFor(n))
            Console.WriteLine($"El nuemero {n} SÍ es primo.");
        else
            Console.WriteLine($"El nuemero {n} NO es primo.");


        Console.ReadKey();

    }

    public static bool PrimoFor(int x)
    {
        for(int i=2; i<x; i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }

    public static bool Primo(int x)
    {
        int i = x - 1;
        while (x % i != 0 || i < 1)
        {
            i--;
        }
        if (i == 1) return true;
        else return false;
    }
}