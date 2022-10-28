using EjercicioLINQ;
using System.Collections.Generic;
using System.Net.WebSockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro[] arrayLibros = new Libro[] {
            new Libro(1, "Poeta en nueva york", "Federico Garci1a Lorca"),
            new Libro(2, "Los asesinos del emperador", "Santiago Posteguillo "),
            new Libro(3, "circo máximo", "Santiago Posteguillo "),
            new Libro(4, "La noche en que Frankenstein leyó el Quijote", "Santiago Posteguillo"),
            new Libro(5, "El origen perdido ", "Matilde Asensi")
        };

        //Es como una consulta SQl => "from" los objetos que buscamos, despues del "in" le digo donde buscar (como si fuera la tabla)
        //Opcion 1:
        var libros = from libro in arrayLibros
                     where libro.Autor == "Santiago Posteguillo"    //busco por autor
                     select libro;

        //La opcion 1 seria equivalente a esto: 
        IEnumerable<Libro> libros_2 = from libro in arrayLibros
                                    where libro.Autor == "Santiago Posteguillo"    //busco por autor
                                    select libro;
      

        IEnumerable<string> libros_3 = from libro in arrayLibros
                                      where libro.Autor == "Santiago Posteguillo"    //busco por autor
                                      select libro.Titulo;                            //Devuelvo el titulo

        //opcion 2 : Usar extension methods
        var librosExtension = arrayLibros.Where(a => a.Autor == "Santiago Posteguillo");
        //Tambien podemos dar la lista de salida ordenada alfab..
        var librosExtension2 = arrayLibros.Where(a => a.Autor == "Santiago Posteguillo").OrderBy(a => a.Titulo);

        //Las extensiones funcionan porque usan Ienumerable que es enumerable. Se puede enumerar y recorrer con GetEnumerator que devuelve el indice de la array -->
        //Para verlo,paso la array de Libro a Ienumerable:

        IEnumerable<Libro> arrayLibros3 = new Libro[] {
            new Libro(1, "Poeta en nueva york", "Federico Garci1a Lorca"),
            new Libro(2, "Los asesinos del emperador", "Santiago Posteguillo "),
            new Libro(3, "circo máximo", "Santiago Posteguillo "),
            new Libro(4, "La noche en que Frankenstein leyó el Quijote", "Santiago Posteguillo"),
            new Libro(5, "El origen perdido ", "Matilde Asensi")
        };

        IEnumerable<Libro> LibrosExtension = arrayLibros3.Where(a => a.Autor == "Santiago Posteguillo").OrderBy(a => a.Titulo);

        IEnumerable<Libro> enumerator = arrayLibros3.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current.Titulo);
        }
           



        Console.WriteLine();
        Console.ReadKey();

    }
}