internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {
        int suma = 0, sumaAux = 0;
        int index = (int)Math.Sqrt(matrix.Count);
        suma = matrix[0][0] + matrix[0][1] + matrix[1][0] + matrix[1][1];
        for (int i = 0; i < Math.Pow(2,index); i++)
        {
            for(int j = 0; j < index; j++)
            {
                matrix[j][index] = matrix[j][j];
            }

            sumaAux = matrix[0][0] + matrix[0][1] + matrix[1][0] + matrix[1][1];
            if (sumaAux > suma) suma = sumaAux;

        }     
            return suma;
    }

}
