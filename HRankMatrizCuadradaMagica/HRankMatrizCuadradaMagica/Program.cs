using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'formingMagicSquare' function below.
     * Key to success: there is only 1 mini-array from S-array that will have to be changed, the rest will stay the same
     * For 3 x 3 matrix there is only 8 possible ways to rotate numbers to get 'magic square' see below possibleSquares array
     * compate each mini array from possibleSquares array at the index to the same index from S-Array and measure the Absolute Difference between 2 numbers... basically just watch this guy video, he explains LOGIC behind it, really well:
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public static int formingMagicSquare(List<List<int>> s)
    {

        List<List<int>> magic = new List<List<int>>
            {
                new List<int> {8, 1, 6, 3, 5, 7, 4, 9, 2},
                new List<int> {6, 1, 8, 7, 5, 3, 2, 9, 4},
                new List<int> {4, 9, 2, 3, 5, 7, 8, 1, 6},
                new List<int> {2, 9, 4, 7, 5, 3, 6, 1, 8},
                new List<int> {8, 3, 4, 1, 5, 9, 6, 7, 2},
                new List<int> {4, 3, 8, 9, 5, 1, 2, 7, 6},
                new List<int> {2, 7, 6, 9, 5, 1, 4, 3, 8},
                new List<int> {6, 7, 2, 1, 5, 9, 8, 3, 4}
            };


        List<int> flatList = new List<int>();
        foreach (var oneList in s)
            foreach (int num in oneList)
                flatList.Add(num);

        int response = int.MaxValue;

        foreach (var term in magic)
        {
            int temp = getCost(term, flatList);
            if (response > temp)
                response = temp;
        }
        return response;

    }
    private static int getCost(List<int> magic, List<int> data)
    {
        int sum = 0;
        for (int i = 0; i < data.Count; i++)
            if (data[i] != magic[i])
                sum += Math.Abs(data[i] - magic[i]);
        return sum;
    }

    

}