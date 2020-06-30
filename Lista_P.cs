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
        Form formulario;

        public Lista_P()
        {
            InitializeComponent();
        }

        private void MostrarPa()//Método para vizualizar los registros de la DB
        {
            objforma = new Capa_Negocio.CN_Paciente();
            Lista.DataSource = objforma.MostrarPaci();
            Lista.Columns[0].Visible = false;
        }

        private void Lista_P_Load(object sender, EventArgs e)
        {
            MostrarPa();
            datos = new string[7];
        }

        private void Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Filas())
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
            else { }
        }

        private void pacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Convert.ToString(tap.SelectedIndex));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarPa();
        }

        private void Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Filas())
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
            else { }
        }

        private void Estudios_Click(object sender, EventArgs e)
        {
            if (Filas())
            {
                datos[0] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[0].Value.ToString();
                datos[1] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[1].Value.ToString();
                datos[2] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[2].Value.ToString();
                datos[3] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[3].Value.ToString();
                datos[4] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[4].Value.ToString();
                datos[5] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[5].Value.ToString();
                datos[6] = Lista.Rows[Lista.SelectedRows[0].Index].Cells[6].Value.ToString();
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
            else { }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Filas())
            {
                EditarPacientes editar = new EditarPacientes();
                editar.txt_nombres.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[1].Value.ToString();
                editar.txt_apellidoP.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[2].Value.ToString();
                editar.txt_apellidoM.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[3].Value.ToString();
                editar.txt_curp.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[4].Value.ToString();
                editar.txt_numseg.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[5].Value.ToString();
                editar.txt_fecha.Text = Lista.Rows[Lista.SelectedRows[0].Index].Cells[6].Value.ToString();
                editar.id_paciente = Lista.Rows[Lista.SelectedRows[0].Index].Cells[0].Value.ToString();
                if (Lista.Rows[Lista.SelectedRows[0].Index].Cells[7].Value.ToString() != "F")
                {
                    editar.rdb_masculino.Checked = true;
                }
                else
                {
                    editar.rdb_femenino.Checked = true;
                }
                editar.TopMost = true;
                editar.TopLevel = true;
                editar.ShowDialog();
                MostrarPa();
            }
            else
            {

            }
        }

        private void Lista_Resize(object sender, EventArgs e)
        {
            if(this.Size.Width < 1120)
            {
                Lista.ColumnHeadersDefaultCellStyle.Font = new Font(Lista.ColumnHeadersDefaultCellStyle.Font.Name, 10);
                Lista.RowsDefaultCellStyle.Font = new Font(Lista.RowsDefaultCellStyle.Font.Name, 12);
            }
            else
            {
                Lista.ColumnHeadersDefaultCellStyle.Font = new Font(Lista.ColumnHeadersDefaultCellStyle.Font.Name, 16);
                Lista.RowsDefaultCellStyle.Font = new Font(Lista.RowsDefaultCellStyle.Font.Name, 16);
            }   
        }

        private Boolean Filas()
        {
            if(Lista.Rows.Count > 1 && Lista.SelectedRows.Count <2)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Seleccione solo una fila");
                return false;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow oControls in Lista.Rows) // Buscamos en cada TextBox de nuestro Formulario.
                {
                    foreach(DataGridViewCell cell in oControls.Cells)
                    {
                        if(txt_buscar.Text == cell.Value.ToString())
                        {
                            Lista.Rows[cell.RowIndex].Selected = true;
                        }
                        else { }
                    }
                }
            }catch
            {
                MessageBox.Show("No coinicidio la busqueda.");
            }
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
            int c_filas = Lista.Rows.Count;
            if (e.KeyData == Keys.Enter)
            {
                foreach (DataGridViewRow oControls in Lista.Rows) // Buscamos en cada TextBox de nuestro Formulario.
                {
                    if ((oControls.Index != c_filas-1))
                    {
                        foreach (DataGridViewCell cell in oControls.Cells)
                        {
                            if (txt_buscar.Text == cell.Value.ToString())
                            {
                                Lista.ClearSelection();
                                Lista.Rows[cell.RowIndex].Selected = true;
                                bandera = true;
                                break;
                            }
                            else { }
                        }
                        if (bandera)
                        {
                            break;
                        }
                        else { }
                    }
                    else { MessageBox.Show("No se encontro coinicidencia"); break; }
                }
            }
            else
            {

            }
        }
    }
}
