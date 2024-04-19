namespace Clase1Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - Un número perfecto - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I04-un-numero-perfecto/
            /*
                Los números perfectos son un tipo especial de números enteros positivos que son iguales a 
                la suma de sus divisores propios (excluyendo el número mismo). Es decir, un número perfecto 
                'n' cumple con la siguiente igualdad:
                
                o(n) = 2n
                donde o(n) es la suma de todos sus divisores, excluyendo 'n'
                
             */

            //int numero = 6;


            // esto calcula si la suma de sus divisores es igual al numero a evaluar.
            //if(numero > 0)
            //{
            //    int acumuladorDeDivisores = 0;
            //    for (int i = 1; i < numero; i++)
            //    {                    
            //        if(numero % i == 0)
            //        {
            //            //Console.WriteLine("Es par");
            //            acumuladorDeDivisores += i;

            //        }

            //    }
            //    Console.WriteLine($"La suma de los divisores es: {acumuladorDeDivisores}");
            //    if(acumuladorDeDivisores == numero)
            //    {
            //        Console.WriteLine("Es Numero Perfecto");
            //    }
            //}

            int numeroLimite = 20000;

            if (numeroLimite > 0)
            {
                //Empezamos buscando desde el numero 1
                for (int numero = 1; numero < numeroLimite; numero++) //Este for es para que busque numeros hasta el limite
                {
                    int acumuladorDeDivisores = 0;


                    for (int divisor = 1; divisor < numero; divisor++)//con este buscamos los divisores del numero (si es par)
                    {
                        if (numero % divisor == 0)
                        {
                            acumuladorDeDivisores += divisor;
                        }
                    }

                    if (acumuladorDeDivisores == numero)
                    {
                        Console.WriteLine($"Es numero Perfecto {numero}");

                    }
                }




            }

        }
    }
}
