using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio) : base(new BancoNacional(bp.nombre, bp.pais), bp.provincia)
        {
            this.municipio = municipio;
        }

        public override string Mostrar()
        {
            return "Municipio: " + this.municipio;
        }

        public static implicit operator string(BancoMunicipal b)
        {
            return b.ToString();
        }

        public string ToString()
        {
            return this.Mostrar();
        }
    }
}
