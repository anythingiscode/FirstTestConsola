using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {  
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        Console.WriteLine("\n\n Resultado : " + result);
        Console.ReadKey();

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
        int dif = 0, idx = 0, aux = 1;
        int contador = 1, result = 2;

        a.Sort();
        foreach (int i in a)
            Console.Write(i + " ");

        while (dif <= 1 && idx < a.Count - 2)
        {
            while (dif <= 1 && aux <= a.Count - 1)
            {
                dif = Math.Abs(a[idx] - a[aux]);
                aux++;
                if(dif <=1) contador++;
            }
            if (result < contador) result = contador;
            idx++;
            aux = idx + 1;
            dif = 0;
            contador = 1;   
        }
    
        return result;
    }

        /* if (idx == a.Count) return result.Count;
          dif = 0;
          idx = 0;
          aux = 1;

          for (int i = a.Count - 1; i > 2; i--)
          {         
              result = CrearSubArray(a, i);
              while (dif <= 1 && idx < i - 1)
              {                    
                  while (dif <= 1 && aux <= i - 2)
                  {
                      dif = Math.Abs(result[idx] - result[aux]);
                      aux++;
                  }
                  idx++;
                  aux = idx + 1;                    
              }
              if (idx == i) return result.Count;
              dif = 0;
              idx = 0;
              aux = 1;

          }
          return 2;
      }

      public static List<int> CrearSubArray(List<int> lista, int items)
      {
          List<int> subArray = new List<int>();
          for (int i = 0; i < items; i++)
          {
              for (int j = i + 1; j < items; j++)
              {
                  for (int k = j + 1; k < items; k++)
                  {
                      subArray.Add(lista[i]);

                      Console.Write($"{subArray[subArray.Count() - 1]} ");
                  }
              }
          }

          for (int i = inicio; i < items + inicio; i++)
          {
              subArray.Add(lista[i]);

              Console.Write($"{subArray[subArray.Count()-1]} ");


          }
          Console.WriteLine();

          return subArray;    
      }*/

    }
