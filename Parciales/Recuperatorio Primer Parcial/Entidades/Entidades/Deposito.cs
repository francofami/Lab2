using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        public Producto[] productos;

        public Deposito() : this(3)
        {

        }

        public Deposito(int cantidad)
        {
            this.productos = new Producto[cantidad];
        }

        public static Producto[] operator +(Deposito a, Deposito b)
        {
            int i = 0;

            Producto[] retorno = new Producto[a.productos.Length];
            retorno = a.productos;
        
            foreach(Producto prod in retorno)
            {

                foreach(Producto prod2 in b.productos)
                {
                    if(prod.nombre == prod2.nombre)
                    {
                        retorno[i] += prod2;                   
                    }                                              
                }

                i++;
            }           

            return retorno;
        }
    }
}
