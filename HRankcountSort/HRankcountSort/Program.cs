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
class ItemList
{
    private int _idx;
    private string _pos;
    private string _str;

    public int Idx { get => _idx; set => _idx = value; }
    public string Pos { get => _pos; set => _pos = value; }
    public string Str { get => _str; set => _str = value; }

    public ItemList(int idx, string pos, string str)
    {
        Idx = idx;
        Pos = pos;
        Str = str;
    }

    public ItemList() { }
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
        int nx = arr.Count;
        ItemList[] result = new ItemList[nx];
        //ItemList Item = new ItemList();


        for (int i = 0; i < nx / 2; i++)
        {
            arr[i][1] = "-";
        }
        for(int i = 0; i < nx; i++)
        {
            ItemList Item = new ItemList();
            Item.Idx = Convert.ToInt32(arr[i][0]);
            Item.Pos = arr[i][0];
            Item.Str = arr[i][1];
            result[i]= Item;
            //result.Add( new ItemList(Convert.ToInt32(arr[i][0]), arr[i][0], arr[i][1]));
            //result.Add(new ItemList(Item));
        }
        result.OrderBy(x => x.Idx);
       
       

        foreach(var x in result)
        {
            Console.Write(Convert.ToString(x + " "));
        }
        Console.ReadKey();

    }

}