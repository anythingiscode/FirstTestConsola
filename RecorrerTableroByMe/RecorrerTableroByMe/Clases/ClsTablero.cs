using System.Security.Cryptography.X509Certificates;

namespace RecorrerTableroByMe.Clases
{
    internal class ClsTablero
    {
        #region VARIABLES PRIVADAS

        int _posInicialX, _posInicilaY;

        const int _dimXMin = 3;
        const int _dimYMin = 3;
        const int _dimXMax = 80;
        const int _dimYMax = 25;

        #endregion

        #region VARIABLES PÚBLICAS

        public static int DimXMin => _dimXMin;

        public static int DimYMin => _dimYMin;

        public static int DimXMax => _dimXMax;

        public static int DimYMax => _dimYMax;

        public int PosInicialX { get => _posInicialX; set => _posInicialX = value; }
        public int PosInicilaY { get => _posInicilaY; set => _posInicilaY = value; }


        #endregion

        #region CONSTRUCTOR

        public ClsTablero(int posInicialX, int posInicilaY)
        {
            _posInicialX = posInicialX;
            _posInicilaY = posInicilaY;
        }

        public ClsTablero()
        {

        }

        #endregion

        #region MÉTODOS PRIVADOS

        public ClsPosicion PosicionInicialTb(int x, int y)
        {
            ClsPosicion posInicial = new ClsPosicion();

            posInicial.X = (Console.WindowWidth / 2) - (x / 2);
            posInicial.Y = (Console.WindowHeight / 2) - (y / 2);

            return posInicial;
        }

        #endregion

        #region MÉTODOS PÚBLICOS

        public void RepresentarTablero(int x, int y)
        {

           ClsPosicion posOrigenTb = PosicionInicialTb(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.SetCursorPosition(posOrigenTb.X + i, posOrigenTb.Y + j);
                    Console.Write("·");
                }
            }

            //Me posiciono en el centro del tablero
            ClsPosicion posInicial = PosicionInicial();

            Console.SetCursorPosition(posInicial.X, posInicial.Y); 
            Console.Write("O");

        }

        public ClsPosicion PosicionInicial()
        {
            ClsPosicion posInicial = new ClsPosicion();

            posInicial.X = (Console.WindowWidth / 2);
            posInicial.Y = (Console.WindowHeight / 2);

            return posInicial;
        }

        #endregion

    }
}
