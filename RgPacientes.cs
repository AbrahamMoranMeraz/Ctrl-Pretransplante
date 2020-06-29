using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_PreTransplante_V2
{
    public partial class RgPacientes : Form
    {
        public RgPacientes()
        {
            InitializeComponent();
        }

        string genero;
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        CN_Paciente objFormaPciente = new CN_Paciente(); //Se crea una instancia de la clase Paciente

        private void limpiar()
        {
            txt_nombres.Clear();
            txt_apellidoP.Clear();
            txt_apellidoM.Clear();
            txt_numseg.Clear();
            txt_curp.Clear();
            txt_fecha.Clear();
            rdb_masculino.Checked = false;
            rdb_femenino.Checked = false;
        }

        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "M";
        }
        private void rdb_femenino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "F";
        }

        private Boolean validar(Panel formulario)
        {
            if (rdb_masculino.Checked == true)
            {
                genero = "M";
            }
            else
            {
                genero = "F";
            }
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    return false; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
                else
                {

                }
            }
            return true;
        }
    

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                monthCalendar1.SelectionStart.Month.ToString() + "-" +
                monthCalendar1.SelectionStart.Day.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e) //Registrar paciente
        {
            if(validar(panel3) && validar(panel5))
            {
                try
                {
                    objFormaPciente.Insertar(txt_numseg.Text, txt_curp.Text, txt_nombres.Text, txt_apellidoP.Text, txt_apellidoM.Text, genero, txt_fecha.Text);
                    limpiar();
                    MessageBox.Show("Se inserto correctamente");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor verifique la informacion.");
            }
        }

        private void txt_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha.Clear();
        }

        private void RgPacientes_Load(object sender, EventArgs e)
        { 

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_fecha.Text = e.Start.Year.ToString() + "-" +
                e.Start.Month.ToString() + "-" +
                e.Start.Day.ToString();
        }
    }
}
