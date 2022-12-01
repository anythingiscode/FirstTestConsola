// See https://aka.ms/new-console-template for more information
using System.IO;

TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    long n = Convert.ToInt64(Console.ReadLine().Trim());

    string result = Result.counterGame(n);

    textWriter.WriteLine(result);
    Console.WriteLine(result);
    Console.ReadKey();
}

textWriter.Flush();
textWriter.Close();
class Result
{

    /*
     * Complete the 'counterGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static string counterGame(long n)
    {
        int cont = 0;

        if (n == 0) return "Louise";
        else
        {
            while (n > 1)
            {          
                if ((n & (n - 1)) == 0)
                {
                    n /= 2;
                }
                else
                {
                    long potencia = 0;
                    for(int i = 0; potencia < n; i++)
                    {
                        long aux = Convert.ToInt64(Math.Pow(2, i));
                        if (aux < n) potencia = aux;
                        else break;
                    }
                    n -= potencia;

                    //n--;
                    //while (n > 1)
                    //{                   
                    //    if ((n * (n - 1)) == 0)
                    //        n = Convert.ToInt32(n);
                    //    else
                    //        n--;                    
                    //}
                    
                }                
                cont++;
            }
        }
        return (cont % 2 == 0) ? "Richard" : "Louise";
    }

}
