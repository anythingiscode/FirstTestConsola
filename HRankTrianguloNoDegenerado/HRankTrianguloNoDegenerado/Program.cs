internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */
    public static bool TDegenerado(int a, int b, int c)
    {
        bool TD = (a + b > c) && (b + c > a) && (c + a > b);
        return TD;
    }

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        

    }

}