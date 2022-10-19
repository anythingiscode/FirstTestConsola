using RecorrerTableroByMe.Clases;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public enum Direccion              //Ctrl dirección de la posición
                {
                    Arriba,
                    Abajo,
                    Izquierda,
                    Derecha,                  
                }

    public static Direccion dir = new Direccion();
    public static int dimX, dimY;
    public static int numSalidas;

    public static char fondoTb = '·';
    public static char puntero = 'O';

    public static bool juega = false;
    public static bool pulsaTecla = false;

    public static ClsTablero t = new ClsTablero();
    public static ClsPosicion pos = new ClsPosicion();
    public static ClsPosicion posOrigTb = new ClsPosicion();

    private static void Main(string[] args)
    {
        

        Console.Title = "MOVERSE POR UN TABLERO";
        Console.Clear();


        //CREO TABLERO

        Console.WriteLine("\nIntroduzca las medidas de su tablero: \n >LONGITUD (entre 3 y 80): ");
        dimX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n >ALTURA (entre 3 y 25) : ");
        dimY = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.SetCursorPosition(20, 10);
        Console.WriteLine($"Vamos a crear su tablero de {dimX} x {dimY}");
        Console.ReadKey();
        Console.Clear();

        t.RepresentarTablero(dimX, dimY);
        
        posOrigTb = t.PosicionInicialTb(dimX, dimY);
        pos = t.PosicionInicial();
        numSalidas = 0;

        ConsoleKeyInfo tk;
        /* Aqui vamos a poner los threads que controlan el mov para que se activen cada vez que jugasmos */

            //Thread threadTeclas = new Thread(DetectarTeclas);           //Metemos en el constructor el método "DetectarTeclas" que necesita ser ejecutado de forma asyncrona    
            //threadTeclas.Start();                                       //Lo lanzamos a partir de aquí


        juega = true;
        int kk = -1;
        while (juega)
        {
            kk++;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Numero de movimientos : {kk}");

            //Console.SetCursorPosition(1, 0);
            Console.WriteLine($"Salidas de tablero : {numSalidas}");

            //Console.SetCursorPosition(2, 0);
            Console.WriteLine($"Le quedan : {5 - numSalidas} vidas");

            DetectarTeclas();
            if (pulsaTecla)
            {
                Mover();
            }
           
        }
        //threadTeclas.Abort();


        Console.SetCursorPosition(10, Console.WindowHeight - 1);
        Console.WriteLine("Para cerrar la apli pulsa una TECLA --> X");
        Console.ReadKey();

    }

    private static void DetectarTeclas()
    {
        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey(true);
        Console.SetCursorPosition(30, 0);
        Console.Write("Tecla pulsada :                 ");
        Console.SetCursorPosition(30, 0);
        Console.Write($"Tecla pulsada : {tecla.Key}");

        //tecla = Console.ReadKey(intercept:true);   --> hay que investigar esto

        if (ConsoleKey.UpArrow.Equals(tecla.Key))
        {
            dir = Direccion.Arriba;
            pulsaTecla = true;
        }  
        else if (ConsoleKey.DownArrow.Equals(tecla.Key))
        {
            dir = Direccion.Abajo;
            pulsaTecla = true;
        }                
        else if (ConsoleKey.LeftArrow.Equals(tecla.Key))
        {
            dir = Direccion.Izquierda;
            pulsaTecla = true;
        }               
        else if (ConsoleKey.RightArrow.Equals(tecla.Key))
        {
            dir = Direccion.Derecha;
            pulsaTecla=true;
        }
        else
        {
            pulsaTecla = false; 
        }        
    }

    private static void Mover()
    {
        ClsPosicion auxPos =new ClsPosicion();
        auxPos.X = pos.X;                           //Guardo posición actual
        auxPos.Y = pos.Y;   

        switch (dir)
        {
            case Direccion.Arriba:
                pos.Y -= 1;                
                break;
            case Direccion.Abajo:
                pos.Y += 1;               
                break;
            case Direccion.Izquierda:
                pos.X -= 1;                
                break;
            case Direccion.Derecha:
                pos.X += 1;
                
                break;

        }

        //Defino si la nueva posición está dentro o fuera del tablero
        if (pos.X<posOrigTb.X || pos.X > posOrigTb.X + dimX - 1 || pos.Y<posOrigTb.Y || pos.Y > posOrigTb.Y + dimY -1)
        {
            //Si FUERA
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(30, Console.WindowHeight - 2);
                Console.Write($"Al ir hacia {dir} ¡TE SALES DEL TABLERO! PRUEBA DE NUEVO.");
                Thread.Sleep(200 * (i+1));
                Console.SetCursorPosition(30, Console.WindowHeight - 2);
                Console.Write("                                                                 ");
                Thread.Sleep(200);

                pos = auxPos;
            }

            numSalidas++;
            if (numSalidas == 5)
            {
                Console.Clear();
                Console.SetCursorPosition(30, Console.WindowHeight / 2);
                Console.Write($"PERDISTE !  Te has salido del tablero {numSalidas} veces.");
                juega = false;
            }
        }
        else
        {
            Console.SetCursorPosition(30, Console.WindowHeight - 1);
            Console.WriteLine("");
            //Si DENTRO:
            switch (dir)
            {
                case Direccion.Arriba:
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(puntero);
                    Console.SetCursorPosition(pos.X, pos.Y + 1);
                    Console.Write(fondoTb);
                    break;
                case Direccion.Abajo:
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(puntero);
                    Console.SetCursorPosition(pos.X, pos.Y - 1);
                    Console.Write(fondoTb);
                    break;
                case Direccion.Izquierda:
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(puntero);
                    Console.SetCursorPosition(pos.X + 1, pos.Y);
                    Console.Write(fondoTb);
                    break;
                case Direccion.Derecha:
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(puntero);
                    Console.SetCursorPosition(pos.X - 1, pos.Y);
                    Console.Write(fondoTb);
                    break;
            }        
        }       
    }
}