using BibliotecaClases;

namespace Clase3Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Calos Perez S.A", 5000.00m);

            cuenta.Ingresar(15000.00m);
            cuenta.Retirar(4500.00m);

            cuenta.Ingresar(10000.00m);
            cuenta.Retirar(15000.00m);

            Console.WriteLine(cuenta.Mostrar());
        }
    }
}
