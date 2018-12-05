using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Comensal
    {
        private string _apellido;
        private string _nombre;

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public Comensal(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public virtual string Mostrar()
        {
            string retorno = "";

            retorno = String.Format(this._nombre + " " + this._apellido);

            return retorno;
        }
    }
}
