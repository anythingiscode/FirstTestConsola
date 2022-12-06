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
        Console.WriteLine("\n\nel resultado :");
        foreach (var tx in result)
            Console.WriteLine(tx);
        Console.ReadKey();

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
        int filas = grid.Count;
        List<string> fullGrid = new List<string>();
        string strFull = new string('0', grid[0].Length);
        foreach (string gridItem in grid)
        {
            fullGrid.Add(strFull);
        }
        if (n % 2 == 0) return fullGrid;
        string strResult = string.Empty;
        for (int s = 3; s <= n; s+=2)
        {            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (j == grid[i].Length - 1)
                    {
                        if (grid[0][j] == '.' && grid[1][j] == '.' && grid[0][j - 1] == '.') strResult += '0';
                        else strResult += '.';
                    }
                    else if (grid[0][j] == '.' && grid[0][j + 1] == '.' && grid[1][j] == '.') strResult += '0';
                    else strResult += '.';                    
                }
                Console.WriteLine(strResult);
                grid.Add(strResult);                
                strResult = string.Empty;
            }   
            for(int i = 0; i < grid.Count; i++) grid.Remove(grid[i]);
        }
        return grid;
    }
}



