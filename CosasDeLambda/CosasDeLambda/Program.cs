internal class Program
{
    private static void Main(string[] args)
    {
        //string cadena = "555555555555";
        //int resultado = 0;
        //foreach (var c in contador(cadena))
        //{
        //    Console.WriteLine(c + " ");
        //}
        
        //Console.WriteLine(resultado);
        //Console.ReadKey();

        //var resultCadena= cadena.GroupBy(p => p).Select(g => new { g.Key, Count = g.Count() }).OrderByDescending(a => a.Count).ToList();

        //List<int> result = new List<int>();

        //return brr.Select(x => brr.Count() != arr.Count());


        string cadena = "ttyyuu";

        var resultCadena = cadena.GroupBy(p => p).Select(g => new { g.Key, Count = g.Count() }).OrderByDescending(a => a.Count).ToList();

        Console.WriteLine("Resultado con lambda : ");
        foreach (var c in resultCadena)
        {
            Console.Write(c.Key);
            Console.WriteLine(c.Count);
        }
        Console.ReadKey();
        Console.ReadKey();

        var eso = from item in cadena
                  group item by item into g
                  select new
                  {
                      caracter = g.Key,
                      repeticiones = g.Count()
                  };
        
        Console.WriteLine("lo saco por foreach");

        foreach (var c in eso)
        {
            Console.Write(c.caracter + " ");
            Console.WriteLine(c.repeticiones);
        }

        Console.ReadKey();
    }
    public static List<int> contador (string s)
    {
        List<int> eso = new List<int>();
        eso.Add(s.Count(x => x.Equals(x)));
        eso.Add(s.Count());
        return eso;
    }
}
