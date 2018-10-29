using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }

            set
            {
                if (value > DateTime.Now)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Now;
            }
        }

        public virtual void ExtenderPlazo(DateTime nuevoVencimiento)
        {
           this.vencimiento = nuevoVencimiento;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Monto {0:.##}", this.monto);
            retorno.AppendLine("Vencimiento: " + this.vencimiento);

            return retorno.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;

            if(p1.vencimiento < p2.vencimiento)
            {
                retorno = 1;
            }

            if (p1.vencimiento > p2.vencimiento)
            {
                retorno = -1;
            }

            return retorno;
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
    }
}
