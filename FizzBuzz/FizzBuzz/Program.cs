public class Program
{
    private static void Main(string[] args)
    {
        Result.fizzBuzz(100);
        Console.ReadKey();
    }
}
class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        bool fizz = false;
        bool buzz = false;
        for (int i = 1; i <= n; i++)
        {
            fizz = false;
            buzz = false;

            if (i % 3 == 0)
            {
                fizz = true;
            }
            if (i % 5 == 0)
            {
                buzz = true;
            }

            if (fizz && buzz) Console.WriteLine("FizzBuzz");
            else if (fizz && !buzz) Console.WriteLine("Fizz");
            else if (!fizz && buzz) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
}