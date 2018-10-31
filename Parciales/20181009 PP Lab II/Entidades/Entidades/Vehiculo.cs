using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }

            set
            {
                if (value.Length == 6)
                    this.patente = value;
                else
                    this.patente = "";
            }
        }

        public string ConsultarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.ToString();
        }

        public string ImprimirTicket()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.ToString());
            retorno.AppendLine("Fecha ingreso: " + this.ingreso.ToString());

            return retorno.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if(((Vehiculo)v1).Patente == ((Vehiculo)v2).patente && v1.Equals(v2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            retorno = !(v1 == v2);

            return retorno;
        }

        public string ToString()
        {
            return String.Format("Patente {0}", this.patente);
        }

        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
    }
}
