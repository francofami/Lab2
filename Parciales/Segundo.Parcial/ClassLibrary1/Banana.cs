using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Banana : Fruta
    {
        //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false

        protected string _paisOrigen;
        
        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }
        
        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.FrutaToString());
            retorno.AppendLine("Pais: " + this._paisOrigen);

            return retorno.ToString();
        }

        public Banana(string nombre, double peso, string pais) : base(nombre, peso)
        {
            this._paisOrigen = pais;
        }
    }
}
