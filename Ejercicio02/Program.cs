using System.Drawing;
using System.Text.RegularExpressions;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Ejercicio 01
            Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
            usa una variable para cada dato y otra para el mensaje. 
            Ej: nombre, apellido, edad, sabe programar, etc.
            */
            Console.WriteLine("Escribe tu nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe tu Apellido:");
            string surname = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            string edad = Console.ReadLine();
            Console.WriteLine("¿Sabes programar? si/no");
            string progLang = Console.ReadLine();
            Console.WriteLine("Hola soy, "+ name +" "+surname+", tengo "+edad+" años"+" y "+progLang + " sé programar " );

            /* Ejercicio 2
               Usando los tipos de variables más adecuados, describe los objetos siguientes:
                Coche: puertas, ruedas, marca, ITV vigente.
                Mesa: peso, largo, material, color.
            */
            //Coche
            string puertas = "4";
            int ruedas = 2;
            string marca = "BYD";
            bool itvVigente = false;

            //Mesa
            float peso = 1.65f;
            float largo = 1.5f;
            string material = "wood";
            string color = "red";

            /*Ejercicio 3

            Operadores Determina los operadores para verificar las siguientes condiciones:
            Un número es mayor o igual a 18
            Un char es ‘a’
            Se cumplen dos conciones a la vez (ambas verdaderas)
            Se cumple una de dos condiciones a la vez (una true y otra false)
            */
            int numero = 5;
            Console.WriteLine(numero >= 18);
            char primera = 'a';
            Console.WriteLine(primera.ToString());
            Console.WriteLine(numero > 3 && numero < 10);
            Console.WriteLine(!(numero > 3 && numero < 10));

        }
    }
}