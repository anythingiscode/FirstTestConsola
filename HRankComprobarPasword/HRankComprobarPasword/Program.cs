using System.IO;
using System.Linq;

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
        symbol = numbers.ToList<char>();
                      
        if (!password.Any()) contador++;
        if (!password.Contains(lower_case)) contador++;
        if (!password.Contains(upper_case)) contador++;
        if (!password.Contains(special_characters)) contador++;
        if (password.Length + contador < 6) contador = 6 - password.Length;
       
        return contador;
    }

}