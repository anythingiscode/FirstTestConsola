using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {  
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'pageCount' function below.   --> GIRAR PAGINA
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
    
    public static int pageCount(int n, int p)
    {
        int gInicio, gFin;
        gInicio = p / 2;
        if(n % 2 == 0)
            gFin = (n - p + 1) / 2;        
        else
            gFin = (n - p) / 2;


        return (gInicio > gFin)? gFin: gInicio;
    }*/

    /*
    * Complete the 'pickingNumbers' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY a as parameter.
    */

    public static int pickingNumbers(List<int> a)
    {
        List<int> result = new List<int>();
        int j = 0, dif = 0, idx = 0, aux = 0;
        int i = a.Count - 1;
        while( i >= 2)
        {            
            result = CrearSubArray(a, i, j);
            while (dif <= 1 && aux < i - 1 )
            {                
                dif = Math.Abs(result[idx] - result[aux]);                
                aux ++;                
            }            
            dif = 0;
            idx = 0;
            aux = 1;
            j++;
            if (idx == i) return result.Count;
            i--;
        }
        return 2;
    }

    public static List<int> CrearSubArray(List<int> lista, int items, int inicio)
    {
        List<int> subArray = new List<int>();
        for(int i = 0; i < items; i++)
        {
            subArray.Add(lista[i]);
        }

        return subArray;    
    }

}
