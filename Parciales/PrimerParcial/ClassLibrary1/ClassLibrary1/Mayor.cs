using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   
    public class Mayor : Comensal
    {
        private eBebidas _bebida;

        public enum eBebidas
        {
            Agua, Cerveza, Vino, Gaseosa
        }

        public eBebidas Bebida
        {
            get
            {
                return this._bebida;
            }
        }

        public static explicit operator string(Mayor a)
        {
            string retorno = "";

            retorno += "Nombre: " + a.Nombre;
            retorno += "\nApellido: " + a.Apellido;
            retorno += "\nBebida: " + a._bebida;

            return retorno;
        }

        public Mayor(string nombre, string apellido, eBebidas bebida) : base(nombre, apellido)
        {
            this._bebida = bebida;
        }

        public static bool operator ==(Mayor a, Mayor b)
        {
            bool retorno = false;

            if(a.Nombre == b.Nombre && a.Apellido == b.Apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Mayor a, Mayor b)
        {
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }

        public string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append((string)this);

            return retorno.ToString();
        }

        public bool Equals(Mayor a, Mayor b)
        {
            bool retorno = false;

            retorno = (a == b);

            return retorno;
        }
    }
}
