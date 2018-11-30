using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static implicit operator string(Autor a)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("AUTOR: " + a.nombre + " " + a.apellido);

            return retorno.ToString();
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
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }

    }
}
