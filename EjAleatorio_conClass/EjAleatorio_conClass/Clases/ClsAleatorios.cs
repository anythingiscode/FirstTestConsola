namespace EjAleatorio_conClass.Clases
{
    internal class ClsAleatorios
    {
        #region VARIABLES PRIVADAS

        private Random _random;         // No crearé el constructor, solo le hago el get, set y creo yo mismo el método publico 

        #endregion

        #region VARIABLES PÚBLICAS

        public Random Random { get => _random; set => _random = value; }

        #endregion

        #region CONSTRUCTOR

        public ClsAleatorios() => Random = new Random();

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        public int GenerarNumeroAleatorio(int min, int max)
        {
            //Ctrl de que el min no es mayor que el max
            if (min > max)
            {
                Console.WriteLine("Attención! \n\t El mínimo introducido es mayor que el máximo.\n\t Se intercambiarán automáticamente los valores");
                int aux = min;
                min = max;
                max = aux;
            }

            
            return Random.Next(min, max + 1);               //Ojo! no coge nunca el max --> por eso max + 1
            //return _random.Next(min, max);
        }

        public int[] GenerarNumerosAleatorios(int longitudArray, int min, int max)
        {
            if (longitudArray <= 0) return null;        //(no es obligatorio, pero así evito gestionar excepciones) Ctrl de longitudeArray: si hay un número <0 salgo retornando null

            int[] numeros = new int[longitudArray];

            //Ctrl de que el min no es mayor que el max --> (no es obligatorio, pero así evito gestionar excepciones)
            if (min > max)
            {
                Console.WriteLine("Attención! \n\t El mínimo introducido es mayor que el máximo.\n\t Se intercambiarán automáticamente los valores");
                int aux = min;
                min = max;
                max = aux;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = GenerarNumeroAleatorio(min, max);
            }           
            
            return numeros;
        }


        public int[] GenerarNumerosAleatoriosNoRepetidos(int longitudArray, int min, int max)
        {
            if (longitudArray <= 0 || (max - min) < longitudArray -1) return null;        //(no es obligatorio, pero así evito gestionar excepciones) Ctrl de longitudeArray: si hay un número <0 salgo retornando null

            int[] numeros = new int[longitudArray];

            //Ctrl de que el min no es mayor que el max --> (no es obligatorio, pero así evito gestionar excepciones)
            if (min > max)
            {
                Console.WriteLine("Attención! \n\t El mínimo introducido es mayor que el máximo.\n\t Se intercambiarán automáticamente los valores");
                int aux = min;
                min = max;
                max = aux;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                int aux = GenerarNumeroAleatorio(min, max);
                while (numeros.Where(n => n == aux).Any())
                {
                    aux = GenerarNumeroAleatorio(min, max);
                    Console.Write($"repetido [{i}]: {aux}\t");
                }
                numeros[i] = aux;
            }

            return numeros;
        }

        #endregion
    }
}
