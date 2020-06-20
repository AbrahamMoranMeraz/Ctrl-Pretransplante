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
    public partial class Lista_P : Form
    {
        string[] datos;
        Capa_Negocio.CN_Paciente objforma;
<<<<<<< HEAD
=======
        Form formulario;
>>>>>>> Abraham
        public Lista_P()
        {
            InitializeComponent();
        }

        private void MostrarPa()//Método para vizualizar los registros de la DB
        {
            objforma = new Capa_Negocio.CN_Paciente();
            Lista.DataSource = objforma.MostrarPaci();
        }

        private void Lista_P_Load(object sender, EventArgs e)
        {
            MostrarPa();
            datos = new string[7];
        }

        private void Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            datos[0] = Lista.Rows[e.RowIndex].Cells[0].Value.ToString();
            datos[1] = Lista.Rows[e.RowIndex].Cells[1].Value.ToString();
            datos[2] = Lista.Rows[e.RowIndex].Cells[2].Value.ToString();
            datos[3] = Lista.Rows[e.RowIndex].Cells[3].Value.ToString();
            datos[4] = Lista.Rows[e.RowIndex].Cells[4].Value.ToString();
            datos[5] = Lista.Rows[e.RowIndex].Cells[5].Value.ToString();
            datos[6] = Lista.Rows[e.RowIndex].Cells[6].Value.ToString();
            formulario = pacientes.Controls.OfType<Paciente>().FirstOrDefault();//buscaen la coleccion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new Paciente(datos);
                formulario.TopLevel = false;
                pacientes.Controls.Add(formulario);
                pacientes.Tag = formulario;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            else//Si el formulario existe
            {
                formulario.Close();
                formulario = new Paciente(datos);
                formulario.TopLevel = false;
                pacientes.Controls.Add(formulario);
                pacientes.Tag = formulario;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            tap.DeselectTab(0);//Cambia a la siguiente pagina del tap desde la pagina 0
        }

        private void pacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Convert.ToString(tap.SelectedIndex));
        }

<<<<<<< HEAD
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

=======
>>>>>>> Abraham
        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarPa();
        }
    }
}
