using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        public string ConsultarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("\nPatente: " + this.Patente);
            retorno.AppendFormat("Modelo: {0}\n", this.modelo);
            retorno.AppendFormat("Valor hora: {0}", PickUp.valorHora);       

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

            int cantidadHoras = (this.ingreso - DateTime.Now).Hours * PickUp.valorHora;

            retorno.AppendLine("Precio estadia: " + cantidadHoras.ToString());

            return retorno.ToString();
        }

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }
    }
}
