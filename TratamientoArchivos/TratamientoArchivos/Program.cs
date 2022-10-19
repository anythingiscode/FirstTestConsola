namespace TratamientoArchivos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Hay que gestionar los recursos que ya no se utilizan y para ello existe el "garbage", 
              pero como en este caso no se utiliza por defecto, tenemos que utilizar la clase siguiente para gestionar estos recursos*/

            /*
             Open: Abre el fichero. Si no existe lanza un error
            Create: Mira si existe el fichero. Si existe, lo abre, borra contenido y escribe
            Append: Abre el fichero si existe y escribe a continuación 
            */
            try                     //Montamos un try catch por si el fichero no existe
            {
                using (  var fileStream = new FileStream("EjemploCsharp2.txt", FileMode.Open))   //esto nos permite hacer un "Dispose" al objeto
                {
                    // Para usar el writer
                    //using (var streamWriter = new StreamWriter(fileStream))
                    //{
                    //    streamWriter.WriteLine("Texto de ejemplo");
                    //    streamWriter.WriteLine("Texto de ejemplo 2");
                    //}

                    //Para usar Reader
                    using (var StreamReader = new StreamReader(fileStream))
                    {
                        Console.WriteLine(StreamReader.ReadToEnd());                //Lee el contenido entero
                        Console.WriteLine(StreamReader.ReadLine());                //Lee el contenido de una linea

                        //Para leer linea por linea todo lo que haya en el fichero
                        while (!StreamReader.EndOfStream)
                        {
                            Console.WriteLine(StreamReader.ReadLine());
                        }
                    }
                }
            }
            catch (FileNotFoundException)       //exception especifica para el error que tratamos
            {
                Console.WriteLine("El fichero no existe...");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error. El error es {ex.Message}");      //Para otros errores que pudiesen aparecer
                throw;
            }
            finally
            {
                //Console.ReadLine();
            }

            // Borrar un archivo

            if(File.Exists("ruta del fichero/nombreFichero.txt"))
            {
                File.Delete("EjemploCsharp2.txt");
                Console.WriteLine("El fichero fur eliminado");
            }
            else
            {
                Console.WriteLine("El archivo no existe...");
            }
            

        }
    }
}