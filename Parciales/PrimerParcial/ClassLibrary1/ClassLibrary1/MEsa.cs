using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mesa
    {
        private List<Comensal> _comensales;
        private int _numero;
        public int capacidad;

        public int cantidad
        {
            get
            {
                return this.capacidad;
            }
        }

        public List<Comensal> Comensales
        {
            get
            {
                return this._comensales;
            }
        }

        public int Numero
        {
            get
            {
                return this._numero;
            }

            set
            {
                this._numero = value;
            }
        }

        private Mesa()
        {
            this._comensales = new List<Comensal>();
        }

        public Mesa(int numero) : this()
        {
            this._numero = numero;
        }

        public static bool operator ==(Mesa a, Mesa b)
        {
            bool retorno = false;

            if(a._numero == b._numero)
            {
                retorno = true;
            }

            return false;
        }

        public static bool operator !=(Mesa a, Mesa b)
        {
            bool retorno = false;

            retorno = (a == b);

            return false;
        }

        public static Mesa operator +(Mesa a, Mayor b)
        {
            int flag = 0;

            if (a._numero > a._comensales.Count)
            {
                foreach (Mayor may in a._comensales)
                {
                    if (may == b)
                    {
                        flag = 1;
                        break;
                    }
                }
            }

            if (flag == 0)
            {
                a._comensales.Add(b);
            }

            return a;
        }

        public static Mesa operator +(Mesa a, Menor b)
        {
            int flag = 0;

            if(a._numero>a._comensales.Count)
            {
                foreach(Menor men in a._comensales)
                {
                    if(men == b)
                    {
                        flag = 1;
                        break;
                    }
                }
            }

            if(flag == 0)
            {
                a._comensales.Add(b);
            }

            return a;
        }

        public string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2} {3}", "Mesa:", this.Numero, "Comensales:", this._numero);
            return s.ToString();
        }

        public static explicit operator string(Mesa m)
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(m.ToString());
            foreach (Comensal comensal in m.Comensales)
            {
                if (comensal is Menor)
                {
                    s.AppendFormat("{0} {1}\n", comensal.Mostrar(), "Menor");
                }
                else
                {
                    s.AppendLine(((Mayor)comensal).ToString());
                }

            }
            return s.ToString();
        }
    }
}
