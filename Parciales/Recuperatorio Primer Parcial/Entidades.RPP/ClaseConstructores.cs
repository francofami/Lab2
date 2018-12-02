using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class ClaseConstructores
    {
        int num1;
        int num2;
        //Crear una clase (ClaseConstructores) que al instanciarse:
        //    *pase por un constructor estático
        //    *pase por un constructor que reciba 2 parámetros (privado)
        //    *pase por un constructor publico (default)
        //    *pase por una propiedad de sólo escritura
        //    *pase por una propiedad de sólo lectura
        //    *pase por un método de instancia
        //    *pase por un método de clase
        //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
        //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
        //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR

        static ClaseConstructores()
        {

        }

        /*private ClaseConstructores(int num1,  int num2)
        {
            this.PropEscritura = num1;
            this.PropLectura;
        }*/

        /*public ClaseConstructores() : this(2,4)
        {

        }*/

        public int PropEscritura
        {
            set
            {

            }
        }

        /*public int PropLectura
        {

            get
            {

            }
        }*/

        public void metodoInstancia()
        {

        }

        public static void metodoEstatico()
        {


        }
    }
}
