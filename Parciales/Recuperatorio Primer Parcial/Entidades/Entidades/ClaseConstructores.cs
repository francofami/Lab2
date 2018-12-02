using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class ClaseConstructores
    {
        private string a;

        static ClaseConstructores()
        {
            MessageBox.Show("Constructor estático.");
        }

        private ClaseConstructores(string a, string b)
        {
            MessageBox.Show("Constructor privado que recibe dos parámetros.");
            this.PropiedadEscritura = this.PropiedadLectura;        
        }

        public ClaseConstructores() : this("","")
        {
            MessageBox.Show("Constructor público por default.");
        }

        public string PropiedadLectura
        {
            get
            {
                MessageBox.Show("Propiedad de solo lectura.");
                return this.metodoDeInstancia();             
            }
        }

        public string PropiedadEscritura
        {
            set
            {
                MessageBox.Show("Propiedad de solo escritura.");
                this.a = value;             
            }
        }

        public static string metodoDeClase()
        {
            MessageBox.Show("Metodo de clase.");
            return "";
        }

        public string metodoDeInstancia()
        {
            MessageBox.Show("Metodo de instancia.");
            return ClaseConstructores.metodoDeClase();
        }
    }
}
