using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public static implicit operator double(Manual m)
        {
            double retorno = 0;

            retorno = m._precio;

            return retorno;
        }

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio, titulo, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine((string)((Manual)this));
            retorno.AppendLine("Tipo :" + this.tipo);

            return retorno.ToString();
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;

            if((Libro)a==(Libro)b && a.tipo == b.tipo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }
    }
}
