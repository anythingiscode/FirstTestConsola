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
        Console.WriteLine("\n\nEl resultado :");
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
        if (n == 1 || n == 0) return grid;
        int filas = grid.Count, col = grid[0].Length;
        int arriba = 0, abajo = 0, delante = 0, detras = 0;
        List<string> fullGrid = new List<string>();
        string strFull = new string('O', grid[0].Length);
        foreach (string gridItem in grid)
        {
            fullGrid.Add(strFull);
        }
        if (n % 2 == 0) return fullGrid;
        string strResult = string.Empty;
        n = ((n - 3) % 4) + 3;  // La clave esté en el calculo de 'n' ya que el patrón se repite entre n=3 y n=6
        for (int s = 3; s <= n; s+=2)
        {            
            for (int i = 0; i < filas; i++)
            {
                if (filas == 1)
                {
                    arriba = 0;
                    abajo = 0;
                }
                else if (i > 0 && i < filas - 1)
                {
                    arriba = 1;
                    abajo = 1;
                                       
                }else if (i == 0)
                {
                    arriba = 0;
                    abajo = 1;                   
                }
                else
                {
                    arriba = 1;
                    abajo = 0;
                }
                for (int j = 0; j < col; j++)
                {
                    if(col == 1)
                    {
                        delante = 0;
                        detras = 0;
                    }
                    else if(j > 0 && j < col - 1)
                    {
                        delante = 1;
                        detras = 1;
                    }
                    else if (j == 0)
                    {
                        delante = 1;
                        detras = 0;                        
                    }
                    else
                    {
                        delante = 0;
                        detras = 1;
                    }
                    if (grid[i][j] == '.' && grid[i + abajo][j] == '.' && grid[i - arriba][j] == '.' && grid[i][j - detras] == '.' && grid[i][j + delante] == '.') 
                        strResult += 'O';
                    else 
                        strResult += '.';                                   
                }                
                grid.Add(strResult);                
                strResult = string.Empty;
            }   
            for(int i = 0; i < grid.Count; i++) grid.Remove(grid[0]);
        }
        return grid;
    }
}



