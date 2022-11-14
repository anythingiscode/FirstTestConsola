internal class Program
{
    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("FicheroEjercicio");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
class Triangulo
{
    private double _a;
    private double _b;
    private double _c;   

    public double A { get => _a; set => _a = value; }
    public double B { get => _b; set => _b = value; }
    public double C { get => _c; set => _c = value; }

    public Triangulo(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Triangulo()
    {

    }

    public bool TDegenerado(double a, double b, double c)
    {
        bool TD = (a + b > c) && (b + c > a) && (c + a > b);
        return !TD;
    }
    public double LongTr(double a, double b, double c)
    {
        return a + b + c;
    }
}
class Result
{

    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */
   

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        List<Triangulo> ListaTND = new List<Triangulo>();
        List<int> resultadoTr = new List<int>();
        Triangulo Tr = new Triangulo();
        double longitudMax = 0;

        for(int i = 0; i < sticks.Count; i++)
        {
            for(int j = i + 1; j < sticks.Count; j++)
            {
                for(int k = j + 1; k < sticks.Count; k++)
                {
                    //Console.WriteLine($"--> {sticks[i]} {sticks[j]} {sticks[k]}");

                    if (!Tr.TDegenerado(sticks[i], sticks[j], sticks[k]))
                    {                    
                        if(longitudMax <= Tr.LongTr(sticks[i], sticks[j], sticks[k]))
                        {
                            longitudMax = Tr.LongTr(sticks[i], sticks[j], sticks[k]);
                            ListaTND.Add(new Triangulo(sticks[i], sticks[j], sticks[k]));
                        }  
                    }
                }
            }
        }

        //foreach(Triangulo tr in ListaTND)
        //{
        //    Console.WriteLine($"ListaTND antes de filtrar>> {tr.A} {tr.B} {tr.C}");
        //}
        //Console.ReadKey();
                

        if (longitudMax != 0)
        {
            if (ListaTND.Count() == 1)
            {
                resultadoTr.Add(Convert.ToInt32(ListaTND[0].A));
                resultadoTr.Add(Convert.ToInt32(ListaTND[0].B));
                resultadoTr.Add(Convert.ToInt32(ListaTND[0].C));
                resultadoTr.Sort();
            }
            else
            {
                IEnumerable<Triangulo> TrMaxLong = from Triangulo t in ListaTND
                                                   where t.A + t.B + t.C == longitudMax
                                                   select t;                

                Tr = TrMaxLong.ElementAt(0);
                resultadoTr.Add(Convert.ToInt32(Tr.A));                
                resultadoTr.Add(Convert.ToInt32(Tr.B));               
                resultadoTr.Add(Convert.ToInt32(Tr.C));
                resultadoTr.Sort();


                //foreach (Triangulo tr in TrMaxLong)
                //{
                //    Console.WriteLine($"\nTrMaxLong : {tr.A} {tr.B} {tr.C}");
                //}
                //Console.ReadKey();      

                foreach (int res in resultadoTr)
                {
                    Console.WriteLine($"\nResultado : {res} ");
                }
                Console.ReadKey();               
            }        
        }
        else
        {
            resultadoTr.Add(-1);         
        }

        

        foreach (int tr in resultadoTr)
        {
            Console.Write($"Resultado ==> {tr} ");
        }
        Console.ReadKey();
        
        return resultadoTr;

    }

}