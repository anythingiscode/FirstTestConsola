using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_De_Clases.Clases
{
    class Persona
    {
        // Atributos
        string nombre;
        string apellido;
        int edad;

        //Constructor
        public Persona()
        {

        }

        public Persona(string n, string a, int e)       //n-->nombre, a-->apellido, e-->edad
        {
            nombre = n;
            apellido = a;
            edad = e;

        }

        public void MostrarEdad()
        {
            Console.WriteLine($"Mi edad es: {edad}");
        }

        //Para poder acceder a los atributos de nombre, apellido, edad lo hacemos con un método público que podremos llamar fuera de la clase
        public string MostrarNombre()
        {
            return nombre;
        }
    }
}
