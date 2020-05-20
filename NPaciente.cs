using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using Capa_Negocio;

namespace Control_PreTransplante_V2
{
    public partial class NPaciente : Form
    {
        public NPaciente()
        {
            InitializeComponent();
        }

        private void ibtn_enviar_Click(object sender, EventArgs e)  //Método enviar funciona para generar el archivo PDF
        {

            //initialize word object  
            Document document = new Document();
            document.LoadFromFile(@"C:\Users\Core i3\Documents\Formulario de atención PreHospitalaria.docx");
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf Document(*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar PDF";
            saveFileDialog.FileName = txt_numseg.Text;

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    document.SaveToFile(saveFileDialog.FileName, FileFormat.PDF);
                    MessageBox.Show("All tasks are finished.", "doc processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    document.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ////Save doc file.
            //document.SaveToFile("Formulario1.docx", FileFormat.Docx);
            ////Convert to PDF  
            //document.SaveToFile("Formulario1.pdf", FileFormat.PDF);
            //MessageBox.Show("All tasks are finished.", "doc processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //document.Close();

            Dictionary<string, string> GetReplaceDictionary()
            {
                Dictionary<string, string> replaceDict = new Dictionary<string, string>();
                replaceDict.Add("#apellidoP#", txt_apellidoP.Text.Trim());
                replaceDict.Add("#apellidoM#", txt_apellidoM.Text);
                replaceDict.Add("#nombre#", txt_nombres.Text.Trim());

                return replaceDict;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btn_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" +
                monthCalendar1.SelectionStart.Year.ToString();
        }
        string genero;
        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "M";
        }
        private void rdb_femenino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "F";
        }
        //--------------------------Métodos CRUD------------------------------------------//
        CN_Paciente objFormaPciente = new CN_Paciente(); //Se crea una instancia de la clase Paciente
        private string id_paciente = null; //Se crea la variable id_paciente para su manipulación
        private bool editar = false; //Una bandera 

        private void Paciente_Load(object sender, EventArgs e)
        {
            MostrarPa();
        } //Evento que permite visualizar los registros 
        private void MostrarPa()
        {
            CN_Paciente objforma = new CN_Paciente();
            dataGridView1.DataSource = objforma.MostrarPaci();
        } //Método para vizualizar los registros de la DB

        private void btn_agregar_Click(object sender, EventArgs e) //Registrar paciente
        {
            validar(this);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            tbc_datosGenerales.Show();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txt_numseg.Text = dataGridView1.CurrentRow.Cells["Num_seg_social"].Value.ToString();
                txt_curp.Text = dataGridView1.CurrentRow.Cells["Curp"].Value.ToString();
                txt_nombres.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_apellidoP.Text = dataGridView1.CurrentRow.Cells["ApellidoP"].Value.ToString();
                txt_apellidoM.Text = dataGridView1.CurrentRow.Cells["ApellidoM"].Value.ToString();
                genero = dataGridView1.CurrentRow.Cells["sexo"].Value.ToString();
                txt_fecha.Text = dataGridView1.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                id_paciente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                tbc_datosGenerales.DeselectTab(1);
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_paciente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objFormaPciente.EliminarProd(id_paciente);
                MessageBox.Show("Eliminado correctamente");
                MostrarPa();
            }
            else
            {
                MessageBox.Show("No se puedo eliminar correctamente");
            }
        }

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

        //Validar todos los textbox
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
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
                        MostrarPa();
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
                        MostrarPa();
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
    }
}
