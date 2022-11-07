internal class Program
{
    private static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
       

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
        Console.ReadKey();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime d = DateTime.Parse(s);
        return d.ToString("HH:mm:ss");
    }

}