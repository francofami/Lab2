using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Durazno : Fruta
    {
        //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true

        protected int _cantPelusa;

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.FrutaToString());
            retorno.AppendLine("Cantidad pelusa: " + this._cantPelusa);

            return retorno.ToString();
        }

        public Durazno(string nombre, double peso, int pelusa) : base(nombre, peso)
        {
            this._cantPelusa = pelusa;
        }
    }
}
