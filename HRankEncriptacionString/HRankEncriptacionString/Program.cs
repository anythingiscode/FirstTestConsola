using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjuemplo");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);
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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string upperAlphabet = alphabet.ToUpper();
        string rotationAlph = alphabet;
        string upperRotationAlph = string.Empty;
        string encryptedS = string.Empty;

        for(int i = 0; i < k % alphabet.Length; i++)    //Hay que controlar el num de rotaciones < num caracteres del vector
        {
            rotationAlph += alphabet[i];            
            rotationAlph = rotationAlph.Remove(0, 1);
        }
        upperRotationAlph = rotationAlph.ToUpper();

        for(int i = 0; i < s.Length; i++)
        {
            if (rotationAlph.Contains(s[i]))
            {
                encryptedS += rotationAlph[alphabet.IndexOf(s[i])];
            }
            else if (upperRotationAlph.Contains(s[i]))
            {
                encryptedS += upperRotationAlph[upperAlphabet.IndexOf(s[i])];
            }
            else
            {
                encryptedS += s[i];
            }
        }

        return encryptedS;
    }

}