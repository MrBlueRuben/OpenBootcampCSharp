using System.Threading.Channels;

namespace Leccion03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        /*Ejercicio 1
            Crea una estructura de datos para un cliente con estos campos:
            Nombre completo
            Teléfono
            Dirección
            Email
            Si es nuevo cliente

            Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)*/
        public struct Empleado
        {
            public string nombreCompleto = "Paco Pérez García";
            public string Telefono = "+34123654489";
            public string Direccion = "C/Rue del Percebe, 13";
            public string eMail = "paquitochoc@openbootcam.com";
            public bool nuevoCliente = true;

            public Empleado()
            {
                if (nuevoCliente == true)
                {
                    Console.WriteLine($"Ud. es: {nombreCompleto} con tel: {Telefono} y dirección {Direccion}.\n Gracias por ser nuestro cliente");
                }
                else
                {
                    Console.WriteLine("Ud. no es cliente nuestro");
                }

            }

        }
       
    }
}