using Microsoft.VisualBasic.FileIO;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio");

        string s = Console.ReadLine();

        string result = Result.pangrams(s);
        Console.WriteLine(result);
        Console.ReadKey();

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {

        //string letras = "abcdefghijklmnopqrstuvwxyz"; // Como solo necesito el numero de caracteres -->
        int NumLetras = 26;

        //char[] letras = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();  //Crear una array con las letras del abecedario

        //T = Regex.Replace(T, @"\s","");     //using System.Text.RegularExpressions
        //T = T.Replace(" ", String.Empty);       //Atencion: This method could only remove the single space character " " but not other white spaces like tab (\t) or newline (\n).
        //T = String.Concat(T.Where(c => !Char.IsWhiteSpace(c)));  //using Linq
        string T = s.Replace(" ", "");

        Console.WriteLine("String sin espacios : " + T);
        T = T.ToLower();
        Console.WriteLine("String minusculas : " + T);

        //var TUnicos = T.ToArray().Distinct().ToList();
        var TUnicos = new HashSet<char>(T).ToList();         //Uso HashSet para generar una lista de valores unicos

        Console.WriteLine("Valores únicos : ");
        foreach (char c in TUnicos)
            Console.Write(c + " ");

        //Podría ordenar la cadena y compararla con un Equal pero no es necesario. Solo tengo que ver que ambas tengan la misma longitud

        //TUnicos.Sort();
        
        //Console.WriteLine("\nString orderby : ");
        //foreach (char c in TUnicos)
        //    Console.Write(c + " ");

        if (TUnicos.Count == NumLetras)              
            return "pangram";     
        else 
            return "not pangram";
    }

}