using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Func<int, int> square = x => x * x;
         * Func<VarSalida, VarEntrada> NombreFunc = ParametroEntrada => Resultado o Expresion ;
         Console.WriteLine(square(5)); 
         * Llamada a la función "square"
        */

        Func<int, int> square = x => x * x;        
        Console.WriteLine("El resultado de función Lambda es : " + square(5));
        Console.WriteLine("El resultado del método es : " + MetodoSquare(5));

        //Lo mismo en forma de método:

        static int MetodoSquare (int x)
        {
            return x * x;
        }

        Func<int, int, int> resta = (x, y) => x - y;
        Console.WriteLine("El resultado de función Lambda 'resta' es : " + resta(5,3));

        int[] NumsArray = { 2, 3, 4, 5, 56, 76, 96, 7 };
        //Funcion que nos haga el cuadrado de los número de una array
        var NumAlCuadrado = NumsArray.Select(x => x * x);   //'Selec' es una sentencia de Linq
        Console.WriteLine("El resultado de los cuadrados es : ");
        foreach (int num in NumAlCuadrado)
            Console.WriteLine(num);

        //Los números que sean < 10
        var MenoresQue10 = NumsArray.Where(x => x < 10 );
        var MenoresQue10_ = NumsArray.TakeWhile(x => x < 10);
        Console.WriteLine("El resultado de los números menores que 10 opción1 es : ");
        foreach (int num in MenoresQue10)
            Console.WriteLine(num);
        Console.WriteLine("El resultado de los números menores que 10 opción2 es : ");
        foreach (int num in MenoresQue10)
            Console.WriteLine(num);



        Console.ReadKey();
            
    }
}