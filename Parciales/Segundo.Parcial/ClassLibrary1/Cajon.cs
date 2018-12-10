using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public delegate void EventoPrecio(string s, double d); //Creo delegado

    public class Cajon<T> : ISerializar<T>
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public event EventoPrecio MuyCaro; //Creo evento

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this._precioUnitario * this._elementos.Count;
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precio, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Capacidad: " + this._capacidad);
            retorno.AppendLine("Cantidad total: " + this._elementos.Count);
            retorno.AppendLine("Elementos: ");

            foreach (T item in this._elementos)
            {
                retorno.AppendLine(item.ToString());
            }

            return retorno.ToString();
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T item)
        {
            try
            {
                if (cajon._elementos.Count < cajon._capacidad)
                {
                    cajon._elementos.Add(item);

                    if (cajon.PrecioTotal>55)
                    {
                        cajon.MuyCaro("cajonCaro.txt", cajon.PrecioTotal);
                        MessageBox.Show("El cajón superó los $55, gastando $" + cajon.PrecioTotal + " se generó un archivo .txt");
                    }
                }
                else
                {
                    throw new CajonLlenoException();
                }
            }
            catch(Exception)
            {
                
            }           

            return cajon;
        }

        public bool Xml(string path)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, Encoding.UTF8);
                serializer.Serialize(writer, this);
                writer.Close();
                retorno = true;

            }
            catch(Exception)
            {
                retorno = false;
            }

            return retorno;
        }

    }
}
