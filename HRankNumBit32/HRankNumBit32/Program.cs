using System.Collections;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(("ResultadoNumBit32.txt"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();

        Console.ReadKey();
    }
}
class Result
{

    /*
        * Complete the 'flippingBits' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts LONG_INTEGER n as parameter.
        */

    public static long flippingBits(long n)
    {

        string binary = Convert.ToString(n, 2);
        string binary32 = binary.PadLeft(32, '0');

        Console.WriteLine(binary32);
        //Console.ReadKey();

        string binaryInv = "";
        foreach (char c in binary32)
        {
            if (c == '0') binaryInv = binaryInv + '1';
            else binaryInv = binaryInv + '0';
        }

        Console.WriteLine(binaryInv);
        //Console.ReadKey();

        //byte[] bytes = Encoding.ASCII.GetBytes(binaryInv);
        //long res = BitConverter.ToInt64(bytes);

        //Console.WriteLine(res);
        //Console.ReadKey

        long res = Convert.ToInt64(binaryInv, 2);
        Console.WriteLine("Resultado funcion : " + res);
        //Console.ReadKey();

        return res;

    }

}