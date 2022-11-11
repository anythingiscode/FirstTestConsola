public class Avistamientos
{
   
    private int _id;
    private int _numVistas;

    public int Id { get => _id; set => _id = value; }
    public int NumVistas { get => _numVistas; set => _numVistas = value; }

    public Avistamientos(int id, int NumVistas)
    {
        _id = id;
        _numVistas = NumVistas;
    }

    public Avistamientos()
    {

    }
}