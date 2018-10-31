using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public string ConsultarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Patente: " + this.Patente);
            retorno.AppendFormat("Color: {0}\n", this.color);
            retorno.AppendFormat("Valor Hora: {0}\n", Automovil.valorHora);

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

            int cantidadHoras = (this.ingreso - DateTime.Now).Hours * Automovil.valorHora;


            retorno.AppendLine("Precio estadia: " + cantidadHoras.ToString());


            return retorno.ToString();
        }
    }
}
