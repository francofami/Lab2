using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoNacional : Banco
    {
        public string nombre;
        public string pais;

        public BancoNacional(string nombre, string pais) : base(nombre)
        {
            this.nombre = nombre;
            this.pais = pais;
        }

        public override string Mostrar()
        {
            return "\nPais: " + this.pais;
        }

        public override string Mostrar(Banco b)
        {
            return "Nombre: " + b.nombre;
        }
    }
}
