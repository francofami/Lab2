using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Novela : Libro
    {
        public EGenero genero;

        public static implicit operator double(Novela n)
        {
            double retorno = 0;

            retorno = n._precio;

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine((string)((Libro)this));
            retorno.AppendLine("Genero: " + this.genero);

            return retorno.ToString();
        }

        public Novela(string titulo, float precio, Autor autor, EGenero genero) : base(titulo, autor, precio)
        {
            this.genero = genero;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;

            if((Libro)a == (Libro)b && a.genero == b.genero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }
    }
}
