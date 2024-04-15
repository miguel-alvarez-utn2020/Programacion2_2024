namespace BibliotecaClases
{
    public static class Validador
    {

        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min || valor > max)
            {
                return false;
            }
            return true;
        }

        /// <summary>Valida que sean iguales entre datoIngresado y a datoAComprobar
        /// </summary> 
        /// <param name="datoIngresado"></param>
        /// <param name="datoAComprobar"></param>
        /// <returns>True si datoIngresado es igual a datoAComprobar sino false</returns>
        public static bool ValidarRespuesta(string datoIngresado, string datoAComprobar)
        {
            bool esValido = false;
            if (datoIngresado == datoAComprobar)
            {
                esValido = true;
            }
            return esValido;
        }

    }
}
