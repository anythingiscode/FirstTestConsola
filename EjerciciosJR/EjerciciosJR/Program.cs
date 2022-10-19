using System.Text.RegularExpressions;

// Invertir una cadena "Ejemplo"
string cadena = "Ejemplo";

List<char> lst = new List<char>(cadena);  //La paso a lista

lst.Reverse();                              //Invierto la lista

Console.WriteLine(cadena);

string cadenaInv = new string(lst.ToArray());       //Opcion 1: Utilizo el constructor --> con ToArray

string cadenaInv2 = string.Join("", lst);            //Opción 2: Utilizo el método de string .Join

string cadenaInv3 = string.Concat(lst);             //Opcion 3: Utilizo el método de string .Concat 

Console.WriteLine("\n" + cadenaInv);
Console.WriteLine("\n" + cadenaInv2);
Console.WriteLine("\n" + cadenaInv3);

//Contar las veces que se repite un caracter:

string cadena2 = "kjhsldfsleee";
int contador = 0;
char c = 'e';

List<char> lst2 = new List<char>(cadena2);
for (int i = 0; i < cadena2.Length; i++)
{
    if (lst2[i] == c)
    {
        contador++;
    }
}
Console.WriteLine("\n" + contador);

// Sabiendo que los srting tienen son una implementacion de la interface IEnumerable --> coleccion de caracteres
contador = 0;
foreach (var chr in cadena2)
{
    if (c == chr) contador++;
}
Console.WriteLine($"\nEl carater {c} aparece {contador} en la cadena");

// utilizando where

contador = cadena2.Where(chr => chr == c).Count();
Console.WriteLine($"\nEl carater {c} aparece {contador} en la cadena");

//Distancia de Hamming --> Comparar 2 cadenas y contar cuantos caracteres son !=

string cd1 = "ksdhaaalsjkdpg wñtkrge´rtkle´";
string cd2 = "sñfaaaaalkdñflmsdñ,ffmsñfdmsñfñl";

//List<char> lCd1 = new List<char>(cd1);
//List<char> lCd2 = new List<char>(cd2);

contador = 0;
int longitud;
if (cd1.Length >= cd2.Length)
    longitud = cd2.Length;
else
    longitud = cd1.Length;

for (int i = 0; i < longitud; i++)
{
    if (cd1[i] != cd2[i]) contador++;
}

Console.WriteLine($"\n Existen {contador} caracteress diferentes en la misma posición entre las dos cadenas: \n\n {cd1} \n\n {cd2}");

//Contador de palabras

string frase = "    Esta es la frase de ejemplo    ";
Console.WriteLine("\n\n La frase original es :" + frase + ".");
frase = frase.Trim();
Console.WriteLine("\n La frase TRIM es :" + frase + ".");
contador = frase.Where(chr => chr == ' ').Count() + 1;       //--> se supone que solo hay 1 espacio entre las palabras
Console.WriteLine($"\n\n En la cadena 'frase' hay {contador} palabras");

//  --> Opcion con Split : que es un método que devuelve una array desde un string indicandole cual es el caracter de separación
//using System.Text.RegularExpressions;      --> pondremos este using para poder acceder a la clase que nos permita tener los métodos que tratan cadenas que contienen el mismo caracter


string frase2 = "    Esta es la      frase de ejemplo    ";
contador = 0;

/* Con esto decimos :  remplaza en frase2, cualquier cadena de 1 o varios " " por un solo " "
 al final añadimos tambien el trim para lilmpiar inicio y fin de cadena de blancos */

Console.WriteLine("\n\n La frase original es :" + frase2 + ".");
frase2 = Regex.Replace(frase2, @"\s+"," ").Trim(); 

Console.WriteLine("\n La frase REGEX es :" + frase2 + ".");


//frase2 = frase2.Trim();     // Quitar espacios al inicio y al final de la cadena
var words = frase2.Split(' ');
contador = words.Length;
Console.WriteLine($"\n\n La cadena 'frase2' tiene {contador} palabras");


// Contar los numeros de una cadena

string frase3 = "sbgdtATSGD";
contador = 0;

string pattern = @"[a-zA-Z]";  //Pasamos el patron que buscamos. En este caso indicamos del 0 '-' hasta el 9

/* Tambien se pueden indicar otras series consecutivas de valores:
 [a-z], [A-Z] 
OJO!! Para pedir de la 'a' a la 'Z' --> [a-zA-Z] */
//hay que crear un objeto Regex para hacer la búsqueda
var rgx = new Regex(pattern);   // Pasamos los valores que buscamos 'pattern' al declarar el obj
//Usamos el método 'Matches' que busca coincidencias
contador = rgx.Matches(frase3).Count();

Console.WriteLine($"\n\n La 'frase3' tiene : {contador} números");



Console.ReadKey();
