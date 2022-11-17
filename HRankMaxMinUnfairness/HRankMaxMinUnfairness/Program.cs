using System.Collections.Immutable;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.maxMin(k, arr);
        Console.WriteLine("\n Resultado : " + result + "\n");
        Console.ReadKey();

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */
    public static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> elements, int k)
    {  
        return k == 0 ? new[] { new T[0] } :
            elements.SelectMany((e, i) =>
                elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
    }
    
    public static List<int> Combinaciones(List<int> elements, int k)
    {
        return k == 0 ? new[] { new int[0] } :
            elements.SelectMany((e, i) =>
                elements.Skip(i + 1).Combinaciones(k - 1).Select(c => (new[] { e }).Concat(c)));
    }

    public static int maxMin(int k, List<int> arr)
    {
        List<int> minArr = new List<int>();
        int[] arr1;
        int resta = 0;
        //var result = Combinations(new[] { 1, 2, 3, 4, 5 }, 3);
        arr1 = arr.ToArray();
        var result = Combinations(arr, k);
        List<int> resultComb = Combinaciones(arr, k);

        for (int j= 0; j < arr.Count; j++)
        {
            arr.Chunk(k);
        }
        
        for (int i = 0; i < k; i++)
        {
            minArr.Add(arr[i]); 
        }
        resta = minArr.Max() - minArr.Min();

        return resta;
    }

}
