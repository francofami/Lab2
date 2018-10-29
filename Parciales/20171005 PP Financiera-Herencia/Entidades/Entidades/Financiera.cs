using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float retorno = 0;
            float totalDolares = 0;
            float totalPesos = 0;

            foreach(Prestamo presta in this.listaDePrestamos)
            {
                if(presta is PrestamoPesos)
                {
                    totalPesos += ((PrestamoPesos)presta).Monto;
                }

                if(presta is PrestamoDolar)
                {
                    totalDolares += ((PrestamoDolar)presta).Monto;
                }
            }

            switch(tipoPrestamo)
            {
                case TipoDePrestamo.Dolares:
                    retorno = totalDolares;
                    break;
                case TipoDePrestamo.Pesos:
                    retorno = totalPesos;
                    break;
                case TipoDePrestamo.Todos:
                    retorno = totalPesos + totalDolares;
                    break;
            }

            return retorno;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Razon social: " + financiera.razonSocial);
            retorno.AppendLine("Intereses en pesos: " + financiera.InteresesEnPesos);
            retorno.AppendLine("Intereses en dolares: " + financiera.InteresesEnDolares);
            retorno.AppendLine("Intereses totales: " + financiera.InteresesTotales);
            retorno.AppendLine("\nPrestamos:\n");

            foreach (Prestamo presta in financiera.listaDePrestamos)
            {
                retorno.AppendLine(presta.Mostrar());
            }

            return retorno.ToString();
        }

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine((string)financiera);

            return retorno.ToString();
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;

            foreach(Prestamo presta in financiera.listaDePrestamos)
            {
                if(presta == prestamo)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;

            retorno = !(financiera == prestamo);

            return retorno;
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if ((financiera == prestamoNuevo) == false)
                financiera.listaDePrestamos.Add(prestamoNuevo);
            else
                Console.WriteLine("No ser pudo añadir prestamo, ya existe.");

            return financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
    }
}
