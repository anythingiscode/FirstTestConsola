using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
        Console.ReadKey();
    }
}

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal pos = 0, neg = 0, z = 0;
        
        decimal Rpos, Rneg, Rz;

        foreach (int num in arr)
        {
            if (num > 0) pos++;
            else if (num < 0) neg++;
            else z++;
        }
        Rpos = pos / arr.Count;
        Rneg = neg / arr.Count;
        Rz = z / arr.Count;

        Console.WriteLine(Rpos.ToString("N6"));
        Console.WriteLine("{0:N6}", Rneg);
        Console.WriteLine("{0:N6}", Rz);
    }

}