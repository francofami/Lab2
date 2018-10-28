using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                double retorno = 0;

                retorno = ObtenerPrecio(ELibro.Manual);

                return retorno;
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                double retorno = 0;

                retorno = ObtenerPrecio(ELibro.Novela);

                return retorno;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double retorno = 0;

                retorno = ObtenerPrecio(ELibro.Ambos);

                return retorno;
            }
        }

        private Biblioteca()
        {
            _libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {

            Biblioteca b = new Biblioteca(capacidad);

            return b;
        }

        public static string Mostrar(Biblioteca e)
        {
            string retorno = "";

            retorno += "\nCapacidad: " + e._capacidad.ToString();

            retorno += "\nTotal Novelas: $" + e.PrecioDeNovelas.ToString();
        
            retorno += "\nTotal Manuales: $" + e.PrecioDeManuales.ToString();

            retorno += "\nTotal Ambas: $" + e.PrecioTotal.ToString();
            
            retorno += "\n\n****************************************\nListado de Libros:\n****************************************";

            foreach (Libro lib in e._libros)
            {
                if(lib is Novela)
                {
                    retorno += ((Novela) lib).Mostrar();
                }

                if (lib is Manual)
                {
                    retorno += ((Manual) lib).Mostrar();
                }
            }

            return retorno;
        }

        protected double ObtenerPrecio(ELibro tipolibro)
        {
            double retorno = 0;
            double totalManuales = 0;
            double totalNovelas = 0;

            foreach (Libro lib in this._libros)
            {
                if (lib is Novela)
                {
                    totalNovelas += (Novela)lib;
                }
                    

                if (lib is Manual)
                {
                    totalManuales += (Manual)lib;
                }
                    
            }

            switch (tipolibro)
            {
                case ELibro.Novela:
                    retorno = totalNovelas;
                    break;
                case ELibro.Manual:
                    retorno = totalManuales;
                    break;
                case ELibro.Ambos:
                    retorno = totalManuales + totalNovelas;
                    break;
            }
            return retorno;
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;

            foreach(Libro lib in e._libros)
            {
                if(l == lib)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            int flag = 0;

            if(e._libros.Count < e._capacidad)
            {
                foreach(Libro lib in e._libros)
                {
                    if(l is Manual && lib is Manual)
                    {
                        if ((Manual)lib == (Manual)l)
                        {
                            Console.WriteLine("El libro ya esta en la biblioteca");
                            flag = 1;
                            break;
                        }
                    }

                    if (l is Novela && lib is Novela)
                    {
                        if ((Novela)lib == (Novela)l)
                        {
                            Console.WriteLine("El libro ya esta en la biblioteca");
                            flag = 1;
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay mas espacio");
                flag = 1;
            }

            if(flag == 0)
            {
                e._libros.Add(l);
            }

            return e;
        }
    }
}
