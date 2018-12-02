using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace PP
{
    
    //DESARROLLAR DENTRO DEL NAMESPACE RAIZ ENTIDADES.RPP EN UN PROYECTO DE TIPO CLASS LIBRARY

    public partial class frmPP : Form
    {
        private BancoNacional _bn;
        private BancoProvincial _bp;
        private BancoMunicipal _bm;

        public frmPP()
        {
            InitializeComponent();
        }

        //Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene un Array de la clase Producto.
        //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
        //del depósito (REUTILIZAR CODIGO). 
        //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
        //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
        //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        //Mostrar el contenido del array resultante (nombre y stock)
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            Deposito d1 = new Deposito(4);
            Deposito d2 = new Deposito();

            d1.productos[0] = p1;
            d1.productos[1] = p2;
            d1.productos[2] = p3;
            d1.productos[3] = p3;

            d2.productos[0] = p1;
            d2.productos[1] = p1;
            d2.productos[2] = p2;

            Producto[] aux = d1 + d2;

            String s = "";
            foreach (Producto item in d1.productos)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }

            MessageBox.Show(s);
        }

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
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            ClaseConstructores o = new ClaseConstructores();
        }

        //Crear jerarquía que contenga los siguientes constructores (1 por clase):
        //Banco(nombre)
        //BancoNacional(nombre, pais)
        //BancoProvincial(bancoNacional, provincia)
        //BancoMunicipal(bancoProvincial, municipio)
        //Crear una instancia de cada clase e inicializar los atributos del form _bancoNacional, _bancoProvincial y _bancoMunicipal. 
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            BancoNacional bn = new BancoNacional("Banco de la Alegría", "Argentina");
            BancoProvincial bp = new BancoProvincial(bn, "Buenos Aires");
            BancoMunicipal bm = new BancoMunicipal(bp, "Avellaneda");

            this._bn = bn;
            this._bp = bp;
            this._bm = bm;

            
        }

        //Agregar en Banco el método Mostrar():string y Mostrar(Banco):string, ambos abstractos.
        //El método que no recibe parámetros, retornará el nombre, mientras que el otro
        //retornará todas las características de la instancia que recibe como parametro. REUTILIZAR CODIGO.
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bn.Mostrar() + "\n" + this._bn.Mostrar(this._bn));
            MessageBox.Show(this._bp.Mostrar() + "\n" + this._bn.Mostrar(this._bp));
            MessageBox.Show(this._bm.Mostrar() + "\n" + this._bn.Mostrar(this._bm));
        }

        //Agregar en la clase BancoMunicipal una sobrecarga en el implicit para que retorne todas
        //las características de la instancia. Aplicar polimorfismo sobre el método ToString
        //que deberá reutilizar código.
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bm);
        }

        //A partir de la clase depósito, crear la clase DepositoIndexado, modificando
        //el modificador de visibilidad (a privado) y el atributo productos, de Array a list<Producto>
        //Generar un indexador sobre DepositoIndexado. Por defecto, de 3 elementos.
        //Aplicar las validaciones necesarias.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            DepositoIndexado d = new DepositoIndexado(3);

            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            d[-1] = p1;
            d[0] = p1;
            d[1] = p2;
            d[2] = p3;
            d[3] = p3;

            String s = "";
            for (int i = 0; i < 3; i++)
            {
                s += (d[i].nombre + " - " + d[i].stock + "\n");
            }

            MessageBox.Show(s);

        }

        private void frmPP_Load(object sender, EventArgs e)
        {

        }

        private void btnPunto2_Click_1(object sender, EventArgs e)
        {
            ClaseConstructores nuevo = new ClaseConstructores();
        }

        private void btnPunto3_Click_1(object sender, EventArgs e)
        {
            BancoNacional bn = new BancoNacional("Banco de la Alegría", "Argentina");
            BancoProvincial bp = new BancoProvincial(bn, "Buenos Aires");
            BancoMunicipal bm = new BancoMunicipal(bp, "Avellaneda");

            this._bn = bn;
            this._bp = bp;
            this._bm = bm;
        }
    }
}
