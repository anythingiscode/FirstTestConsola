using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        int cont = 0, i = 0, j = 0, aux = 0;
        List<int> temp = new List<int>();
        while(i < q.Count - 1 && aux < 3)
        {
            temp = new List<int>(q.Skip(i + 1));
            temp.Sort();
            j = 0;
            aux = 0;
            while (j < temp.Count && temp[j] < q[i])
            {
                aux++;
                cont++;
                j++;
            }
            if (aux > 2)
            {
                Console.WriteLine("Too chaotic");
                break;
            }
            i++;
        }
        if (i == q.Count - 1)
            Console.WriteLine(Convert.ToString(cont));

        /*

        int cont = 0, i = 0, j = 0, aux = 0;        
        while (i < q.Count && aux < 3)
        {
            j = i + 1;
            aux = 0;
            while (j < q.Count )
            {
                if(q[j] < q[i] && aux < 3)
                {                    
                    aux++;
                    cont++;
               
                }
                else if(aux > 2)
                {
                    Console.WriteLine("Too chaotic");
                    break;
                }
                j++;               
            }            
            i++;
        }
        if (i == q.Count)
            Console.WriteLine(Convert.ToString(cont));


        Console.ReadKey();

        /* Funciona pero es demasiado lento
        int cont = 0, i = 0, aux = 0;
        while(i < q.Count - 1)
        {
            aux = q.Skip(i).Count(x => x < q[i]);
            if (aux > 0 && aux < 3)
            {         
                cont += aux;
            }
            else if (aux >= 3)
            {
                Console.WriteLine("Too chaotic");
                break;
            }
            i++;
        }
        if (i == q.Count -1)
            Console.WriteLine(Convert.ToString(cont));
        Console.ReadKey();
        */
    }

}
