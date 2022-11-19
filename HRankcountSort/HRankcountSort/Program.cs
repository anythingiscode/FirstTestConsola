using System.Reflection.Metadata;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}
class Result
{

    /*
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        //for (int i = 0; i < arr.Count / 2; i++)
        //    arr[i][1] = "-";

        //List<List<string>> result = new List<List<string>>();
        //for (int i = 0; i < arr.Count; i++)
        //    result.Add(new List<string>());

        //for (int i = 0; i < arr.Count; i++)
        //    result[int.Parse(arr[i][0])].Add(arr[i][1]);

        //List<string> response = new List<string>();
        //for (int i = 0; i < result.Count; i++)
        //    if (result[i].Count > 0)
        //        response.Add(string.Join(" ", result[i]));


        //Console.WriteLine(response.Aggregate((a, b)
        //    => a + " " + b));


        for (int i = 0; i < arr.Count / 2; i++)
        {
            arr[i][1] = "-";
        }
       
       

        foreach(List<string> item in arr)
        {
            Console.Write(Convert.ToString(item[1] + " "));
        }
        Console.ReadKey();

    }

}