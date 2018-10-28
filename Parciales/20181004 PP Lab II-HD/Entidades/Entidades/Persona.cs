using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Nombre: " + this.nombre);
            retorno.AppendLine("Apellido: " + this.apellido);
            retorno.AppendLine("Edad: " + this.edad);
            retorno.AppendLine("DNI: " + this.dni);

            return retorno.ToString();
        }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public bool ValidarAptitud()
        {
            bool retorno = true;



            return retorno;
        }
    }
}
