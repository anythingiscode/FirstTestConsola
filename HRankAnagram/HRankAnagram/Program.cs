using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            //Console.WriteLine("Introduzca un string : ");
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
            Console.WriteLine("\n Resultado : " + result);
            Console.ReadKey();

        }

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
            string s1 = string.Empty;
            int contador = 0;    
            List<char> sOrd = new List<char>();
            List<char> s1Ord = new List<char>();
            List<char> sAux = new List<char>();

        if (s.Length%2 != 0)
            {
                return -1;
            }                  
            else
            {
                s1 = s.Substring(s.Length / 2);
                s=s.Remove(s.Length / 2);
                sOrd= s.ToList();
                sOrd.Sort();
                s1Ord= s1.ToList();
                s1Ord.Sort();

            if (s.Contains(s1)) return 0;
                else
                {                    
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (!sOrd[i].Equals(s1Ord[i]))  contador++;
                    }
                    //for (int i = 0; i < s.Length; i++)
                    //{
                    //    sAux.Add(s[i]);
                    //    if (s.Contains(s1[i]) && !sAux.Contains(s[i])) contador--;
                    //}

                return contador;

                }
                
            }           
                

    }

}