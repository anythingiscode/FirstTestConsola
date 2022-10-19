namespace EjPOO5_Ordenador.Clases
{
    internal class ClsOrdenador
    {
        #region VARIABLES PRIVADAS

        private int _tamañoGB;
        private int _tamañoGBMax;
        private bool _encendido;

        private const int _tamañoMax = 100;



        #endregion

        #region VARIABLES PÚBLICAS

        public int TamañoGB { get => _tamañoGB; set => _tamañoGB = value; }
        public int TamañoGBMax { get => _tamañoGBMax; set => _tamañoGBMax = value; }
        public bool Encendido { get => _encendido; set => _encendido = value; }

        public static int TamañoMax => _tamañoMax;


        #endregion

        #region CONSTRUCTOR

        public ClsOrdenador(int MaxGB)
        {
            TamañoGB = 0;
            Encendido = false;
            TamañoGBMax = MaxGB;

            if (TamañoGBMax <= 0)
            {
                TamañoGBMax = TamañoMax;
                Console.WriteLine($"Se introdujo un valor no válido. El tamaño máximo atribuido ha sido de {TamañoMax}.");
            }
            else
            {
                TamañoGBMax = MaxGB;
            }
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        public void EncendidoPC()
        {
            Encendido = true;
        }

        public void ApagadoPC()
        {
            Encendido = false;
        }

        public void AñadirDatos(int datos)
        {
            if (Encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los datos deben ser >0");
                }
                else 
                {
                    if (TamañoGB + datos > TamañoGBMax) TamañoGB = TamañoGBMax;
                    else
                    {
                        TamañoGB += datos;
                        Console.WriteLine($"Se añadieron nuevos datos. El tamaño del disco es : {TamañoGB} ");
                    }
                }               
            }
            else
            {
                Console.WriteLine("El ordenador está apagado y debe encenderse");
            }
        }

        public void EliminarDatos(int datos)
        {
            if (Encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("Los datos deben ser >0");
                }
                else
                {
                    if (TamañoGB - datos <0 ) TamañoGB = 0;
                    else
                    {
                        TamañoGB -= datos;
                        Console.WriteLine($"Se han borrado datos. El tamaño del disco es : {TamañoGB} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("El ordenador está apagado y debe encenderse");
            }

        }

        #endregion
    }
}
