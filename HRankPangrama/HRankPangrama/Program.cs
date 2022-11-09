﻿using Microsoft.VisualBasic.FileIO;
using System.Collections.Immutable;

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
        //char[] letras = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
        string T = s.ToLower();
        Console.WriteLine("String minusculas : " + T);
        T.ToList().Sort();
        //T.Distinct();
        Console.WriteLine("String unicos : " + T);
        s.Replace(" ",string.Empty);
        
        Console.WriteLine("String filtrado : " + T);
        char[] letras = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Console.WriteLine("\nletras: " + letras);
        Console.ReadKey();

        if (s.Length == letras.Length)              
            return "pangram";     
        else 
            return "not pangram";
    }

}