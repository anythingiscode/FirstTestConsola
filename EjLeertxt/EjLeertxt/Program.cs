internal class Program
{
    private static void Main(string[] args)
    {
        //System.IO.StreamReader sr = new System.IO.StreamReader("ejemplo.txt");   // Llamada completa a StreamReader --> Si posemos el "using" no hace falta ponerlo cada vez que llamemos al Streamreader

        //Ctrl de error en caso de no encontrar el fichero:

        Console.WriteLine("Parte del ejercicio en la que leo el fichero : ejemplo.txt\n\n");
        try             // LECTURA DE FICHERO
        {
            StreamReader sr = new StreamReader("ejemplo.txt");
            string line;

            while ((line = sr.ReadLine()) != null)       // Mientras la linea no sea NULL
            {
                Console.WriteLine(line);
            }

            sr.Close();     //Siempre cerrar el fichero 
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"No se encontró el fichero.\n\n>> Mensaje de Error del sistema : \n\n{e}");
          
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hubo un error diferente de no encuentro fichero: {ex}");
            //ctrl  de tipo de error genérico
        }


        /*  ESCRITURA DE FICHERO
         *  Si el fichero no existe se crea
         *  Si el fichero existe se sobreescribe, pero! se puede controlar para añadir en lugar de sobreescribir
         */


        Console.WriteLine("\n\nParte del ejercicio en la que creo y escribo en el fichero : EjEscritura.txt\n\n");

        StreamWriter sw = new StreamWriter("EjEscritura.txt", true);        //Poniendo "true" se añade contenido --> es una de las 9 sobrecargas que tiene StreamWriter

        //string[] lineas = {               //OJO!! No se porque pero si pongo una cadena me escribe en el fichero un codigo inicial indicando que es una cadena (array)
        //    "Hola que tal,",
        //    "espero que estes bien.",
        //    "Yo estoy muy bien"
        //};

        string lineas = "Hola que tal,\n¿cómo te va?.\nA mi muy bien.";

        sw.WriteLine(lineas);

        //foreach(string line in lineas)
        //{
        //    sw.WriteLine(line);
        //}

        sw.Close();         // CERRAR EL FICHERO SIEMPRE!!! Sino no se guarda el fichero

        Console.WriteLine("Fichero escrito");
        Console.ReadKey();
    }
}