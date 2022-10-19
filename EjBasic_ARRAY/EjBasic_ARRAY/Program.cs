using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //Declaración array

        int[] array = { 1, 2, 3, 4, 5, 6 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("Valores de la array :");
        foreach (int item in array)
        {
            Console.WriteLine(item);            //El argumento que pido es item y no array[x]
        }


        
        //Declaracion de array vacía de 5 posiciones
        int[] array2 = new int[5];

        
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine("Escriba un numero en la posición (" + i + ") :");
            int num = Convert.ToInt32(Console.ReadLine());      //Cargamos la array por consola --> Tenemos que convertir a int ya que lo que devuelve Console.ReadLine es un string
            array2[i] = num;
        }
        Console.WriteLine("\nMostrar datos de la array2 :");
        foreach (int item in array2) Console.WriteLine(item);    //El argumento que pido es item y no array[xxxx]

        //Ordenación de arrays con la clase Array que ya tiene métodos implementados
        Array.Sort(array2);
        //Visualizamos:
        Console.WriteLine("\nMostrar datos de la array2 ORDENADOS A-->Z :");
        foreach (int item in array2) Console.WriteLine(item);

       

        //Encontra el max y el min de una array  --> OPCION 1:

        int[] array3 = { 0, -23, 12, 45, 200, 86 };

        int max = array3[0];
        int min = array3[0];
        foreach(int num in array3)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine($"El valor máximo es: {max}");
        Console.WriteLine($"El valor mínimo es: {min}");

        //Encontra el max y el min de una array  --> OPCION 2 (CON LA FUNCION "SORT")

        Array.Sort(array3);
        Console.WriteLine($"\n\nEl valor máximo es: {array3[array3.Length - 1]}");   //Ojo, poner "lengh -1" porque el index empieza en 0.... bla bla bla
        Console.WriteLine($"El valor mínimo es: {array3[0]}");

         */



        /*              MATRICES  -->  TABLAS            */

        

        //Declaración Tabla:

        int[,] matrizNum = new int[3,3];
        string[,] matrizString = new string[3, 3];

        string[,] tablero = new string[5,5];
        int posX, posY, opcion;

        bool salir = false;

        RellenarMatriz(tablero, "X");

        //Posición inicial
        posX = 2;
        posY = 2;
        tablero[posX, posY] = "O";                    

        //RellenarMatriz(matrizNum, 9);
        //Console.WriteLine();
        //RellenarMatriz(matrizString,"K");

        //MostrarMatriz(matrizNum);
        //Console.WriteLine();

        MostrarMatriz(tablero);

        while (!salir)
        {
            Console.WriteLine("\n\n> 1. Derecha");
            Console.WriteLine("> 2. Izquierda");
            Console.WriteLine("> 3. Arriba");
            Console.WriteLine("> 4. Abajo");
            Console.WriteLine("\n> 5. SALIR");

            opcion = Convert.ToInt32(Console.ReadLine());

            int auxX = posX;            //Guardo las coordenadas de la posicion anterior al movimiento para poder regenerar el tablero si el jugador sale del tablero
            int auxY = posY;

            switch (opcion)
            {
                case 1: 
                    posY++;
                    break;
                case 2: 
                    posY--;
                    break;
                case 3:
                    posX--;
                    break;
                case 4:
                    posX++;
                    break;
                default:
                    salir = true;
                    break;
            }
            if (!salir && DentroMatriz(posX, posY, tablero))
            {
                RellenarMatriz(tablero, "X");
                tablero[posX,posY] = "O";
                MostrarMatriz(tablero);
            }
            else if (!salir)
            {
                Console.WriteLine("Este movimiento lo lleva fuera del tablero. \t Intentelo de nuevo.");
                posX=auxX;
                posY=auxY;  
                RellenarMatriz(tablero, "X");
                tablero[posX, posY] = "O";
                MostrarMatriz(tablero);
            }        
        }

    

        Console.WriteLine("\n\nPulsa una TECLA para finalizar --> X");
        Console.ReadKey();
    }


    //Relleno de una matriz con un valor dado "num"
    public static void RellenarMatriz(int[,] matriz, int num)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)        //Usar "GetLength(DIMENSION)" que devuelve la long de una dimension determinada. La dimensión se indica entre ()
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                //matriz[i, j] = (matriz.GetLength(0) * i) + (j + 1);     //ESCRIBIR EN UNA MATRIZ DE 3x3 LOS NUMEROS 1,2,3,.....8,9
                matriz[i, j] = num;

                //Console.Write($" {matriz[i, j]} ");
            }
            //Console.WriteLine();

        }

    }

    //Relleno de una matriz con un valor string dado =>"cadena"
    public static void RellenarMatriz(string[,] matriz, string cadena)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)        //Usar "GetLength(DIMENSION)" que devuelve la long de una dimension determinada. La dimensión se indica entre ()
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {               
                matriz[i, j] = cadena;

                //Console.Write($" {matriz[i, j]} ");
            }
            //Console.WriteLine();

        }

    }


    //MUESTRO de una matriz con un valor dado "num"
    public static void MostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)        //Usar "GetLength(DIMENSION)" que devuelve la long de una dimension determinada. La dimensión se indica entre ()
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                //matriz[i, j] = (matriz.GetLength(0) * i) + (j + 1);     //ESCRIBIR EN UNA MATRIZ DE 3x3 LOS NUMEROS 1,2,3,.....8,9
                //matriz[i, j] = num;

                Console.Write($" {matriz[i, j]} ");
            }
            Console.WriteLine();

        }

    }

    //MUESTRO de una matriz con un valor string dado =>"cadena"
    public static void MostrarMatriz(string[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)        //Usar "GetLength(DIMENSION)" que devuelve la long de una dimension determinada. La dimensión se indica entre ()
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                //matriz[i, j] = cadena;

                Console.Write($" {matriz[i, j]} ");
            }
            Console.WriteLine();

        }

    }

    //Funcion que nos diga si estamos dentro de la lmatriz    
    public static bool DentroMatriz(int x, int y, string[,] matriz)
    {
        return x >= 0 && x < matriz.GetLength(0) && y >= 0 && y < matriz.GetLength(1);
    }


}