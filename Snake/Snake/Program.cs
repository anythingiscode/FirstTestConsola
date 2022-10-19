using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Snake
{
    internal class Program
    {

        // Clase para localizar los puntos de la serpiente
        class Punto     // Solo se podrá acceder desde esta clase
        {
            public Punto(int x, int y)          //Generamos el constructor de la clase Punto
            {
                this.X = x;
                this.Y = y;
            }

            public Punto()
            {
                // Lo dejo en blanco para usarlo en la generacion del puntoComida. Sino me pide pasar los parametros x, y
            }

            public int X { get; set; }
            public int Y { get; set; }
        }


        enum Direccion              //Ctrl dirección de la serpiente
        {
            Arriba,
            Abajo,
            Izquierda,
            Derecha
        }

        static bool canMove = true;             // Esta variable controlará si se mueve o no dentro de "DetectarTecla"
        static bool juega = true;               // Static porque el método es estático y las variables también, sino no puedo acceder a ellas
        static Direccion dir = Direccion.Derecha;  //Inicializo con drdcha para que cuando salga desde esquina superior izq, salga dentro de la pantalla
        //Lista serpiente que contendrá los puntos de la serpinte
        static List<Punto> serpiente = new List<Punto>();       // La declaro como lista vacia y luego la inicializo en el método "jugar"

        static Punto posicionComida = new Punto();     //Creamos la var posicionComida fuera del programa, como var global para que se pueda acceder en todo slo métodos
        static int score = 0;
        static int scoreMax = 0;
        static string scoreMaxNombre = null;


        static void Main(string[] args)
        {
            Console.Title = "SNAKE";                // Titulo para la consola

            LeerPuntuacionMax();                    // Método  para leer la puntuación Max

            Menu();
        }

        private static void LeerPuntuacionMax()
        {
            if (File.Exists("score.txt"))               //Pasamos una ruta para el fichero y esto devuelve un booleano diciendo si existe o no el fichero
            {
                string[] text = File.ReadAllLines("score.txt");         //Se tiene que declarar como un ARRAY de strings para que pille todas las lineas

                if (text.Length >= 2)                   // Antes de tratar el txt miramos que tenga algo. Como nuestra estructura tiene dos lineas, confirmamos que existan.
                {
                    scoreMax = Convert.ToInt32(text[0]);
                    scoreMaxNombre = text[1];   
                }
            }
        }

        //MENU del juego
        private static void Menu()
        {
            char tecla ='\0';               // Var tecla con asignación de caracter vacío
            while (tecla != 's' && tecla != 'S')        // Condicion de si es = "S" porque es la tecla de salir y eso pararia el juego y salimos del bucle evidentemente
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a Snake \n\n\n");
                Console.WriteLine("(J)ugar");
                Console.WriteLine("(P)untuación");
                Console.WriteLine("(S)alir\n");

                tecla = Console.ReadKey().KeyChar;

                if (tecla == 'j' || tecla == 'J')
                {
                    Console.Clear();
                    Jugar();
                }
                else if (tecla == 'p' || tecla == 'P')
                {
                    Puntuacion();
                }
            }
        }

        private static void Puntuacion()
        {
            Console.Clear();
            if (scoreMaxNombre!= null)
            {
                Console.WriteLine($"Puntuación Máxima : {scoreMax} realizada por {scoreMaxNombre}");
            }
            else
            {
                Console.WriteLine("No hay ninguna puntuación registrada");
            }
            
            Console.ReadKey();

        }

        // Ctrl de condición de Jugar
        private static void Jugar()
        {
            SpawnComida();
            juega = true;
            score = 0;

            //Inicializamos alguna de las variables por si el jugador quiere jugar otra vez
            dir = Direccion.Derecha;
            serpiente = new List<Punto>() { new Punto(Console.WindowWidth / 2, Console.WindowHeight / 2) };        // inicializo un primer punto en el centro de la consola
            
            /* Aqui vamos a poner los threads que controlan el mov para que se activen cada vez que jugasmos */

            Thread threadTeclas = new Thread(DetectarTeclas);           //Metemos en el constructor el método "DetectarTeclas" que necesita ser ejecutado de forma asyncrona    
            threadTeclas.SetApartmentState(ApartmentState.STA);         //Lo configuramos como STA  --> que es lo que pedia la excepcion lnazada pour el debug
            threadTeclas.Start();                                       //LO lanzamos a partir de aquí

            ActualizarPuntuacion();


            while (juega)            // Ctrl de ejecucion del juego
            {
                Mover();
                if(dir == Direccion.Derecha || dir == Direccion.Izquierda)      //Si la serpiente se mueve en horizontal --> delay 100ms
                    Thread.Sleep(100);         //Delay de 100 ms
                else                                                            //Si lo hace en horizontal, que se mueva mas lento para gualar las distancias recorridas en la consola
                {
                    Thread.Sleep(180);         //Delay de 180 ms
                }
            }
        }

        private static void ActualizarPuntuacion()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"SCORE : {score}");

        }

        private static void DetectarTeclas()
        {
            while (juega)               // Para que el thread se ejecute cada vez hay que hacer que el método se ejecute mientas se juega
            {
                if (canMove)
                {
                    if (dir != Direccion.Abajo && Keyboard.IsKeyDown(Key.Up))
                        dir = Direccion.Arriba;
                    else if (dir != Direccion.Arriba && Keyboard.IsKeyDown(Key.Down))
                        dir = Direccion.Abajo;
                    else if (dir != Direccion.Derecha && Keyboard.IsKeyDown(Key.Left))
                        dir = Direccion.Izquierda;
                    else if (dir != Direccion.Izquierda && Keyboard.IsKeyDown(Key.Right))
                        dir = Direccion.Derecha;
                }
            }
        }

        //Métpodo para posicionar la comida
        private static void SpawnComida()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());       //Genera un código aleatorio que no se repite


            int x, y;
            x = random.Next(5, Console.WindowWidth - 5);
            y = random.Next(5, Console.WindowHeight - 5);

            while (serpiente.Where(n => n.X == x && n.Y==y).Any())        // Esto evita crear la comida dentro de la serpiente
            {
                x = random.Next(0, Console.WindowWidth - 3);
                y = random.Next(0, Console.WindowHeight - 3);
            }

            //Manera 1 de pasar las coordenadas x, y
            //posicionComida.X = x;
            //posicionComida.Y = y;  

            posicionComida = new Punto(x, y);        //Manera abreviada de pasar las coordenadas x, y

            //Posicionamos la comida en la consola
            Console.SetCursorPosition(x,y);
            Console.Write("§");

        }

        // Creación de Mover
        private static void Mover()
        {
            Punto posAux = null;
            canMove = false;    

            for (int i = 0; i < serpiente.Count; i++)            // Como la serpiente tendra varios puntos tenemos que recorrerla con un "for"
            {
                Console.SetCursorPosition(serpiente[i].X, serpiente[i].Y);  //Posiciono el cursor en la ultima posición
                Console.Write(" ");                                         //Borro el caracter la ultima posicion imprimiendo en su lugar " "
                if (i == 0)
                {
                    //posAux = serpiente[0];        //¿Cual es la diferencia entre esta linea y la siguiente
                    posAux=new Punto(serpiente[i].X, serpiente[i].Y);   //En este caso  i=0

                    switch (dir)
                    {
                        case Direccion.Arriba:
                            serpiente[i].Y -= 1;
                            break;
                        case Direccion.Abajo:
                            serpiente[i].Y += 1;
                            break;
                        case Direccion.Izquierda:
                            serpiente[i].X -= 1;
                            break;
                        case Direccion.Derecha:
                            serpiente[i].X += 1;
                            break;
                    }
                }
                else                    //En caso de que no sea la cabeza
                {
                    var posAux2 = new Punto(posAux.X, posAux.Y);
                    posAux = new Punto(serpiente[i].X, serpiente[i].Y);
                    serpiente[i] = new Punto(posAux2.X, posAux2.Y);
                }
                Console.SetCursorPosition(serpiente[i].X, serpiente[i].Y);
                Console.Write("0");
            }
            canMove = true;
            DetectarColisiones();
        }

        private static void DetectarColisiones()
        {
            var cabezaSerpiente = serpiente.First();
            if (cabezaSerpiente.X == posicionComida.X && cabezaSerpiente.Y == posicionComida.Y)     // Condicion de SI colisión --> la cabeza está en la posición de la comida
            {
                score += 10;                    //Sumamos puntos a la puntuación y la mostramos en la consola
                ActualizarPuntuacion(); 

                if (serpiente.Count == 1)
                {
                    if (dir == Direccion.Arriba)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X, cabezaSerpiente.Y + 1));
                    }
                    else if (dir == Direccion.Abajo)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X, cabezaSerpiente.Y - 1));
                    }
                    else if (dir == Direccion.Derecha)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X - 1, cabezaSerpiente.Y));
                    }
                    else if (dir == Direccion.Izquierda)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X + 1, cabezaSerpiente.Y));
                    }
                }
                else
                {
                    var ultimo = serpiente.Last();
                    var anteuUtimo = serpiente[serpiente.Count() - 2];
                    //Abajo
                    if (ultimo.X == anteuUtimo.X && ultimo.Y + 1 == anteuUtimo.Y)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X, cabezaSerpiente.Y + 1));
                    }
                    //Arriba
                    else if (ultimo.X == anteuUtimo.X && ultimo.Y - 1 == anteuUtimo.Y)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X, cabezaSerpiente.Y + 1));
                    }
                    //Izquierda
                    else if (ultimo.X - 1 == anteuUtimo.X && ultimo.Y == anteuUtimo.Y)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X + 1, cabezaSerpiente.Y));
                    }
                    //Derecha
                    else if (ultimo.X + 1 == anteuUtimo.X && ultimo.Y == anteuUtimo.Y)
                    {
                        serpiente.Add(new Punto(cabezaSerpiente.X - 1, cabezaSerpiente.Y));
                    }
                }
                posicionComida = null;
                SpawnComida();          
            }
            // Ctrl cuando nos colisionamos con nosotros mismos
            if(serpiente.Where(n=> n.X == serpiente[0].X && n.Y == serpiente[0].Y && !n.Equals(serpiente[0])).Any())
            {
                Perder();
            }
            // Deteccion de las colisiones con el marco de la consola
            if (serpiente[0].X == 0 || serpiente[0].Y == 1 || serpiente[0].X >= Console.WindowWidth -2 || serpiente[0].Y >= Console.WindowHeight -1)
            {
                Perder();
            }
        }

        private static void Perder()
        {
            juega = false;
            Console.SetCursorPosition(10, 10);
            Console.Write("PERDISTE !!");
            Console.ReadLine();

            if (score> scoreMax)
            {
                Console.Clear();
                Console.WriteLine($" ENHORABUENA !! Nuevo Record de puntuación : {score}. El record anterior estaba en : {scoreMax} , realizado por : {scoreMaxNombre} \n\n" +
                                  $"Introduce tu nombre para registrar el nuevo record :");
                scoreMaxNombre = Console.ReadLine();
                scoreMax = score;
                GuardarPuntuacionMax();                
            }
        }

        private static void GuardarPuntuacionMax()
        {
            string texto = scoreMax + "\n" + scoreMaxNombre;
            File.WriteAllText("score.txt", texto);
        }
    }
}
