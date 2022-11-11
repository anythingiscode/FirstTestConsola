

public class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio.txt");

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();    

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
public class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Avistamientos Vista = new Avistamientos();
        List<Avistamientos> ListaVista = new List<Avistamientos>();
        List<int> v = new List<int>();

        for(int i = 0; i < arr.Count; i++)
        {
            if (!v.Contains(arr[i]))
            {
                v.Add(arr[i]);
                var temp = arr.Where(x => x == arr[i]);
                Vista.NumVistas = temp.Count();
                Vista.Id = arr[i];
                ListaVistas.Add(Vista);
            }
        }
        foreach(Avistamientos vis in ListaVistas)
        {
            Console.WriteLine("Item : {0} {1}", vis.Id, vis.NumVistas);
        }
        Console.ReadKey();
        ListaVistas.Sort();
        Console.WriteLine("Ordenados\n");
        foreach (Avistamientos vis in ListaVistas)
        {
            Console.WriteLine("Item : {0} {1}", vis.Id, vis.NumVistas);
        }
        Console.ReadKey();


        return 0;
    }

}
