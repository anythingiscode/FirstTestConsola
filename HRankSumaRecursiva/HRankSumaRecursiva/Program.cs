using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        List<int> superD = new List<int>();
        List<string> aux = new List<string>();
        foreach (var c in n)
            aux.Add(Convert.ToString(c));
        for (int i = 0; i < n.Length; i++)
        {
            superD.Add(Int32.Parse(aux[i]));
        }
        
            Console.WriteLine(Int32.Parse(x));
        Console.ReadKey();
        if(n.Length == 1 && k ==1) return Convert.ToInt32(n);
        else
        {

        }
        return 0;

    }

}