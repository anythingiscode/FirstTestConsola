using EjAleatorio_conClass.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        ClsAleatorios a = new ClsAleatorios();        // Creo clase aleatorio => a

        Console.WriteLine("Genero 10 num entre 1 y 20");
        for(int i=0; i<10; i++)
        {
            Console.WriteLine(a.GenerarNumeroAleatorio(1, 20));
        }

        Console.WriteLine("Genero 7 num entre 1 y 15 en una array");
        int[] arr = a.GenerarNumerosAleatorios(7, 1, 15);
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Genero 10 num entre 1 y 20 en una array y que no se repitan");
        arr = a.GenerarNumerosAleatoriosNoRepetidos(10, 1, 20);
        foreach (int n in arr)
        {
            Console.WriteLine(n);
        }




        Console.WriteLine("Pulsa TECLA para finalizar --> X");
        Console.ReadKey();

    }
}