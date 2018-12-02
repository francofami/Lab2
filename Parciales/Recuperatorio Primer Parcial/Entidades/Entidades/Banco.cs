using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Banco
    {
        public string nombre;

        public Banco(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract string Mostrar();
        public abstract string Mostrar(Banco b);
    }
}
