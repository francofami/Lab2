using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }

            set
            {
                this.añosExperiencia = value;
            }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(((Persona)this).Mostrar());
            retorno.AppendLine("Años de experiencia: " + this.añosExperiencia);

            return retorno.ToString();
        }

        public bool ValidarAptitud()
        {
            bool retorno = false;

            if (this.Edad<65 && this.añosExperiencia >= 2)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
