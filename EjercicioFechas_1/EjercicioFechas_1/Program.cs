using System.Globalization;

internal class Program
{
    /* Introducir una fecha en formato dia-mes-año y mostrarla en pantalla
     * Fecha del log: (día semana), (numeroDiaMes), de (mesConNombre) de (año)
     * cada vez que imprimamos algo por pantalla debemos escribirlo en un fichero como si fuera un log 
     */

    private static readonly string path = @"C:\ROL\C#\Temp\EjemploFicheros\LogFechas.txt";

    private static void Main(string[] args)
    {
        Console.WriteLine("Introduzca una fecha en formato yyyyMMdd");
        string fechaIntroducida = Console.ReadLine();
        var fecha = DateTime.ParseExact(fechaIntroducida, "yyyyMMdd", new CultureInfo("es-ES"));

        string texto = $"Fecha de log : {fecha.DayOfWeek}, {fecha.Day} de {fecha.ToString("MMMM")} de {fecha.Year}";
        Console.WriteLine(texto);

        //Creación del log
        EscribirLog(texto);
        

        Console.ReadKey();
    }

    public static void EscribirLog(string msg)
    {
        if (!File.Exists(path))
        {
            using StreamWriter sw = File.CreateText(path);             
            //using StreamWriter sw = new StreamWriter(path);   //Otra opcion para crear el fichero
        }
        File.AppendAllLines(path, new List<string>{msg});
        Console.WriteLine($"Se creó nuevo registro en el fichero {path}");
    }

}