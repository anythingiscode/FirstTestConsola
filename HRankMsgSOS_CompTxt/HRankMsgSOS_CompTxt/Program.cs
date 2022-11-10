using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = "SOSSFSEOS";
        string model = "SOS";
        int contador = 0;
        for (int i = 0; i < s.Length/3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (s[i*3+j] != model[j]) contador++; 
            }
        }

        Console.WriteLine(contador);
        Console.ReadKey();
    }
}