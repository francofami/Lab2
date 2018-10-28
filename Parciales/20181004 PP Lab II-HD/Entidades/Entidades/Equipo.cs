using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private static int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                    this.directorTecnico = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder retorno = new StringBuilder();

            if(e.directorTecnico == null)
            {
                retorno.AppendLine("Sin DT asignado");
            }
            else
            {
                retorno.AppendLine("DT: " + e.directorTecnico.Mostrar());
            }
            
            retorno.AppendLine("\n\nJugadores: \n\n");

            foreach(Jugador jug in e.jugadores)
            {
                retorno.AppendLine(((Jugador)jug).Mostrar());
            }


            return retorno.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            foreach (Jugador jug in e.jugadores)
            {
                if((Jugador)jug == (Jugador)j)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            bool retorno = false;

            retorno = !(e == j);

            return retorno;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            int flag = 0;

            if(e.jugadores.Count >= Equipo.cantidadMaximaJugadores)
            {
                flag = 1;
            }

            foreach(Jugador jug in e.jugadores)
            {
                if ((Jugador)jug == (Jugador)j)
                {
                    flag = 1;
                    break;
                }
            }

            if(j.ValidarAptitud() == false)
            {
                flag = 1;
            }

            if(flag == 0)
            {
                e.jugadores.Add(j);
            }

            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;

            int flag = 0;
            int totalJugadores = 0;
            int totalArqueros = 0;
            int totalDefensores = 0;
            int totalCentrales = 0;
            int totalDelanteros = 0;

            if (e.directorTecnico == null)
            {
                flag = 1;
            }

            foreach(Jugador jug in e.jugadores)
            {
                switch (jug.Posicion)
                {
                    case Posicion.Arquero:
                        totalArqueros += 1;
                        break;
                    case Posicion.Central:
                        totalCentrales += 1;
                        break;
                    case Posicion.Defensor:
                        totalDefensores += 1;
                        break;
                    case Posicion.Delantero:
                        totalDelanteros += 1;
                        break;
                }

                totalJugadores++;
            }

            if(totalArqueros!=1 || totalCentrales<= 0 || totalDefensores<=0 || totalDelanteros<=0)
            {
                flag = 1;
            }

            if(totalJugadores != Equipo.cantidadMaximaJugadores)
            {
                flag = 1;
            }

            if(flag==0)
            {
                retorno = true;
            }

            return retorno;
        }


    }
}
