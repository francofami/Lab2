using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            float retorno = 0;

            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Bimestral:
                    retorno = (base.monto * (float)0.35) + base.monto;
                    break;
                case PeriodicidadDePagos.Mensual:
                    retorno = (base.monto * (float)0.25) + base.monto;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = (base.monto * (float)0.4) + base.monto;
                    break;
            }

            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan tspan = nuevoVencimiento - this.vencimiento;

            int dias = tspan.Days;

            for (int i = 0; i < dias; i++)
            {
                base.monto += (float) 2.5;
            }

            this.vencimiento = nuevoVencimiento;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }
    }
}
