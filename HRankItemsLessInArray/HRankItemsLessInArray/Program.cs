using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

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


    //def missingNumbers(arr, brr):
    //return [x for x in set(brr) if brr.count(x) != arr.count(x)]

    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        List<int> result = new List<int>();


        for(int i = 0; i < brr.Count; i++)
        {
            if (!result.Contains(brr[i]))
            {
                //int eso = brr.Count(x => x.Equals(brr[i]));
                //Console.WriteLine("brr : " + eso + " " +brr[i]);
                //int eso2 = arr.Count(x => x.Equals(brr[i]));
                //Console.WriteLine("arr :" + eso2 + " " + brr[i]);
                if (brr.Count(x => x.Equals(brr[i])) != arr.Count(x => x.Equals(brr[i])))                  
                {
                    result.Add(brr[i]);
                }
            }
        }
        result.Sort();
        //IEnumerable<int> list = result.Distinct();
        return result;

        //List<int> result = new List<int>();
        //arr.Sort();
        //brr.Sort();       

        //for (int i = 0; i < arr.Count; i++)
        //{
        //    if (brr[i] != arr[i])
        //    {
        //        if (arr[i] < brr[i])
        //        {
        //            arr.Remove(arr[i]);
        //            i--;
        //        }
        //        else
        //        {
        //            result.Add(brr[i]);
        //            brr.Remove(brr[i]);
        //            i--;
        //        }
        //    }
        //}
        //return result;

    }

}