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
        }

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
        List<char> gridItem = new List<char>();
        List<char> gridItemAux = new List<char>();
        bool ordenado = true;

        Console.WriteLine("empieza aqui : \n");
        foreach (string s in grid)
        {
            Console.WriteLine(s + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < grid.Count; i++)
        {
            List<char> str = grid[i].ToList();
            str.Sort();
            gridChars.Add(str);
            //gridChars.Add(new List<char>(str));         
        }
        foreach (var c in gridChars) Console.WriteLine(c[0].ToString());
        Console.ReadKey();

        int f = 0, k = 0;
        while (ordenado &&  f < grid.Count)
        {            
            for(int j = 0; j < grid.Count; j++)
            {
                gridItem.Concat(gridChars[j]);
            }            
            gridItem.Sort();
            while (gridItem[k].Equals(gridChars[k]))
            {
                k++;
            }

            if(f - 1 != grid.Count) ordenado = false;
            f ++;
            k=0;
        }
        return ordenado ? "YES" : "NO";

            //foreach (string s in grid)
            //{
            //    Console.Write(s + " ");
            //}
            //Console.ReadKey();

            
    }

}