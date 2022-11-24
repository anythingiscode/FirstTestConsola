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
        if (arr.Count == 1)
            return "YES";
        int sumTotal = arr.Sum();
        int sum = 0;

        for (int i = 1; i < arr.Count; i++)
        {
            sum += arr[i - 1];
            int remained = sumTotal - arr[i];

            if (i == 1 && (sumTotal - arr[i - 1]) == 0)
                return "YES";

            if (remained % 2 == 0 && remained / 2 == sum)
                return "YES";
        }
        return "NO";
        /*
        int nx = arr.Capacity;
        int sumIzq = 0, sumDcha = 0;
        List<int> arrIzq = new List<int>();
        List<int> arrDcha = new List<int>();        

        for (int i = 1; i < nx - 1; i++)
        {
            arrIzq = arr.GetRange(0,i);
            arrDcha = arr.GetRange(i + 1, nx - i - 1);
            sumIzq = arrIzq.Sum();
            sumDcha = arrDcha.Sum();
            if (sumIzq == sumDcha) return "YES";
        }
        return "NO";
        */
    }

}