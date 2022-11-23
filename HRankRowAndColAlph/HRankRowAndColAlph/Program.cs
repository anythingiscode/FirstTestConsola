using System.Dynamic;
using System.IO;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        List<List<char>> gridChars = new List<List<char>>();       
        List<char> ItemCol = new();
        List<char> ItemColAux = new();
        bool ordenado = true;
        int nx = grid[0].Length;    

        for (int i = 0; i < grid.Count; i++)
        {
            List<char> str = grid[i].ToList();
            str.Sort();
            gridChars.Add(str);             
        }
        
        int col = 0, idx = 0;
        while (ordenado &&  col < nx)
        {            
            for(int fil = 0; fil < grid.Count; fil++)
            {
                ItemCol.Add(gridChars[fil][col]);
                ItemColAux.Add(gridChars[fil][col]);
            }     
            ItemCol.Sort();            
            while (idx < nx && ItemCol[idx].Equals(ItemColAux[idx]))
            {
                idx++;               
            }

            if(idx != nx) ordenado = false;
            col ++;
            idx=0;
            ItemCol.Clear();
            ItemColAux.Clear();
        }
        return ordenado ? "YES" : "NO";        
            
    }

}