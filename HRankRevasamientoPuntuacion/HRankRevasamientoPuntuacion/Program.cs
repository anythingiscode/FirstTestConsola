internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("ejemploScore.txt");       //Ojo el fichero se encuentra en el directoio de la solucion : C:\Users\ROL\source\repos\anythingiscode\FirstTestConsola\HRankRevasamientoPuntuacion\HRankRevasamientoPuntuacion\bin\Debug\net6.0\ejemploScore.txt 

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);
        //Para poder visulalizar sin tener que abrir el fichero
        foreach(int i in result) Console.WriteLine(Convert.ToString(result));


        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();

        Console.ReadKey();
    }
}
class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int countMax = 0, countMin = 0;
        int maxpoints = scores[0], minpoints = scores[0];
        
        foreach(int puntuacion in scores)
        {
            if (puntuacion > maxpoints)
            {
                maxpoints = puntuacion;
                countMax++;
            }
            if (puntuacion < minpoints)
            {
                minpoints = puntuacion;
                countMin++;
            }
        }
        List<int> resultado = new List<int>{ countMax, countMin };

        return resultado;


    }

}