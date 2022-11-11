public class Avistamientos
{
   
    int _id;
    int _numVistas;

    public int Id { get => _id; set => _id = value; }
    public int NumVistas { get => _numVistas; set => _numVistas = value; }

    public Avistamientos(int id, int numVistas)
    {
        int _id = id;
        int _numVistas = numVistas;
    }

    public Avistamientos()
    {

    }
}