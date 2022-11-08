internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjerciocio.txt", true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);
        Console.ReadKey();

        textWriter.WriteLine("resultado : " + result);

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumaD1 = 0, sumaD2 = 0;
        int f = arr.Count -1;
        //Console.WriteLine( "el numero de filas es" + f);
        //Console.ReadKey();
        for (int i = 0; i < arr.Count; i++)
        {
            sumaD1 = sumaD1 + arr[i][i];
            sumaD2 = sumaD2 + arr[i][f];
            f--;
        }
        return Math.Abs(sumaD2 - sumaD1);

    }

}