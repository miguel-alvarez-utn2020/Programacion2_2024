namespace Clase1Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Máximo, mínimo y promedio

            int cantidadPeticiones = 5;
            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            bool primerAsignacion = false;
            int acumuladorNumeros = 0;
            double promedio;



            for (int i = 0; i < cantidadPeticiones; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumuladorNumeros += numero;


                if (!primerAsignacion)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                    primerAsignacion = true;
                }
                else
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    };
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }

            }


            promedio = acumuladorNumeros / cantidadPeticiones;

            Console.WriteLine("Maximo: " + numeroMaximo);
            Console.WriteLine("Minimo: " + numeroMinimo);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
