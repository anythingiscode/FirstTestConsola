using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);


        Console.WriteLine(result);
        Console.ReadKey();
    }
}
class Result
{

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
       List<int> item = new List<int>();
       int i=0, aux, num, contador = 0;
       while (i < a.Count)
       {
            num = a[i];
            if (!item.Contains(num))
            {
                item.Add(num);
                aux = i;
                contador = 1;
                while (aux < a.Count - 1 && contador < 2)
                {
                    aux++;
                    if (a[aux] == num) contador++;
                    
                }
                if (aux == a.Count -1 && contador == 1) return num;
                else contador = 0;                
            }
            i++;
       }
       return 0;
    }

}