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
        List<string> aux = new List<string>();
        List<int> superD = new List<int>();
        
        int sum = 0;
        string p = string.Empty;

        for(int i = 0; i < k; i++)       
            p += n;
        
        foreach (var c in p)
            aux.Add(Convert.ToString(c));

        for (int i = 0; i < p.Length; i++)
            superD.Add(Int32.Parse(aux[i]));
        
        do
        {
            sum = superD.Sum();
            if (sum > 10)
            {
                superD.Clear();
                aux.Clear();
                p = Convert.ToString(sum);
                foreach (var c in p)
                    aux.Add(Convert.ToString(c));
                for (int i = 0; i < p.Length; i++)
                    superD.Add(Int32.Parse(aux[i]));
            }            
        }
        while (sum > 10);
        return sum;
    }

}