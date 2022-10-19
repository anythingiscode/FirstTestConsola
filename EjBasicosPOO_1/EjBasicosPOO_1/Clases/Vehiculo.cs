namespace EjBasicosPOO_1.Clases
{
    public class Vehiculo
    {
        #region VARIABLES PRIVADAS
        //ATRIBUTOS   --> Como las variables van a ser privadas --> poner al inicio del nombre de la var : "_"
        private int _id;
        private string _marca;
        private string _modelo;
        private int _km;
        private double _precio;

        #endregion

        #region VARIABLES PÚBLICAS
        //Hacemos el get, set
        /*Se puede crear automáticamente:
            . Seleccionamos la/s variables privadas de la clase
            . Boton drcho
            . Seleccionamos sobre la bombillita la opción: Acciones rápidas y refactorizaciones / Encapsular campo : "var _x" (y usar propiedades) */

        public int Id { get => _id; set => _id = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int Km { get => _km; set => _km = value; }
        public virtual double Precio { get => _precio; set => _precio = value; }        //indicamos "Virtual" porque queremos sobreescribir en una clase hija
        #endregion

        #region CONSTRUCTOR
        //CONSTRUCTOR --> Para inicializar los atributos
        /*Se puede crear automáticamente.
          . Boton drcho          
          .Seleccionamos sobre la bombillita la opción: Acciones rápidas y refactorizaciones / Generar constructor */

        //public Vehiculo() { }          //Construyo uno vacío????

        public Vehiculo(int id, string marca, string modelo, int km, double precio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Km = km;
            Precio = precio;        
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS
        public override string ToString()           //Nos sirve para poder mostrar el valor de la variable (las públicas)
        {
            return "> Id : " + Id + "\tMarca : " + Marca + "\tModelo : " + Modelo + "\tKm : " + Km + "\tPrecio : " + Precio;
        }
        #endregion


    }
}
