internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercciio.txt");

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);
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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     *  Contar Valles de una excursion representada por U (up) D (down)
     *  Un valle es cuando bajar por debajo de 0 y recuperas el 0
     */

    public static int countingValleys(int steps, string path)
    {
        int NumV = 0, nivel = 0, nivelAnt = 0;        

        for (int i = 0; i < steps; i++)
        {
            nivelAnt = nivel;
            if (path[i].Equals('U')) nivel++;
            else nivel--;
            if (nivelAnt == -1 && nivel == 0) NumV++;
        }

        return NumV;

    }

}