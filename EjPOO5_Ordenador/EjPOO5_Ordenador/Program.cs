using EjPOO5_Ordenador.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        ClsOrdenador pc = new ClsOrdenador(500);        // Pasamos un valor max del disco de 500GB

        pc.Encendido = true;
        pc.AñadirDatos(200);


        pc.EliminarDatos(60);

        Console.WriteLine("Presione TECLA para finalizar --> X");
        Console.ReadKey();
    }
}