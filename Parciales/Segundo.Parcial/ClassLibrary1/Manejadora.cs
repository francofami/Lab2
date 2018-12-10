using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Manejadora
    {
        public void PrecioCaro(string path, double precio)
        {
            try
            {
                StreamWriter sw;
                using (sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, true))
                {
                    sw.WriteLine("Precio total: {0}", precio);
                    sw.WriteLine(DateTime.Now);
                    sw.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
