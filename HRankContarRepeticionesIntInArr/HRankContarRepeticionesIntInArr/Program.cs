internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);
        Console.WriteLine();
        foreach(int i in result)
            Console.Write(i + " ");

        Console.ReadKey();

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     * Devolver una arr con las veces de repeticiones de cada num dentro de una arr dada de entre 100 y 1.000.000 de valores
     */

    public static List<int> countingSort(List<int> arr)
    {
        int[] reptc = new int[100];     // La matriz debe ser de 100 porque los num de la arr estan entre 0 y 100
        for(int i = 0; i < arr.Count; i++)
        {
            reptc[arr[i]] = reptc[arr[i]] + 1;
        }

        return reptc.ToList(); 


    }

}