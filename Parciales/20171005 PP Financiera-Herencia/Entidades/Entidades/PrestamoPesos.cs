using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            float retorno = 0;

            retorno = (this.porcentajeInteres * base.monto) + base.monto;

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Mostrar());
            retorno.AppendFormat("Porcentaje Interes {0}%: ", this.porcentajeInteres);
            retorno.AppendFormat("Interes: ${0}", this.Interes);

            return retorno.ToString();
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan tspan = nuevoVencimiento - this.vencimiento;

            int dias = tspan.Days;

            for(int i=0; i<dias; i++)
            {
                this.porcentajeInteres += (float) 0.0025;
            }

            this.vencimiento = nuevoVencimiento;
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }
    }
}
