using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);
            Menor menor1 = new Menor("Nene1", "ApeNene1", Menor.eMenu.Hamburguesa);
            Menor menor2 = new Menor("Nene2", "ApeNene2", Menor.eMenu.Milanesa);
            Mayor mayor1 = new Mayor("Mayor1", "ApeMayor1", Mayor.eBebidas.Agua);
            Mayor mayor2 = new Mayor("Mayor2", "ApeMayor2", Mayor.eBebidas.Vino);

            mesa1 += menor1;
            mesa1 += menor2;
            mesa1 += menor2;
            mesa1 += mayor1;
            mesa1 += mayor2;
            mesa1 += mayor2;

            Console.WriteLine((string)mesa1);
            Console.ReadKey();
        }
    }
}
