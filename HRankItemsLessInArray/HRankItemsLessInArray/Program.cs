using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        List<int> result = Result.missingNumbers(arr, brr);

        textWriter.WriteLine(String.Join(" ", result));

        Console.WriteLine();
        foreach(int i in result)
        Console.Write(i + " ");
        Console.ReadKey();


        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'missingNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY arr
     *  2. INTEGER_ARRAY brr
     *  Decir que falta en arr que sí está en brr, incluido los repetidos que tienen que tener la misma frecuencia en ambas, sino se considera que falta
     */

    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        string cadena = "sdflhsldfkjnñsdfkjnñslfn";

        var resultCadena = cadena.GroupBy(p => p).Select(g => new { g.Key, Count = g.Count() }).OrderByDescending(a => a.Count).ToList();
        
        Console.WriteLine("REsultado con lambda : ");
        foreach (var c in resultCadena)
        {
            Console.WriteLine(c.Key);
            Console.WriteLine(c.Count);
        }

        List<int> result = new List<int>();

        //return brr.Select(x => brr.Count() != arr.Count());

       
        
        
        //foreach(var c in resultCadena)
        //{
        //    Console.WriteLine(c.caracter);
        //    Console.WriteLine(c.repeticiones);
        //}

        Console.ReadKey();






        return brr;

        //        List<int> result = new List<int>();
        //        arr.Sort();
        //        brr.Sort();

        //Dictionary<int, int> map = new Dictionary<int, int>();
        //        map.ContainsKey(brr[12]);

        //        for(int i= 0; i < arr.Count; i++)
        //        {
        //            if (brr[i] != arr[i])
        //            {
        //                if(arr[i] < brr[i])
        //                {
        //                    arr.Remove(arr[i]);
        //                    i--;
        //                }
        //                else
        //                {
        //                    result.Add(brr[i]);
        //                    brr.Remove(brr[i]);
        //                    i--;
        //                }                
        //            }    
        //        }
        //        return result;

    }

}