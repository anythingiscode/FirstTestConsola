using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");
        /*long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.sumXor(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();*/

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            textWriter.WriteLine(result);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'sumXor' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    /*public static long sumXor(long n)
    {
        if (n == 0) return 1;
        string bin = Convert.ToString(n, 2);
        int pow = bin.Count(x => x == '0');
        return Convert.ToInt64(Math.Pow(2, pow));
    }*/
    public static int palindromeIndex(string s)
    {
        for (int x = 0; x <= (s.Length - 1) / 2; x++)
        {
            if (s[x] != s[s.Length - 1 - x])
            {
                if (s[x + 1] == s[s.Length - 1 - x] && s[x + 2] == s[s.Length - 2 - x])
                {
                    return x;
                }
                if (s[x] == s[s.Length - 2 - x])
                {
                    return s.Length - x - 1;
                }
            }
        }
        return -1;

    }


}