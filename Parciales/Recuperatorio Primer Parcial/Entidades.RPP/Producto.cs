using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Producto
    {
        #region Atributos
       // dos atributos: nombre y stock

        public string nombre;
        public int stock;

        #endregion

        #region Constructores
        //un unico constructor

        public Producto(string producto , int stock)
        {
            this.nombre = producto;
            this.stock = stock;
        }


        #endregion
    }
}
