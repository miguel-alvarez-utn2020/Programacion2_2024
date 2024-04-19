using BibliotecaClases;

namespace Clase3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Carlitos", "17/03/2020", "33288260");
            Person persona2 = new Person("Julio", "17/03/1985", "33456789");
            Person persona3 = new Person("Pipi", "17/03/1985", "33123789");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
        }
    }
}
