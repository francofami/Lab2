using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Fruta
    {
        //Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
        //constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)

        protected string _color;
        protected double _peso;

        public string Color { get { return this._color; } set { this._color = value; } } //necesarias para serializar miembros privados.
        public double Peso { get { return this._peso; } set { this._peso = value; } }

        public abstract bool TieneCarozo
        {
            get;
        }

        public Fruta()
        {

        }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Color: " + this._color);
            retorno.AppendLine("Peso: " + this._peso);

            return retorno.ToString();
        }
    }
}
