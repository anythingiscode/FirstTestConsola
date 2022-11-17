using System.IO;
using System.Linq;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        int contador = 0;   
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";       

        List<char> symbol = new List<char>();
        List<char> passList = new List<char>();

        Console.Write("\nsymbol:\t");
        symbol = numbers.ToList<char>();
        foreach(char c in symbol)
            Console.Write(c+" ");

        Console.Write("\npasword:\t");
        passList = password.ToList<char>();
        foreach (char c in passList)            
            Console.Write(c + " ");

        bool existe = passList.Any(symbol.Contains);
        Console.WriteLine("\n");
        Console.WriteLine("exesite? " + existe);
        Console.ReadKey();

        bool existe2 = passList.Any(a => symbol.Any(b => b.Equals(a)));
        Console.WriteLine("\nexesite? " + existe2);
        Console.ReadKey();

        bool existeByWord = password.Any(numbers.Contains);
        Console.WriteLine("\nexesite by word? " + existeByWord);
        Console.ReadKey();

        bool existeByWord2 = password.Any(a=> numbers.Any(b => b.Equals(a)));
        Console.WriteLine("\nexesite by word? " + existeByWord2);
        Console.ReadKey();

        

        if (!password.Any(numbers.Contains)) contador++;
        if (!password.Any(lower_case.Contains)) contador++;
        if (!password.Any(upper_case.Contains)) contador++;
        if (!password.Any(special_characters.Contains)) contador++;

        if (password.Length + contador < 6) contador = 6 - password.Length;
       
        return contador;
    }

}