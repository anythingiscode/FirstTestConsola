using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r = Convert.ToInt32(firstMultipleInput[0]);

        int c = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        List<string> grid = new List<string>();

        for (int i = 0; i < r; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = Result.bomberMan(n, grid);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'bomberMan' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING_ARRAY grid
     */

    public static List<string> bomberMan(int n, List<string> grid)
    {
        if (n == 1) return grid;
        List<string> result = new List<string>();
        string strFull= string.Empty;
        foreach(char c in grid[0])
        {
            strFull += '0';
        }        
        foreach (string gridItem in grid)
        {
            result.Add(strFull);
        }        
        if(n % 2 == 0) return result;          
        for(int s = 3; s < n; s++)
        {            
            for(int i = 0; i < grid.Count; i++)
            {
                
            }
        }
        return result;

        Console.WriteLine();
        Console.ReadKey();
    }

}
