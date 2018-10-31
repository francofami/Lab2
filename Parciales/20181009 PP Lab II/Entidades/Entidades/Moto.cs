using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        public string ConsultarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("\nPatente: " + this.Patente);
            retorno.AppendLine("Cilindrada: " + this.cilindrada);
            retorno.AppendLine("Ruedas: " + this.ruedas);
            retorno.AppendFormat("Valor Hora: {0}", Moto.valorHora);

            return retorno.ToString();
        }

        public bool Equals(object obj)
        {
            bool retorno = false;

            retorno = this.GetType() == obj.GetType();

            return retorno;
        }

        public string ImprimirTicket()
        {
            StringBuilder retorno = new StringBuilder();

            int cantidadHoras = (this.ingreso - DateTime.Now).Hours * Moto.valorHora;


            retorno.AppendLine("Precio estadia: " + cantidadHoras.ToString());

            return retorno.ToString();
        }

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {          
            Moto.valorHora = valorHora;
        }


    }
}
