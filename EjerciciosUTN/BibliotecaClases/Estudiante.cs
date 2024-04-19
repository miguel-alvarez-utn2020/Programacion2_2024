using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Estudiante
    {
        private string _apellido;
        private string _nombre;
        private string _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        static Estudiante()
        {
            _random = new Random();
        }
        public Estudiante(string apellido, string nombre, string legajo)
        {
            _apellido = apellido;
            _nombre = nombre;
            _legajo = legajo;
        }

        public int NotaPrimerParcial
        {
            set { _notaPrimerParcial = value; }
        }

        public int NotaSegundoParcial
        {
            set { _notaSegundoParcial = value; }
        }

        public int RandomNum
        {
            get { return _random.Next(6, 11); }
        }

        private double CalcularPromedio()
        {
            return (_notaPrimerParcial + _notaSegundoParcial) / 2;
        }

        private int CalcularNotaFinal()
        {
           int randomNumber = -1;

            if(_notaPrimerParcial >= 4 && _notaSegundoParcial >= 4)
            {
                randomNumber = _random.Next(6, 11);
            }

            return randomNumber;
        }

        public string Mostrar()
        {
            double promedio = CalcularPromedio();
            int notaFinal = CalcularNotaFinal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {_nombre} Apellido: {_apellido} Legajo: {_legajo}");
            sb.AppendLine($"Nota Primer Parcial: {_notaPrimerParcial}");
            sb.AppendLine($"Nota Segunda Parcial: {_notaSegundoParcial}");
            sb.AppendLine($"Promedio: {promedio}");
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine($"Alumno Desaprobado.");
            }
            return sb.ToString();
        }
    }
}
