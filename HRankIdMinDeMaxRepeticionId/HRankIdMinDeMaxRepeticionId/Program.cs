

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
        int MaxNumVistas = 0;
        int MinId = 5;      // 5 porque solo se admiten valores 1...5
        int numrep = 0;
        List<int> v = new List<int>();
        int i = 0;
        while (v.Count() < 5 && i < arr.Count();
        {
            if (!v.Contains(arr[i]))
            {
                v.Add(arr[i]);
                var temp = arr.Where(x => x == arr[i]);
                numrep = temp.Count();
                Console.WriteLine("rep : " + numrep + " del >> " + arr[i] + "\n");
                Console.ReadKey();
                if (MaxNumVistas <= numrep)
                {
                    if(MaxNumVistas < numrep)
                    {
                        MinId = arr[i];
                        MaxNumVistas = numrep;
                    }                        
                    else if (MinId > arr[i]) MinId = arr[i];           
                }                
            }
            i++;
        }

        /*  ******* Esta solución utiliza la clase Avistamientos *******
         *  
        List<Avistamientos> Vistas = new List<Avistamientos>();
        List<int> v = new List<int>();
        //Avistamientos avis = new Avistamientos();
      
        for(int i = 0; i < arr.Count; i++)
        {
            if (!v.Contains(arr[i]))
            {
                v.Add(arr[i]);
                var temp = arr.Where(x => x == arr[i]);
                //avis.Id = arr[i];
                //avis.NumVistas = temp.Count();
                //Vistas.Add(new Avistamientos(avis.Id, avis.NumVistas));
                  
                
                Vistas.Add(new Avistamientos(arr[i], temp.Count()));
            }
        }
        foreach(Avistamientos vis in Vistas)
        {
            Console.WriteLine("Item : {0} {1}", vis.Id, vis.NumVistas);
        }
        Console.ReadKey();
        
        var MinIdMaxVistas = from Avistamientos a in Vistas
                             where a.NumVistas == MaxNumVistas          
                             select a.Id;

        Console.WriteLine("El resultado es : " + MinIdMaxVistas.Min());
        Console.ReadKey();

        var OrderVistas = Vistas.OrderBy(x => x.NumVistas);
        //var MaxVistas = Vistas.Where(x => x.NumVistas == Vistas.Max();


        Console.WriteLine("Ordenados\n");
        foreach (Avistamientos vis in OrderVistas)
        {
            Console.WriteLine("Item : {0} {1}", vis.Id, vis.NumVistas);
        }
        Console.ReadKey();
        */

        return MinId;
    }

}
