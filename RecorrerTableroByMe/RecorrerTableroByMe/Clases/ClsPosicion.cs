namespace RecorrerTableroByMe.Clases
{
    internal class ClsPosicion
    {
        #region VARIABLES PRIVADAS

        int _x;
        int _y;

        #endregion

        #region VARIABLES PÚBLICAS

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        #endregion

        #region CONSTRUCTOR

        public ClsPosicion(int x, int y)
        {
            X = x;
            Y = y;
        }
        public ClsPosicion()
        {
           
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        ////Opcion 1 para añadir un valor lista a el objeto
        ////List<ClsPosicion> posicionInicial = new List<ClsPosicion>() { new ClsPosicion(posInicialX, posInicialY) };

        ////Opcion 2 para añadir un valor lista a el objeto

        //List<ClsPosicion> posicionInicial2 = new List<ClsPosicion>();
        //posicionInicial2.Add(new ClsPosicion(posInicialX, posInicialY));


        #endregion

    }
}
