using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Espacio disponible: {0}", e.espacioDisponible.ToString());
            retorno.AppendFormat("Nombre: {0}", e.nombre);
            retorno.AppendLine("Lista de Vehiculos: ");

            foreach (Vehiculo veh in e.vehiculos)
            {
                retorno.AppendLine(((Vehiculo)veh).ToString());
            }

            return retorno.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            foreach(Vehiculo veh in estacionamiento.vehiculos)
            {
                if(vehiculo==veh)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            retorno = !(estacionamiento == vehiculo);

            return retorno;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string retorno = "";

            if(estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                retorno = vehiculo.ImprimirTicket();

                if(vehiculo is Moto)
                {
                    retorno += ((Moto)vehiculo).ToString();
                }

                if(vehiculo is PickUp)
                {
                    retorno += ((PickUp)vehiculo).ToString();
                }

                if(vehiculo is Automovil)
                {
                    retorno += ((Automovil)vehiculo).ToString();
                }
            }
            else
            {
                retorno = "El vehiculo no es parte del estacionamiento";
            }

            return retorno;
        }


        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            int flag = 0;

            if (estacionamiento == vehiculo)
            {
                flag = 1;
            }

            if(vehiculo.Patente == "")
            {
                flag = 1;
            }

            if(estacionamiento.espacioDisponible <= estacionamiento.vehiculos.Count)
            {
                flag = 1;
            }

            if(flag == 0)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }

            return estacionamiento;
        }
    }
}
