using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;

            if(a.nombre == b.nombre && a.apellido == b.apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

        public static implicit operator string(Autor a)
        {
            string retorno="";

            retorno = a.nombre + " " + a.apellido;

            return retorno;
        }
           


    }
}
