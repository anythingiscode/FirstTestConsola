using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);
        Console.WriteLine(result);
        Console.ReadLine();

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     *  Nota: 
        char foo = '2';
        int bar = foo - '0';
        This works because each character is internally represented by a number. 
        The characters '0' to '9' are represented by consecutive numbers,
        so finding the difference between the characters '0' and '2' results in the number 2.
     */

    public static int superDigit(string n, int k)
    {
        long sum = 0;
   
        for (int i = 0; i < n.Length; i++)
        {
            sum += (n[i] - '0');
        }
        sum *= k;            
        
        do
        {            
            if (sum > 10)
            {                           
                n = Convert.ToString(sum);
                sum= 0;
                for (int i = 0; i < n.Length; i++)
                {                
                    sum += (n[i] - '0');
                }                
            }            
        }
        while (sum > 10);
        return Convert.ToInt32(sum);
    }

}