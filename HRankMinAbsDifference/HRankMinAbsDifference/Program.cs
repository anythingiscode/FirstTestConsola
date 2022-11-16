using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.minimumAbsoluteDifference(arr);

        Console.WriteLine("\n\n Resultado : " + result);
        Console.ReadKey();


        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
       
        arr.Sort();
        int dif = Math.Abs(arr[1] - arr[0]);
        int difAux = 0;
        for(int i = 0; i < arr.Count - 1; i++)
        {
            difAux = Math.Abs(arr[i] - arr[i + 1]);
            if(difAux < dif) dif = difAux;
        }
        return dif;
    }

}