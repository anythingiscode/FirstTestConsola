using System.IO;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {       
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.sansaXor(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'sansaXor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int sansaXor(List<int> arr)
    {
        int result = 0;
        result = arr[0] ^ arr[1];
        string cadena = "Ejemplo";
        List<char> lstChars = cadena.ToList();
        Console.WriteLine("Chars[0] : " + Convert.ToString(lstChars));

        Console.WriteLine("Resultado : " + Convert.ToString(result));
        Console.ReadKey();
        return 0;
    }

}