using BibliotecaClases;

namespace Clase2Ejerciocio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Validador de rangos
            int cantidadLimiteNumerosPedidos = 10;
            string datoStrIngresado;
            int numero;
            bool esNumeroValido;

            int numMax = 0;
            int numMIn = 0;
            int acumuladorNumeros = 0;
            bool primerAsignacion = true;
            double promedio;

            for (int i = 0; i < cantidadLimiteNumerosPedidos; i++)
            {
                Console.WriteLine("Ingrese un numero");
                datoStrIngresado = Console.ReadLine();
                numero = int.Parse(datoStrIngresado);
                esNumeroValido = Validador.Validar(numero, -100, 100);

                if (esNumeroValido)
                {
                    acumuladorNumeros += numero;


                    if (primerAsignacion || numero > numMax)
                    {
                        numMax = numero;
                    }
                    if (primerAsignacion || numero < numMIn)
                    {
                        numMIn = numero;
                    }
                    primerAsignacion = false;
                }
                else
                {
                    Console.WriteLine("Numero fuera de rango");
                    i--;
                }
            }


            promedio = acumuladorNumeros / cantidadLimiteNumerosPedidos;
            Console.WriteLine($"Valor minimo Ingresado: {numMIn}, Valor maximo: {numMax}, promedio: {promedio}");


        }
    }
}
