using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);

            textWriter.WriteLine(result);
            Console.WriteLine(result);
        }
        Console.ReadKey();
        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string balancedSums(List<int> arr)
    {
        
        int nx = arr.Capacity;
        int sumTotal = arr.Sum();
        int sum = 0, resto = 0;       

        for (int i = 0; i < nx; i++)
        {       
            resto = sumTotal - sum - arr[i];           
            if (sum == resto) return "YES";
            sum += arr[i];
        }
        return "NO";
       
    }

}