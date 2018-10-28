using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.dt = new DirectorTecnico(this.textBox1.Text, this.textBox2.Text, (int)this.numericUpDown3.Value, (int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value);

            MessageBox.Show("Se ha creado el DT");
            
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            if(Object.Equals(dt,null))
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else
            if(this.dt.ValidarAptitud()==true)
            {
                MessageBox.Show("El DT es apto");
            }
            else
            {
                MessageBox.Show("El DT no es apto");
            }
        }
    }
}
