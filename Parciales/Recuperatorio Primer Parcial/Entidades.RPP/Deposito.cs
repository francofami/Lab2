using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Deposito
    {
        #region Atributos
        //contiene un Array de la clase Producto
        public Producto[] productos;

        #endregion

        #region Constructores

      //Un constructor por default (inicializa en 3 productos)
        public Deposito() : this(3)
        {
            
        }

      //una sobrecarga que reciba la cantidad de productos
        public Deposito(int tam)
        {
            this.productos = new Producto[tam];
        }

        #endregion

        #region SobrecargaOperadores

        //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
        //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.

        public static Producto[] operator +(Deposito p1 , Deposito p2)
        {
            Producto[] retorno = new Producto[0];

           //int i, j,k;

           // for (i = 0; i < p1.productos.Length; i++)
           // {
           //     for (j = 0; j < p2.productos.Length; j++)
           //     {
           //         if (p1.productos[i] == p2.productos[j])
           //         {

           //         }
           //         else
           //         {
           //             retorno[]=p1.productos[]
           //         }

           //     }
           // }

            return retorno;
        }

        #endregion

    }
}
