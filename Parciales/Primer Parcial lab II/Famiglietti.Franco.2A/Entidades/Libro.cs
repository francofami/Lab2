using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
                if(this._cantidadDePaginas==0)
                {
                    this._cantidadDePaginas = _generadorDePaginas.Next(10, 580);
                }

                return this._cantidadDePaginas;
            }
        }

        static Libro()
        {
            _generadorDePaginas = new Random();
        }

        protected Libro(float precio, string titulo, string nombre, string apellido) : this(titulo, new Autor(nombre, apellido), precio)
        {
            
        }

        protected Libro(string titulo, Autor autor, float precio) 
        {
            this._titulo = titulo;

            this._autor = autor;

            this._precio = precio;
            
        }

        private static string Mostrar(Libro l)
        {
            string retorno = "";

            retorno += "\nAutor: " + l._autor + "\nCantidad de paginas: " + l.CantidadDePaginas;
            retorno += "\nPrecio: $" + l._precio + "\nTitulo: " + l._titulo;

            return retorno;
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;

            if(a._autor == b._autor && a._titulo == b._titulo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
    }
}
