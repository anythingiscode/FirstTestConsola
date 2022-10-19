// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using Ejemplo_De_Clases.Clases;      //Al pasar la clase al nuevo directorio clases, lo llamamos con using para poder acceder 

namespace EjemploDeClases            // "namespace" Es un contenedor de clases.
{
   class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Juan","Pérez",35);

            persona2.MostrarEdad();                                             //Aquí solo visualizamos el valor del atributo 
            Console.WriteLine($"Mi nimbre es: {persona2.MostrarNombre()}");     //Aquí accedemos al valor del atributo
        }
    }
}