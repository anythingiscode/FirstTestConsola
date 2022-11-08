using System.Collections;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);
        }

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
            //int nN = (int)Convert.ToInt64(n);
            //BitArray b = new BitArray(new int[] { nN });
            string binary = Convert.ToString(n, 2);
            string binary32 = binary.PadLeft(32, '0');
            Console.WriteLine(binary32);
            Console.ReadKey();
            string binaryInv = "";
            foreach (char c in binary32)
            {
                if (c == '0') binaryInv = binaryInv + '1';
                else binaryInv = binaryInv + '0';
            }
        
        Console.WriteLine(binaryInv);
        Console.ReadKey();
        long res = Convert.ToInt64(binaryInv);

        //byte[] bytes = Encoding.ASCII.GetBytes(binaryInv);
        //for (int i = 0; i < (bytes.Length - 8); i++)
        //{
        //    Console.WriteLine($"I[{i}] : {BitConverter.ToInt64(bytes, i)}");
        //}

        Console.WriteLine(res);
        Console.ReadKey();

        return res;
           
        }

    }