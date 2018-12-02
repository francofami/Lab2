using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class DepositoIndexado
    {
        private List<Producto> productos;

        public Producto this[int indice]
        {
            get
            {
                return this.productos[indice];
            }

            set
            {
                this.productos[indice] = value;
            }

        }

        public DepositoIndexado() : this(3)
        {

        }

        public DepositoIndexado(int cantidad)
        {
            this.productos = new List<Producto>(cantidad);
        }
    }
}
