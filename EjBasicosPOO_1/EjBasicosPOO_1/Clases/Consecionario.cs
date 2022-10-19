namespace EjBasicosPOO_1.Clases
{
    public class Consecionario
    {
        #region VARIABLES PRIVADAS

        private Vehiculo[] _coches;        //Declaración de una array de objetos -->*Ojo con el constructor
        private int _capacidad;
        private int _numCoches;         //Contador de coches

        #endregion

        #region VARIABLES PÚBLICAS

        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public int NumCoches { get => _numCoches; set => _numCoches = value; }

        #endregion

        #region CONSTRUCTOR

        //public Consecionario() { }        //Declaro uno vacío??????

        public Consecionario(int capacidad, int numCoches)
        {
            _coches = new Vehiculo[capacidad];        //* Tenemos que definir la array pasando en este caso la "capacidad" del concesionario que limitará el num de elementos de la array
            _capacidad = capacidad;
            _numCoches = numCoches;
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        public void AñadirCoche(Vehiculo c)
        {
            Console.WriteLine("Se va a añadir un coche");
            if(c != null && NumCoches <= _coches.Length)
            {
                _coches[NumCoches] = c;
                NumCoches++;
            }
        }

        public void MostrarCoches()
        {
            if (NumCoches == 0)
            {
                Console.WriteLine($"El concesionario está vacío. La capacidad del concesionario es de : {Capacidad}.");
            }
            else
            {
                //foreach (var c in this._coches) Console.WriteLine(c);         // No uso foreach porque solo quiero mostrar los registros con coches
                for (int i = 0; i < NumCoches; i++)
                {
                    Console.WriteLine(_coches[i].ToString());          // Usamos el método que creamos en la class Vehiculo oeverride ToString()
                }
                Console.WriteLine($"\nLa cantidad de coches disponibles es : {NumCoches}, de una capacidad de : {Capacidad}.");
            }          
        }

        public void VaciarCoches()
        {
            _coches = new Vehiculo[Capacidad];     //Poner todo a zero o vacío, equivale a crear de nuevo la misma array de objetos (usando el mismo nombre : "_coches")
            NumCoches = 0;  
        }


        public int BuscarCoche(Vehiculo c)        //Buscamos si existe un coche y en que posicion está dentro de la array de obj
        {
            bool encontrado = false;
            int i = -1;                 //Inicializo en -1 que es una posicion que no existe en la array para detectar el caso en que : if (c!= null && NumCoches != 0) --> Si obj coche no esta vacio y no tenemos algún coche

            if (c!= null && NumCoches > 0)      // Si obj coche no esta vacio y no tenemos algún coche
            {
                i++;
                while (i <= NumCoches -1 && !encontrado)
                {
                    //if (c.Id == _coches[i].Id)                  // Busco solo por el id
                    if (c.Equals(_coches[i])) encontrado = true;        //Busco comparando todo el objeto
                    else i++;
                }
            }
            return i;
        }

        public void QuitarCoche(Vehiculo c)            //Ojo con no dejar null dentro de la array al eliminar un coche --> Sería como si el concesionario tuviese noCoches
        {
            
            int posicion = BuscarCoche(c);

            if (posicion == -1)
            {
                Console.WriteLine("Attención : ERROR ! imposible quitar el coche :\n\n\tEl concesionario ya está vacío o el coche no está bien parametrado");
            }
            else if (posicion > _coches.Length)        //Caso en el que se llega al final de la array y no encontramos el coche
            {
                Console.WriteLine("El coche no existe");
            }
            else
            {
                _coches[posicion] = null;       //Borro la posición en la que encontré el coche
                                                
                for (int i = posicion; i < NumCoches; i++)      //Para no dejar vacios desplazo el resto de coches una posición menos
                {
                    _coches[i] = _coches[i + 1];
                }
                //Modifico la longitud de la array en -1
                NumCoches--;
            }   
        }

        #endregion

    }
}
