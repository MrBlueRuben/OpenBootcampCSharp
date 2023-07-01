namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
            Console.WriteLine(DateTime.Now);
        }
    }
}