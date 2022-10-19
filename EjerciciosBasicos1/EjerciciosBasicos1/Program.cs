using System.Security.Cryptography.X509Certificates;

class Program
{
    //Creación de un método
    public static void Saludar(string nombre)
    {
        Console.WriteLine($"Desde método. Hola {nombre}");
    }

    //Creación de función
    public static int FuncionSuma( int a, int b, int c)
    {
        return a + b + c;
    }

    public static int CalcularFactorial(int nfact)
    {  

        for (int i = nfact -1 ; i>1 ; i--)
        {
            nfact *= i;
        }
        return nfact;
    }

    //Métodos que manipulan cadenas de caracteres
    public static void RecorrerFrase()
    {
        //string frase = string.Empty;
        Console.WriteLine("Rescriba una frase : ");
        string frase = Console.ReadLine();
        for (int i = 0; i < frase.Length; i++)
        {
            Console.Write($"{frase[i]} ");
        }
    }

    public static string FraseSinEspacios(string frase)
    {
        return frase.Replace(" ", string.Empty);
    }
    
    public static string FraseEnMayusculas(string frase)
    {
        return frase.ToUpper(); 
    }
    
    private static void Main(string[] args)
    {
        // Creación de variables y sumarlas
        int a = 50;
        int b = 50; 
        int c = 50;
        int resultadoFactorial = 1;

        int suma = a + b + c;

        string fraseSinEspacios = string.Empty;

        Console.WriteLine($"La suma es: {suma}");
        Console.ReadKey();

        // Leer un nombre entrado por consola y mostrar saludo en consola con el nombre
        Console.WriteLine("Introduce tu nombre :");


        string nombre = Console.ReadLine();
        Console.WriteLine($" Hola {nombre} !!");
        Console.ReadKey();

        //Llamada a método
        Saludar(nombre);
        Console.ReadKey();

        //Llamada a una función
        int resultadoFuncionSuma = FuncionSuma(a, b, c);
        Console.WriteLine($"El resultado de la función Suma es : {resultadoFuncionSuma}");      //Lo tenemos registrar en una variable
        Console.ReadKey();


        //llamada a la funcion Factorial

        int numFactorial = 0;
        //Console.WriteLine("Calculemos el factorial de un número.");
        //Console.WriteLine("\nIntroduzca el numero al que hay que calcular su factorial :");
        try
        {            
            //numFactorial = Convert.ToInt32(Console.ReadLine());
            //numFactorial = 4;
            //Console.WriteLine($"--> {numFactorial}");
            //Console.ReadKey();
            //Console.WriteLine($"\n\n--> ToInt32 : {numFactorial}");
            resultadoFactorial = CalcularFactorial(numFactorial);
            Console.WriteLine($"resultadoFactorial : {resultadoFactorial}");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e}--> El número introducido no es válido.\n\nInténtelo de nuevo !");
            Console.ReadKey();
            throw;
        }

        Console.WriteLine($"El factorial de {numFactorial} es : {resultadoFactorial}");
     

        RecorrerFrase();

        Console.WriteLine("\n\nEscriba una frase con espacion en blanco :");
        fraseSinEspacios = Console.ReadLine();
        Console.WriteLine($"La frase sin espacios es :\n\n {FraseSinEspacios(fraseSinEspacios)}");

        Console.WriteLine("\n\nEscriba una frase para pasarla en mayusculas :");
        string fraseEnMayusculas = Console.ReadLine();
        Console.WriteLine($"La frase sin espacios es :\n\n {FraseEnMayusculas(fraseEnMayusculas)}");






        Console.ReadKey();
    }
}