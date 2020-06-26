using Capa_Negocio;
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
    public partial class RgPacientes : Form
    {
        public RgPacientes()
        {
            InitializeComponent();
        }

        string genero;
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        CN_Paciente objFormaPciente = new CN_Paciente(); //Se crea una instancia de la clase Paciente
        private string id_paciente = null; //Se crea la variable id_paciente para su manipulación
        private bool editar = false; //Una bandera 

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

        private void validar(Form formulario)
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
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true)
            {
                MessageBox.Show("Favor de llenar todos los campos antes de finalizar registro."); // Si nuestra variable es verdadera mostramos un mensaje.
                vacio = false; // Devolvemos el valor original a nuestra variable.
            }
            else
            {
                if (editar == false)
                {
                    try
                    {
                        objFormaPciente.Insertar(txt_numseg.Text, txt_curp.Text, txt_nombres.Text, txt_apellidoP.Text, txt_apellidoM.Text, genero, txt_fecha.Text);
                        MessageBox.Show("Se inserto correctamente");
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos " + ex);
                    }
                }
                if (editar == true)
                {
                    try
                    {
                        objFormaPciente.Editar(txt_numseg.Text, txt_curp.Text, txt_nombres.Text, txt_apellidoP.Text, txt_apellidoM.Text, genero, txt_fecha.Text, id_paciente);
                        MessageBox.Show("Se edito correctamente");
                        limpiar();
                        editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo modifiar el registro " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos para editar registro");
                }
            }
        }

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                monthCalendar1.SelectionStart.Month.ToString() + "-" +
                monthCalendar1.SelectionStart.Day.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e) //Registrar paciente
        {
            validar(this);
        }

        private void txt_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha.Clear();
        }

        private void RgPacientes_Load(object sender, EventArgs e)
        { 

        }
    }
}
