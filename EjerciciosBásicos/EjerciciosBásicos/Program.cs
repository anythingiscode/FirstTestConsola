internal class Program
{
    private static void Main(string[] args)
    {
        int n, a;
        int[] arr = { 2, 34, 66, 32, 99, 80, 23 };
        string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";
        /*
        //Detectar si un num es primo o no:
        Console.WriteLine("Introduce un número para comprovar si es primo : ");
        n = int.Parse(Console.ReadLine());
        if (PrimoFor(n))
            Console.WriteLine($"El nuemero {n} SÍ es primo.");
        else
            Console.WriteLine($"El nuemero {n} NO es primo.");
      
        //Multiplicar dos num sin utilizar el operador x
        Console.WriteLine("\nIntroduce dos número para calcular la multiplicación : ");
        n = int.Parse(Console.ReadLine());
        a = int.Parse(Console.ReadLine());
        Console.WriteLine($"la multiplicación de {n} por {a} es igual a : {Multiplicar(n,a)}");
      
        //Obtener el mayor num de un array recorriendola solo 1 vez
        Console.WriteLine("\n Dado el siguiente array : ");
        foreach(int aux in arr)
        {
            Console.Write($"{aux} - ");
        }
        
        Console.WriteLine("\nEl mayor número de la array es : " + Mayor2(arr));
        Console.WriteLine("\nCon linq; El mayor número de la array es : " + arr.Max());
          */
        //Contar las veces que se repite una palabras en una frase

        ContarPalabrasRepetidas(text);

        Console.ReadKey();

    }
    public static int ContarPalabrasRepetidas(string txt)
    {
        //Paso la cadena 'text' a cadena de palabras:

        string[] text = txt.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> Repeticiones = new List<string>();
        Repeticiones.Add(text[0]);
        Repeticiones.Add("1");
        //Creo la query para buscar cada palabra en el texto
        int y = 0;
        for (int i = 0; i < text.Length; i++)
        {
            Repeticiones.Add(text[i]);
            Repeticiones.Add("0");
            text.Count();


        }
        

        return text.Length;
      

        //bool Correcto = listaDeNumeros.Contains(100);    //Contains nos dice si un elemento existe o no en la lista
        //static List<int> listaDeNumeros = new List<int> { 5, 10, 20 };

    }

    public static int Mayor(int[] arr)
    {
        int mayor = arr[0];
        foreach (int num in arr)
            if (num > mayor) mayor = num;
        return mayor;
    }
    public static int Mayor2(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Count()-1];
    }

        public static bool PrimoFor(int x)
    {
        for(int i=2; i<x; i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }

    public static bool Primo(int x)
    {
        int i = x - 1;
        while (x % i != 0 || i < 1)
        {
            i--;
        }
        if (i == 1) return true;
        else return false;
    }

    public static int Multiplicar(int a, int b)
    {
        int resultado = 0;
        
        if (b.Equals(Math.Abs(b)) && a.Equals(Math.Abs(a)) || !b.Equals(Math.Abs(b)) && !a.Equals(Math.Abs(a)))
        {
            for (int i = Math.Abs(b); i > 0; i--)
            {
                resultado = resultado + Math.Abs(a);
            }
            return resultado;
        }
        else
        {
            for (int i = Math.Abs(b); i > 0; i--)
            {
                resultado = resultado - Math.Abs(a);
            }
            return resultado;
        }        
    }

    public static int Multiplicar2(int a, int b)
    {
        int resultado = 0;
        bool posB = b.Equals(Math.Abs(b));
        bool posA = a.Equals(Math.Abs(a));

        for (int i =0; i < Math.Abs(b); i++)
        {
            resultado = posA && posB || !posA && !posB ? resultado + Math.Abs(a) : resultado - Math.Abs(a);
        }
        return resultado;
    }
}