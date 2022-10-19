internal class Program
{
    private static void Main(string[] args)
    {

        // Fichero test creado en : C:\ROL\C#\Temp\EjemploFicheros\ExempleFichier_1.txt

        //LECTURA DE FICHERO
        //Pondremos el código dentro de un using (es como un micro codigo dentro del codigo). Lo que se ejecuta en el using no sale del using
        try
        {
            using (StreamReader reader = new StreamReader(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichier_1.txt"))
            {
                string text = string.Empty;
                while ((text = reader.ReadLine()) != null)  // Mientras no se llegue al final del texto voy añadiendo a text cada caracter que encuentre en el fichero .txt
                {
                    Console.WriteLine(text);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"No se encontró el fichero.\n\n>> Mensaje de Error del sistema : \n\n{ex}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hubo un error diferente de no encuentro fichero: {e}");
        }


        //ESCRITURA DE FICHERO

        Console.ReadKey();
    }
}