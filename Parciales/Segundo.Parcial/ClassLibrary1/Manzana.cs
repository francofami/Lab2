using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ClassLibrary1
{
    public class Manzana : Fruta, ISerializar<Manzana>, IDeserializar
    {
        //Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true

        protected string _provinciaOrigen;

        public string Provincia
        {
            get
            {
                return this._provinciaOrigen;
            }
            set
            {
                this._provinciaOrigen = value;
            }

        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public string Nombre
        {
            get
            {
                return "Manzana";
            }
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.FrutaToString());
            retorno.AppendLine("Provincia: " + this._provinciaOrigen);

            return retorno.ToString();
        }

        public Manzana()
        {

        }

        public Manzana(string nombre, double peso, string provincia) : base(nombre, peso)
        {
            this._provinciaOrigen = provincia;
        }       

        public bool Xml(string path)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
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

        bool IDeserializar.Xml(string path, out Fruta item)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                XmlTextReader reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path);
                item = (Manzana)serializer.Deserialize(reader);
                reader.Close();
                retorno = true;
            }
            catch(Exception)
            {
                retorno = false;
                item = null;
            }

            return retorno;
        }
    }
}
