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
        foreach(int i in arr)
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
            for (int i = 0; i < arr.Count - (d % arr.Count); i++)
            {
                result.Add(arr[i + (d % arr.Count)]);

                //result.Add(arr[arr.Count - (d%arr.Count) - i]);
            }
            for (int i = (d % arr.Count); i > 0 ; i--)
            {
                result.Add(arr[i - 1]);
            }
            return result;
        }
        
    }

}