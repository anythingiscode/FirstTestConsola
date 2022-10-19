using System.Drawing;
using System.Net;

internal class Program
{

    private static readonly Random random = new Random(Guid.NewGuid().GetHashCode());     //Para generar los nuemeros aleatorios que no se repiten
    //Generación de los puntos iniciales
    private static readonly Point P1 = new Point(Console.WindowWidth / 2, 1);               //El P1 tiene que estar arriba en el centro
    private static readonly Point P2 = new Point(1, Console.WindowHeight - 1);               //El P2 tiene que estar abajo a la izquierda
    private static readonly Point P3 = new Point(Console.WindowWidth - 1, Console.WindowHeight - 1);               //El P3 tiene que estar abajo a la drcha
    private const int iterations = 10000;

    private static void Main(string[] args)
    {
        DrawSierpinskiTriangle();
        //Console.Read();
    }
    
    //GENERADOR DE NUM ALEATORIO ENTRE P1, P2, P3
    static Point GetRandomPoint()
    {
        int number = random.Next(1, 4);         //Para generar num aleatorios hay que definir el 1º num (en este caso el 1) y el ultimo como "ultimo + 1"

        if(number==1) return P1;
        else if(number==2) return P2;
        else return P3;
    }

    //CALCULO DEL PUNTO MEDIO   
    static Point HalfPoint(Point p1, Point p2)
    {
        return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
    }

    //DIBUJO UN PUNTO
    static void DrawPoint(Point point)
    {
        Console.SetCursorPosition(point.X, point.Y);
        Console.Write(".");
    }

    //Dibujamos el triangulo
    static void DrawSierpinskiTriangle()
    {
        var currentPoint = GetRandomPoint();
        DrawPoint(currentPoint);

        for(int i = 0; i < iterations; i++)
        {
            Point hp = HalfPoint(currentPoint,GetRandomPoint());
            DrawPoint(hp);
            currentPoint = hp;   
        }
    }
}