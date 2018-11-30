using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas
        {
            get
            {
                int retorno = 0;

                if (this._cantidadDePaginas == 0)
                {             
                    retorno = Libro._generadorDePaginas.Next(10, 581);
                }
                else
                {
                    retorno = this._cantidadDePaginas;
                }

                return retorno;
            }
        }

        private Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, string nombre, string apellido) : this(titulo, new Autor(nombre, apellido), precio)
        {

        }

        public Libro(string titulo, Autor autor, float precio) : this()
        {
            this._autor = autor;
            this._titulo = titulo;
            this._precio = precio;
        }

        public static explicit operator string(Libro l)
        {
            string retorno = "";

            retorno = Libro.Mostrar(l);

            return retorno;
        }

        private static string Mostrar(Libro l)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine((string)((Autor)l._autor));
            retorno.AppendLine("Titulo: " + l._titulo);
            retorno.AppendLine("Cantidad de paginas: " + l.CantidadDePaginas);
            retorno.AppendLine("Precio: " + l._precio);

            return retorno.ToString();
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;

            if(a._titulo == b._titulo && a._autor == b._autor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }
    }
}
