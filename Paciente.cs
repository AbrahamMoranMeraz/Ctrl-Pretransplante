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
        #region Variables
        string[] datos;
        string usuario;
        DataTable table;

        //Listas para las 10 categorias
        List<string> ListaPIR;//Protocolo Inicial Relacionado
        List<string> ListaPINR;//Protocolo Inicial No Relacionado

        //*****Unir en una lista solo para servicios*************//
        List<string> ListaServicios;
        List<string> ListaPIRA;//Protocolo Inicial (Radiología)
        List<string> ListaSPRA;//2do Protocolo (Radiología)
        //Unir en una lista solo para pre, dona, espec
        List<string> ListaOtros;

        //Lista de contadores de categorias
        List<int> Contadores;
        //informacion del medico
        List<string> medico;
        //objeto para interactuar con la siguiente capa
        Capa_Negocio.CN_Paciente cN_;
        #endregion

        public Paciente()
        {
            InitializeComponent();
        }

        private void MostrarEstudios()//Método para vizualizar los registros de la DB
        {
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            dataestudiosr.DataSource = objforma.Estudios(Convert.ToInt32(datos[0]));
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
            usuario = null;
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
            MostrarEstudios();
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            table = objforma.Vistas("Categorias");
            /*for(int x = 0; x < table.Rows.Count; x++)
            {
                categoriadeestudios.Items.Add(table.Rows[x].ItemArray[0].ToString());
            }*/
            Inicio formulario = null;
            //Encontrar al usuario actual
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Inicio))
                {
                    formulario = (Inicio)frm;
                    break;
                }
                else { }
            }
            usuario = formulario.UsuarioActual;
            Capa_Negocio.Generar_Formato.CalcularRuta();
            //llenar listcheckboxes
            llenarlistasCheck();
        }

        private void llenarlistasCheck()
        {
            //***********************Llenar los checkboxes*******************************//
            int x = 11;
            for (int i = 0; i < x; i++)
            {
                switch (i)
                {
                    case 1:
                        Capa_Negocio.CN_Paciente objforma1 = new Capa_Negocio.CN_Paciente();
                        table = objforma1.Vistas("Est_PIR");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox1.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 2:
                        Capa_Negocio.CN_Paciente objforma2 = new Capa_Negocio.CN_Paciente();
                        table = objforma2.Vistas("Est_PINR");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox2.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 3:
                        Capa_Negocio.CN_Paciente objforma3 = new Capa_Negocio.CN_Paciente();
                        table = objforma3.Vistas("Ser_PI");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox3.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 4:
                        Capa_Negocio.CN_Paciente objforma4 = new Capa_Negocio.CN_Paciente();
                        table = objforma4.Vistas("Ser_2P");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox4.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 5:
                        Capa_Negocio.CN_Paciente objforma5 = new Capa_Negocio.CN_Paciente();
                        table = objforma5.Vistas("Ser_Otros");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox5.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 6:
                        Capa_Negocio.CN_Paciente objforma6 = new Capa_Negocio.CN_Paciente();
                        table = objforma6.Vistas("Radio_PI");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox6.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 7:
                        Capa_Negocio.CN_Paciente objforma7 = new Capa_Negocio.CN_Paciente();
                        table = objforma7.Vistas("Radio_2P");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox7.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 8:
                        Capa_Negocio.CN_Paciente objforma8 = new Capa_Negocio.CN_Paciente();
                        table = objforma8.Vistas("Pre_Op");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox8.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 9:
                        Capa_Negocio.CN_Paciente objforma9 = new Capa_Negocio.CN_Paciente();
                        table = objforma9.Vistas("Donador");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox9.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                    case 10:
                        Capa_Negocio.CN_Paciente objforma10 = new Capa_Negocio.CN_Paciente();
                        table = objforma10.Vistas("Especiales");
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            checkedListBox10.Items.Add(table.Rows[j].ItemArray[0].ToString());
                        }
                        break;
                }
                //*************************************************************//
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MultiplesListas()
        {
            //Posible arreglo o algo pero no se
            Contadores = new List<int>();
            DataTable listTable = new DataTable();
            ListaPIR = new List<string>();
            ListaPINR = new List<string>();

            //*******Una sola lista Servicios************//
            ListaServicios = new List<string>();
            //********************************//
            ListaPIRA = new List<string>();
            ListaSPRA = new List<string>();
            //*******Una sola lista Otros************//
            ListaOtros = new List<string>();
            //*********************************//

            //Nombre y tipo a la tabla
            listTable.Columns.Add("Estudio", typeof(string));
            listTable.Columns.Add("Categoria", typeof(int));
            //**********************************//

            //******************Ver cual tiene opciones***************************//

            // Determine if there are any items checked.  
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox1.CheckedItems[x].ToString(), 1);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox1.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox2.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox2.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox2.CheckedItems[x].ToString(), 2);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox2.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox3.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox3.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox3.CheckedItems[x].ToString(), 3);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox3.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox4.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox4.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox4.CheckedItems[x].ToString(), 3);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox4.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox5.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox5.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox5.CheckedItems[x].ToString(), 3);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox5.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox6.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox6.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox6.CheckedItems[x].ToString(), 4);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox6.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox7.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox7.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox7.CheckedItems[x].ToString(), 5);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox7.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox8.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox8.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox8.CheckedItems[x].ToString(), 6);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox8.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox9.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox9.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox9.CheckedItems[x].ToString(), 6);
                    cN_.InsertarStudios(Convert.ToInt32(datos[0]), checkedListBox9.CheckedItems[x].ToString(), medico[4]);
                }
            }

            if (checkedListBox10.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox10.CheckedItems.Count; x++)
                {
                    listTable.Rows.Add(checkedListBox10.CheckedItems[x].ToString(), 6);
                }
            }
            //*****************************************************************************//

            //Crear contadores y agregar a nuevas listas

            int categoria1 = 0;
            int categoria2 = 0;
            int categoria3 = 0;
            int categoria4 = 0;
            int categoria5 = 0;
            int categoria6 = 0;

            //*****************************************//

            //Contador para llenar tabla
            int categoria = 7;
            //****************************//

            //Ciclo para llenar la tabla que contiene el nombre del estudio y el numero de categoria
            for (int i = 0; i < categoria; i++)
            {
                if (i == 1)
                {
                    DataRow[] result = listTable.Select("Categoria = 1");
                    foreach (DataRow row in result)
                    {
                        categoria1 = categoria1 + 1;
                        ListaPIR.Add(row["Estudio"].ToString());
                    }
                }
                if (i == 2)
                {
                    DataRow[] result = listTable.Select("Categoria = 2");
                    foreach (DataRow row in result)
                    {
                        categoria2 = categoria2 + 1;
                        ListaPINR.Add(row["Estudio"].ToString());
                    }
                }
                if (i == 3)
                {
                    DataRow[] result = listTable.Select("Categoria = 3");
                    foreach (DataRow row in result)
                    {
                        categoria3 = categoria3 + 1;
                        ListaServicios.Add(row["Estudio"].ToString());
                    }
                }

                if (i == 4)
                {
                    DataRow[] result = listTable.Select("Categoria = 4");
                    foreach (DataRow row in result)
                    {
                        categoria4 = categoria4 + 1;
                        ListaPIRA.Add(row["Estudio"].ToString());
                    }
                }

                if (i == 5)
                {
                    DataRow[] result = listTable.Select("Categoria = 5");
                    foreach (DataRow row in result)
                    {
                        categoria5 = categoria5 + 1;
                        ListaSPRA.Add(row["Estudio"].ToString());
                    }
                }

                if (i == 6)
                {
                    DataRow[] result = listTable.Select("Categoria = 6");
                    foreach (DataRow row in result)
                    {
                        categoria6 = categoria6 + 1;
                        ListaOtros.Add(row["Estudio"].ToString());
                    }
                }
            }
            //***************************************************************//

            //Llenar lista de contadores
            Contadores.Add(categoria1);
            Contadores.Add(categoria2);
            Contadores.Add(categoria3);
            Contadores.Add(categoria4);
            Contadores.Add(categoria5);
            Contadores.Add(categoria6);
            //************************//
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cN_ = new Capa_Negocio.CN_Paciente();
            //----------------------Datos del medico----------------------------------//
            Capa_AccesoDatos.UsuarioLogin medicos = new Capa_AccesoDatos.UsuarioLogin();
            medico = medicos.infomed(usuario);
            //-------------------------------------------------------------------------//
            //-------------------------imprimir por lista--------------------------------//
            MultiplesListas();
            MessageBox.Show(Capa_Negocio.Generar_Formato.ImpresioEnLista(comboBox1.SelectedItem.ToString(), medico, datos, Contadores,
            ListaPIR, ListaPINR, ListaServicios, ListaPIRA, ListaSPRA, ListaOtros, checkBoxNota.Checked));
            MostrarEstudios();
            Cambiostate();
        }

        private void Cambiostate()//Borrar los estodos pasados al precionar el boton de generar
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                checkedListBox2.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
                checkedListBox3.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
                checkedListBox4.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
                checkedListBox5.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
                checkedListBox6.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox7.Items.Count; i++)
                checkedListBox7.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox8.Items.Count; i++)
                checkedListBox8.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox9.Items.Count; i++)
                checkedListBox9.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox10.Items.Count; i++)
                checkedListBox10.SetItemChecked(i, false);
        }

        private void Paciente_SizeChanged(object sender, EventArgs e)
        {
            if(this.Size.Width <= 1140)
            {
                checkBoxNota.Font = new Font(checkBoxNota.Font.Name, 8);
            }else if(this.Size.Width > 1300)
            {
                checkBoxNota.Font = new Font(checkBoxNota.Font.Name, 18);
            }
            else { }
        }

        private void tabControlClinicos_Click(object sender, EventArgs e)
        {
            if (tabControlClinicos.SelectedTab.Name == "tabPageRadiologicos")
            {
                checkBoxNota.Visible = true;
                checkBoxNota.ForeColor = Color.Black;
                checkBoxNota.Checked = true;
            }
            else
            {
                checkBoxNota.Visible = false;
            }
        }
    }
}
