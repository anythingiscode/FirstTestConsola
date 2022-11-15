using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.rotateLeft(d, arr);

        textWriter.WriteLine(String.Join(" ", result));
        Console.WriteLine();
        foreach(int i in result)
            Console.Write(i + " ");

        Console.ReadLine();

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        List<int> result = new List<int>();

        if (d%arr.Count == 0) return arr;
        else
        {
            //1º parte del array : la que contiene los items que no "salen" del vector
            for (int i = 0; i < arr.Count - (d % arr.Count); i++)
            {
                result.Add(arr[i + (d % arr.Count)]);                
            }
            //2º parte del array : la que contiene los items que Sí "salen" del vector
            for (int i = 0; i < (d % arr.Count); i++)
            {
                result.Add(arr[i]);
            }
            return result;
        }
        
    }

}