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
         
        //Contar las veces que se repite una palabras en una frase

        ContarPalabrasRepetidas(text);
         */

        CalificacionesAlumnos();


        Console.WriteLine("\n\n\nPress any key to exit.");
        Console.ReadKey();

    }


    //Mostrar en pantalla el mejor y el peor promedio de las calificaciones de los alumnos
    public static void CalificacionesAlumnos()
    {
        int NumAlumnos = 1; 
        int NumNotas = 5;
        decimal SumaNotas = 0;
        //Obtenemos las calificaciones de los alumnos
        Console.WriteLine("Introduzca el número de alumnos a registrar :");       
        NumAlumnos = Convert.ToInt32(Console.ReadLine());
        decimal[,] AlumnosYNotas = new decimal[NumAlumnos, NumNotas + 1];
        for (int i = 0; i < NumAlumnos; i++)
        {
            SumaNotas = 0;
            Console.WriteLine($"\nIntroduzca las {NumNotas} calificaciones del alumno {i+1} :");
            for (int j = 0; j < NumNotas; j++)
            {
                AlumnosYNotas[i,j] = Convert.ToDecimal(Console.ReadLine());
                SumaNotas = SumaNotas + AlumnosYNotas[i,j];
            }
            //Calculo la media y la almacemo el la última posición de la array
            AlumnosYNotas[i,NumNotas] = SumaNotas / NumNotas;
            Console.Clear();
        }
        List<decimal> Medias = new List<decimal>();
        for(int i=0; i<NumAlumnos; i++)
            {
                Medias.Add(AlumnosYNotas[i,NumNotas]);
            }

        Console.WriteLine("\n La mejor media es de : " + Convert.ToString(Medias.Max())
                        + " que corresponde al alumno " + Convert.ToString(Medias.FindIndex(a => a == Medias.Max()) + 1 ));

        Console.WriteLine("\n La peor media es de : " + Convert.ToString(Medias.Min())
                        + " que corresponde al alumno " + Convert.ToString(Medias.FindIndex(a => a == Medias.Min()) + 1 ));

    }

    //Contar las veces que se repiten las palablas en un texto.
    public static void ContarPalabrasRepetidas(string txt)
    {
        //También creo un fichero con la espuesta dada:
        string path = @"C:\ROL\C#\Temp\EjemploFicheros\RespuestaContarPalabrasRepetidas2.txt";
        StreamWriter FicheroTexto = new StreamWriter(path);
        
        try
        {
            FicheroTexto.WriteLine("El texto a tratar es : \n");
            FicheroTexto.Close();
            File.AppendAllText(path, txt);                
        }
        catch (Exception e)
        {
            FicheroTexto.Close();
            Console.WriteLine($"Hubo un error al escribir el fichero :\n {e}");
            throw;
        }

       
       
        //Paso la cadena 'text' a cadena de palabras en minusculas:     
        string[] palabras = txt.ToLower().Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
       //Creo una lista con las palabras repetidas (para no buscarlas 2 veces)
        List<string> PalabrasRepetidas = new List<string>();
       

        for (int i = 0; i < palabras.Length; i++)
        {
            if (!PalabrasRepetidas.Contains(palabras[i]))
            {
                IEnumerable<string> repes = palabras.Where(p => p == palabras[i]);
                if (repes.Count() > 1)
                {
                    PalabrasRepetidas.Add(palabras[i]);
                    Console.WriteLine("La palabra : '" + palabras[i] + "' Está repetida >> " + Convert.ToString(repes.Count()) + " veces.");
                    File.AppendAllText(path,"\n" + "La palabra : '" + palabras[i] + "' Está repetida >> " + Convert.ToString(repes.Count()) + " veces.");
                }                
            }
        }
        FicheroTexto.Close();
        Console.WriteLine("\n\nFin de escritura de fichero.");
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