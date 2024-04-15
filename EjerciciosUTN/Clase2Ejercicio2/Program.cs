using BibliotecaClases;

namespace Clase2Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool respuesta = false;
            string datoIngresado;
            int numero;
            bool esNumero;
            int acumulador = 0;
            do
            {
                Console.Write("Por favor ingrese numero: ");
                datoIngresado = Console.ReadLine();
                esNumero = int.TryParse(datoIngresado, out numero);
                if (esNumero)
                {
                    acumulador += numero;

                    Console.Write("Queres continuar? S o N: ");
                    datoIngresado = Console.ReadLine();
                    respuesta = Validador.ValidarRespuesta(datoIngresado, "S");
                }
            } while (respuesta);

            Console.WriteLine($"La Suma es: {acumulador}");
        }
    }
}
