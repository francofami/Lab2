using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Menor : Comensal
    {
        private eMenu _menu;

        public enum eMenu
        {
            Milanesa, Hamburguesa
        }

        public eMenu Menu
        {
            get
            {
                return this._menu;
            }

            set
            {
                this._menu = value;
            }
        }

        private Menor(string nombre, string apellido) : base(nombre, apellido)
        {
            
        }

        public Menor(string nombre, string apellido, eMenu menu) : this(nombre, apellido)
        {
            this._menu = menu;
        }

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine("Menu: " + this._menu);

            return retorno.ToString();
        }

        public static bool operator ==(Menor a, Menor b)
        {
            bool retorno = false;

            if(a.Nombre == b.Nombre && a.Apellido == b.Apellido && a.Menu == b.Menu)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Menor a, Menor b)
        {
            bool retorno = false;

            retorno = !(a == b);

            return retorno;
        }

        public string ToString(Menor a)
        {
            string retorno = "";

            retorno = a.Mostrar();

            return retorno;
        }

        public bool Equals(Menor a, Menor b)
        {
            bool retorno = false;

            retorno = (a == b);

            return retorno;
        }
    }
}
