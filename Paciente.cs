using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_PreTransplante_V2
{
    public partial class Paciente : Form
    {
        string[] datos;
        public Paciente()
        {
            InitializeComponent();
        }

        public Paciente(string[] datos)
        {
            InitializeComponent();
            this.datos = new string[datos.Length];
            this.datos = datos;
        }
        private void Estudios_Load(object sender, EventArgs e)
        {
            lbnombre.Text = datos[3];
            lbpaterno.Text = datos[4];
            lbmaterno.Text = datos[5];
            lbnss.Text = datos[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
