using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.gamingArray(arr);

            textWriter.WriteLine(result);

            Console.WriteLine(result + "\n");
        }
        Console.ReadKey();
        textWriter.Flush();
        textWriter.Close();
    }
}
/*
 Juego en le que hay que quitar de una array el num mayor y todos los elementos a su drcha.
El último que tira gana. Ej: [1,4,10,3,5] --> [1,4] --> [1]
*/
class Result
{

    /*
     * Complete the 'gamingArray' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string gamingArray(List<int> arr)
    {

        int nx = arr.Capacity;
        int cont = 0, i = 0;
        int max = arr.Max();
        while (nx > 1)
        {
            while (arr[i] < max) i++;
            if (i==0) return ((cont + 1) % 2 == 0) ? "ANDY" : "BOB";
            arr = arr.GetRange(0, nx - (nx - i));
            nx = arr.Count;
            max = arr.Max();
            cont++;
            i = 0;
        }

        return ((cont + 1) % 2 == 0) ? "ANDY" : "BOB";

        /* Funciona pero es demasiado lento
        int nx = arr.Capacity;
        int cont = 0;
        while (nx > 0)
        {
            arr = arr.GetRange(0, nx - (nx - arr.IndexOf(arr.Max())));
            nx = arr.Count;
            cont++;
        }
            
        return (cont % 2 == 0) ? "ANDY" : "BOB";
        */
    }

}