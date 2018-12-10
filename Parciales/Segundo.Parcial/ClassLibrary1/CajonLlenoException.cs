using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibrary1
{
    class CajonLlenoException : Exception
    {
        public CajonLlenoException()
        {
            MessageBox.Show("No se puede agregar mas fruta: el cajón está lleno.");
        }
    }
}
