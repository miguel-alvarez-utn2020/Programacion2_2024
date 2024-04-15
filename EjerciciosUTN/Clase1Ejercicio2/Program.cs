namespace Clase1Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Error al cubo
            double numero;
            double resultadoAlCubo;
            double resultadoCuadrado;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                resultadoAlCubo = Math.Pow(numero, 3);
                resultadoCuadrado = Math.Pow(numero, 2);

                Console.WriteLine($"Resulatdo al Cubo: {resultadoAlCubo}");
                Console.WriteLine($"Resulatdo al Cuadrado: {resultadoCuadrado}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
