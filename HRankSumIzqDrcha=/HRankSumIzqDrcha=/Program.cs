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
        /*
        if (arr.Count == 1)
            return "YES";
        int sumTotal = arr.Sum();
        int sum = 0;

        for (int i = 1; i < arr.Count; i++)
        {
            sum += arr[i - 1];
            int remained = sumTotal - arr[i];

            if (i == 1 && (sumTotal - arr[i - 1]) == 0)
            {
                Console.WriteLine(Convert.ToString(arr[i]));
                Console.WriteLine(Convert.ToString(i));
                return "YES";
            }
                

            if (remained % 2 == 0 && remained / 2 == sum)
            {
                Console.WriteLine(">> " + Convert.ToString(arr[i]));
                Console.WriteLine(">> " + Convert.ToString(i));
                return "YES";
            }
                
        }
        return "NO";
        */
       
        int nx = arr.Capacity;
        int sumIzq = 0, sumDcha = 0;     
      
        if (nx == 1)
            return "YES";

        for (int i = 1; i < nx - 1; i++)
        {          
            sumIzq = arr.GetRange(0, i).Sum();
            sumDcha = arr.GetRange(i + 1, nx - i - 1).Sum();
            if (sumIzq == sumDcha) return "YES";
        }
        return "NO";
       
    }

}