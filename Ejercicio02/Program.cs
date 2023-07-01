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
        }
    }
}