using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);     

        textWriter.Flush();
        textWriter.Close();

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int contador = 0;
        List<int> color = new List<int>();
 
        for(int i = 0; i < n - 1; i++)
        {
            if (!color.Contains(ar[i]))
            {               
                color.Add(ar[i]);                
                var arrColor = ar.Where(c => c == ar[i]);            
                contador = contador + arrColor.Count()/2;
            }
        }
        return contador;

    }

}
