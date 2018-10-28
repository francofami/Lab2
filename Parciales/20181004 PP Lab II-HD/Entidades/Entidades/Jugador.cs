using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(((Persona)this).Mostrar());
            retorno.AppendLine("Altura: " + this.altura);
            retorno.AppendLine("Peso: " + this.peso);
            retorno.AppendLine("Posicion: " + this.posicion);

            return retorno.ToString();
        }

        public bool ValidarAptitud()
        {
            bool retorno = false;

            if(this.Edad<=40 && this.ValidarEstadoFisico()==true)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;

            float imc = this.peso / (this.altura * this.altura);

            if(imc>=18.5 && imc<=25)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
