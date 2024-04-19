using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Person
    {
        private string _nombre;
        private string _fechaNacimiento;
        private string _dni;

        public Person(string nombre, string fechaNacimiento, string dni) 
        { 
            _dni = dni;
            _nombre = nombre;  
            _fechaNacimiento = fechaNacimiento;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private int CalcularEdad()
        {
            DateTime now = DateTime.Now;
            DateTime fechaNacimientoFormato;
            bool esFechaValida = DateTime.TryParseExact(_fechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimientoFormato);
            if(!esFechaValida)
            {
                return -1;
            }
            int anioActual = now.Year;
            int añoNacimiento = fechaNacimientoFormato.Year;


            return anioActual - añoNacimiento;
        }
        public string Mostrar()
        {
            int edadActual = CalcularEdad();
            return $"Nombre: {_nombre} - Edad: {edadActual} - Fecha de Nacimiento: {_fechaNacimiento} - DNI: {_dni}";
        }
        public string EsMayorDeEdad() 
        {
            int edad = CalcularEdad();
            if(edad > 17)
            {
                return "Es mayor de edad.";
            }
            return "Es menor.";
        }
    }
}
