using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));
        foreach(int i in result)
        Console.Write(i + " ");
        Console.ReadKey();


        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        int dif = Math.Abs(arr[0] - arr[1]);
        int difAux = 0;
        List<int> result = new List<int>();
        arr.Sort();
        for(int i = 0; i < arr.Count - 1; i++)
        {
            difAux = Math.Abs(arr[i+1] - arr[i]);
            if (difAux == dif)
            {
                result.Add(arr[i]);
                result.Add(arr[i + 1]);
            }
            else if (difAux < dif)
            {
                result.Clear();
                result.Add(arr[i]);
                result.Add(arr[i + 1]);
                dif = difAux;
            }            
        }
        return result;
    }

}
