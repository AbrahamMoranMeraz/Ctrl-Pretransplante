using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_PreTransplante_V2
{
    public partial class Paciente : Form
    {
        string[] datos;
        DataTable table;

        public Paciente()
        {
            InitializeComponent();
        }

        private void MostrarEstudios(string nss)//Método para vizualizar los registros de la DB
        {
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            dataestudiosr.DataSource = objforma.Estudios(nss);
        }

        public Paciente(string[] datos)
        {
            InitializeComponent();
            this.datos = new string[datos.Length];
            this.datos = datos;
        }

        public void ActualizarDatos(string[] datos)
        {
            this.datos = datos;
            lbnombre.Text = datos[3];
            lbpaterno.Text = datos[4];
            lbmaterno.Text = datos[5];
            lbnss.Text = datos[1];
        }

        private void Estudios_Load(object sender, EventArgs e)
        {
            //Llenar combobox con lo tipos de impresoras para seleccionar uno//
            PrintDocument prtdoc = new PrintDocument();
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(strPrinter);
                if (strPrinter == strDefaultPrinter)
                {
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf(strPrinter);
                }
            }
            //***************************************************************//
            lbnombre.Text = datos[1];
            lbpaterno.Text = datos[2];
            lbmaterno.Text = datos[3];
            lbnss.Text = datos[5];
            MostrarEstudios(datos[5]);
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            table = objforma.Vistas("Categorias");
            for(int x = 0; x < table.Rows.Count; x++)
            {
                categoriadeestudios.Items.Add(table.Rows[x].ItemArray[0].ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;//Contador de estudios
            int y = 0;//Contador de estudios que si se seleccionaron
            Capa_Negocio.CN_Paciente cN_ = new Capa_Negocio.CN_Paciente();
            
            string[] listadeestudios = new string[18];
            for (x = 0; x < lisatadeestudios.Items.Count; x++)
            {
                if (lisatadeestudios.GetItemChecked(x))
                {
                    cN_.InsertarStudios(datos[5], lisatadeestudios.Items[x].ToString(), null);
                    listadeestudios[y] = lisatadeestudios.Items[x].ToString();
                    y++;
                }
                else
                {

                }
            }
            if (categoriadeestudios.SelectedIndex==0 || categoriadeestudios.SelectedIndex == 1)
            {
                MessageBox.Show(Capa_Negocio.Generar_Formato.NuevoFormato(listadeestudios, datos, y, comboBox1.SelectedItem.ToString(), categoriadeestudios.SelectedItem.ToString()));
            }
            else if (categoriadeestudios.SelectedIndex==2 || categoriadeestudios.SelectedIndex == 3 || categoriadeestudios.SelectedIndex == 4)
            {
                MessageBox.Show(Capa_Negocio.Generar_Formato.FormatoServicios(listadeestudios, datos, y, comboBox1.SelectedItem.ToString(), categoriadeestudios.SelectedItem.ToString()));
            }
            else if (categoriadeestudios.SelectedIndex == 5 || categoriadeestudios.SelectedIndex == 6)
            {
                MessageBox.Show(Capa_Negocio.Generar_Formato.FormatoRadiologia(listadeestudios, datos, y, comboBox1.SelectedItem.ToString(),categoriadeestudios.SelectedItem.ToString()));
            }
            MostrarEstudios(datos[5]);
        }

        private void categoriadeestudios_SelectedValueChanged(object sender, EventArgs e)
        {
            lisatadeestudios.Items.Clear();
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            if (categoriadeestudios.SelectedIndex == 0)
            {
                table = objforma.Vistas("Est_PIR");
            }
            else
            {
                if (categoriadeestudios.SelectedIndex == 1)
                {
                    table = objforma.Vistas("Est_PINR");
                }
                else
                {
                    if (categoriadeestudios.SelectedIndex==2)
                    {
                        table = objforma.Vistas("Ser_PI");
                    }
                    else
                    {
                        if (categoriadeestudios.SelectedIndex==3)
                        {
                            table = objforma.Vistas("Ser_2P");
                        }
                        else
                        {
                            if (categoriadeestudios.SelectedIndex==4)
                            {
                                table = objforma.Vistas("Ser_Otros");
                            }
                            else 
                            {
                                if (categoriadeestudios.SelectedIndex==5)
                                {
                                    table = objforma.Vistas("Radio_PI");
                                }
                                else
                                {
                                    if (categoriadeestudios.SelectedIndex==6)
                                    {
                                        table = objforma.Vistas("Radio_2P");
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
                lisatadeestudios.SetItemChecked(i, true);
            button1.Visible = true;
        }

        private void dataestudiosr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
