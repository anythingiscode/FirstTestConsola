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
            Console.WriteLine($"Hubo un error diferente a 'no encuentro fichero' :\n {e}");
        }


        /*  ESCRITURA DE FICHERO
         *  Si el fichero no existe se crea
         *  Si el fichero existe se sobreescribe, pero! se puede controlar para añadir en lugar de sobreescribir
         */

        string[] writerText = new string[] { "El texto que quiero que aparezca es:",
                                        "Barcelona",
                                        "Girona",
                                        "Lleida",
                                        "Tarragona" };
        try
        {
            using (StreamWriter writer = new StreamWriter(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichierEscritura_1.txt"))
            {       
                foreach (string linea in writerText)
                {
                    writer.WriteLine(linea);
                }
               
                writer.Close();             // CERRAR EL FICHERO SIEMPRE!!! Sino no se guarda el fichero. En este caso está dentro del using y no es necesario
                
                Console.WriteLine("\n\nFin de escritura de fichero.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hubo un error al escribir el fichero :\n {e}");
        }

        // Si no pongo el código dentro de un using --> 
        // writer.Close();

        // LECTURA Y ESCRITURA USANDO LA CLASE "FILE"
        // LECTURA

        string fileRead = File.ReadAllText(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichier_1.txt");     //Lee todo el texto
        Console.WriteLine(fileRead);
        //Lectura por lineas  --> Ojo ReadAllLines devuelve un array de strings []
        string[] fileReadByLines = File.ReadAllLines(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichier_1.txt");     //Lee todo el texto
        foreach (string line in fileReadByLines) 
            Console.WriteLine(line);

        //ESCRITURA
        string writeTextAllText = "Text a escriure pel segon cas.";

        File.WriteAllLines(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichierEscritura_2.txt", writerText);     //Lee todo el texto
        File.WriteAllText(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichierEscritura_3.txt", writeTextAllText);

        //Con la clase "File" se puede añadir texto directamente:
        //Linea a linea
        File.AppendAllLines(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichierEscritura_2.txt", writerText);
        //Todo el txt de un golpe (nota: añadí un salto de linea antes de añadir el texto)
        File.AppendAllText(@"C:\ROL\C#\Temp\EjemploFicheros\ExempleFichierEscritura_2.txt", "\n" + writeTextAllText);

        Console.ReadKey();
    }
}