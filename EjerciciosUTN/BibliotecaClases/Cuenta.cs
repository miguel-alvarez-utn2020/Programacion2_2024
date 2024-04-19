using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        public Cuenta(string titular, decimal cantidad) 
        { 
            _cantidad = cantidad;
            _titular = titular;
        }

        public decimal Cantidad { 
            get { return _cantidad;} 
            set{ _cantidad = value;}
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public string Mostrar()
        {
            return $"Titula: {_titular} Cantidad: {_cantidad}";
        }

        public void Ingresar(decimal monto)
        {
            if( monto < 0)
            {
                _cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            _cantidad -= monto;
        }
    }
}
