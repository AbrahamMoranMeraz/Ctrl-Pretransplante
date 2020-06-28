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
    public partial class NuevosEstudiosCate : Form
    {
        DataTable table;

        public NuevosEstudiosCate()
        {
            InitializeComponent();
        }

        private void NuevosEstudiosCate_Load(object sender, EventArgs e)
        {
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            table = objforma.Vistas("Categorias");
            for (int x = 0; x < table.Rows.Count; x++)
            {
                cmbxCategorias.Items.Add(table.Rows[x].ItemArray[0].ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEstudio.Text != "")
            {
                Capa_Negocio.CN_Paciente cN = new Capa_Negocio.CN_Paciente();
                if (MessageBox.Show("Agregar Estudio '" + txtEstudio.Text + "' a la categoria '" + categoria() + "', ¿estas seguro?", "Advertencia",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cN.GuardaEstudio(txtEstudio.Text, cmbxCategorias.SelectedIndex + 1);
                }
                llenarList();
                txtEstudio.Text = "";
                txtEstudio.Focus();
            }
            else
            {
                MessageBox.Show("Agregar nombre del estudios primero");
                txtEstudio.Focus();
            }
        }

        private void llenarList()
        {
            lisatadeestudios.Items.Clear();
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            if (cmbxCategorias.SelectedIndex == 0)
            {
                table = objforma.Vistas("Est_PIR");
            }
            else
            {
                if (cmbxCategorias.SelectedIndex == 1)
                {
                    table = objforma.Vistas("Est_PINR");
                }
                else
                {
                    if (cmbxCategorias.SelectedIndex == 2)
                    {
                        table = objforma.Vistas("Ser_PI");
                    }
                    else
                    {
                        if (cmbxCategorias.SelectedIndex == 3)
                        {
                            table = objforma.Vistas("Ser_2P");
                        }
                        else
                        {
                            if (cmbxCategorias.SelectedIndex == 4)
                            {
                                table = objforma.Vistas("Ser_Otros");
                            }
                            else
                            {
                                if (cmbxCategorias.SelectedIndex == 5)
                                {
                                    table = objforma.Vistas("Radio_PI");
                                }
                                else
                                {
                                    if (cmbxCategorias.SelectedIndex == 6)
                                    {
                                        table = objforma.Vistas("Radio_2P");
                                    }
                                    else
                                    {
                                        if (cmbxCategorias.SelectedIndex == 7)
                                        {
                                            table = objforma.Vistas("Pre_Op");
                                        }
                                        else
                                        {
                                            if (cmbxCategorias.SelectedIndex == 8)
                                            {
                                                table = objforma.Vistas("Donador");
                                            }
                                            else
                                            {
                                                if (cmbxCategorias.SelectedIndex == 9)
                                                {
                                                    table = objforma.Vistas("Especiales");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int x = 0; x < table.Rows.Count; x++)
            {
                lisatadeestudios.Items.Add(table.Rows[x].ItemArray[0].ToString());
            }
            for (int i = 0; i < lisatadeestudios.Items.Count; i++)
                lisatadeestudios.SetItemChecked(i, false);
            btnBorrar.Visible = true;
        }

        private void cmbxCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarList();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
                Capa_Negocio.CN_Paciente cN_ = new Capa_Negocio.CN_Paciente();
                int x = 0;
                for (x = 0; x < lisatadeestudios.Items.Count; x++)
                {
                    if (lisatadeestudios.GetItemChecked(x))
                    {
                        if (MessageBox.Show("Eliminar Estudio '" + lisatadeestudios.Items[x].ToString() + "' de la categoria '" + categoria() + "', ¿estas seguro? Se eliminara este dato de pacientes previos", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cN_.BorrarEstudio(lisatadeestudios.Items[x].ToString());
                        }
                    }
                }
            llenarList();
        }

        private string categoria()
        {
            int x;
            string categoria = "";
            x = cmbxCategorias.SelectedIndex +1;
            switch (x)
            {
                case 1:
                    categoria = "Protocolo Inicial Relacionado";
                    break;
                case 2:
                    categoria = "Protocolo Inicial No Relacionado";
                    break;
                case 3:
                    categoria = "Protocolo Inicial (Servicios)";
                    break;
                case 4:
                    categoria = "2do Protocolo (Servicios)";
                    break;
                case 5:
                    categoria = "Otros (Servicios)";
                    break;
                case 6:
                    categoria = "Protocolo Inicial (Radiología)";
                    break;
                case 7:
                    categoria = "2do Protocolo (Radiología)";
                    break;
                case 8:
                    categoria = "PREOPERATORIOS";
                    break;
                case 9:
                    categoria = "DONADOR";
                    break;
                case 10:
                    categoria = "ESPECIALES";
                    break;

            }
            return categoria;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonGuardar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGuardar.Checked)
            {
                txtEstudio.Enabled = true;
                btnGuardar.Enabled = true;
                radioButtonBorrar.Checked = false;
                lisatadeestudios.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        private void radioButtonBorrar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBorrar.Checked)
            {
                lisatadeestudios.Enabled = true;
                btnBorrar.Enabled = true;
                radioButtonGuardar.Checked = false;
                btnGuardar.Enabled = false;
                txtEstudio.Enabled = false;
            }
        }
    }
}
