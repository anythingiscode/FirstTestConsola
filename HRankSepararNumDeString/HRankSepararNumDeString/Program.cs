internal class Program
{
    private static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            Console.WriteLine("\nsolucion " + qItr);
            Result.separateNumbers(s);
            
            Console.ReadKey();
        }
    }
}
class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {

        long b = 0;
        string a = "", c = "";

        for (int i = 1; i <= s.Length / 2; i++)
        {
            a = "";
            c = s.Substring(0, i);
            b = long.Parse(c);

            while (a.ToString().Length < s.Length)
            {
                a += b;
                b++;
            }
            if (a.Equals(s))
            {
                Console.WriteLine("YES " + c);
                return;
            }
        }
        Console.WriteLine("NO ");
        
    }
}