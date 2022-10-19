internal class Program
{

    static List<int> listaDeNumeros = new List<int> { 5, 10, 20};       //1º elemento tiene índice 0

    private static void Main(string[] args)
    {
        //ARRAY
        string[] marcas = new string[5] { "Fiat", "Ford", "MG", "Audi", "BMW" };  //1º elemento tiene índice 0

        Console.WriteLine(marcas[0]);
        marcas[2] = "Citroen";

        //LIST
        Console.WriteLine(listaDeNumeros[2]);
        listaDeNumeros.Add(100);                        //Añadimos elemento a la lista

        listaDeNumeros[1] = 85;                         // Asignamos nuevo valor a un elemento de la lista

        listaDeNumeros.RemoveAt(1);                     //Elimina el elemnto de una posición concreta

        listaDeNumeros.Count();                         //Devuelve el numero de elementos de la lista

        bool Correcto =listaDeNumeros.Contains(100);    //Contains nos dice si un elemento existe o no en la lista

        listaDeNumeros.Reverse();                       //Invierte el orden de los elementos de la lista
        listaDeNumeros.Sort();                          //Ordena los elementos de una lista

        listaDeNumeros.AddRange(new List<int> { 200, 300, 400 });   //Inserta un rango de datos en una lista. En este caso lo he creado con una nueva lista de 3 elementos

        listaDeNumeros.Insert(0,999);                                // Inserta a partir de una posicion concreta. Ej: en la 1º posicion ponemos 999



    }
}