using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Ambos);
            }
        }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca retorno = new Biblioteca(capacidad);

            return retorno;
        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Capacidad: " + e._capacidad);
            retorno.AppendFormat("Total por manuales: ${0:#.##}\n", e.PrecioDeManuales);
            retorno.AppendFormat("Total por novelas: ${0:#.##}\n", e.PrecioDeNovelas);
            retorno.AppendFormat("Total: ${0:#.##}\n", e.PrecioTotal);
            retorno.AppendLine("**********************************************");
            retorno.AppendLine("Lista de libros: ");
            retorno.AppendLine("**********************************************");

            foreach (Libro lib in e._libros)
            {
                retorno.AppendLine((string)((Libro)lib));
            }

            return retorno.ToString();
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;

            foreach(Libro lib in this._libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        {
                            if(lib is Manual)
                            retorno += (Manual)lib;
                        }
                        break;
                    case ELibro.Novela:
                        {
                            if(lib is Novela)
                            retorno += (Novela)lib;
                        }
                        break;
                    case ELibro.Ambos:
                        {
                            if (lib is Manual)
                                retorno += (Manual)lib;

                            if (lib is Novela)
                                retorno += (Novela)lib;
                        }
                        break;
                }
            }          

            return retorno;
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;

            foreach (Libro item in e._libros)
            {
                if (item is Novela && l is Novela)
                {
                    if (((Novela)item) == ((Novela)l))
                    {
                        retorno = true;
                        break;
                    }
                }

                else if (item is Manual && l is Manual)
                {
                    if (((Manual)item) == ((Manual)l))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            bool retorno = false;

            retorno = !(e == l);

            return retorno;
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if(e != l)
            {
                if (e._capacidad > e._libros.Count)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("No hay mas capacidad en la biblioteca!!!");
                }
            } 
            else
            {
                Console.WriteLine("El libro ya está en la biblioteca!!!");
            }

            return e;
        }

    }
}
