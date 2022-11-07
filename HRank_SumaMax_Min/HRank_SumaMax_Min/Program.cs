using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
        Console.ReadKey();

    }
}

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int sumaMax = 0, sumaMin = 0;
        arr.Sort();     //Ordenom de menor a mayor
        
        for(int i = 0; i < 4; i++)
        {
            sumaMin = sumaMin + arr[i];
            sumaMax = sumaMax + arr[arr.Count -1 - i];
        }
        //arr.Reverse();      //Invierto la cade`na para ordenar de mayor a menor

        //for (int i = 0; i < 4; i++)
        //{
        //    sumaMax = sumaMax + arr[i];
        //}

        Console.Write(sumaMin + " " + sumaMax);

    }

}