using BibliotecaClases;

namespace Clase3Ejecicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Carlos", "Gallo", "1200");
            Estudiante estudiante2 = new Estudiante("Pipi", "Ruiz Diaz", "1330");
            Estudiante estudiante3 = new Estudiante("Moncho", "Gallardo", "10");
            estudiante1.NotaPrimerParcial = 5;
            estudiante1.NotaSegundoParcial = 9;
            estudiante2.NotaPrimerParcial = 3;
            estudiante2.NotaSegundoParcial = 2;
            estudiante3.NotaPrimerParcial = 10;
            estudiante3.NotaSegundoParcial = 8;
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
            
        }
    }
}
