﻿using System;
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
        public Paciente()
        {
            InitializeComponent();
        }

        private void MostrarEstudios(string nss)//Método para vizualizar los registros de la DB
        {
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            dataestudiosp.DataSource = objforma.Estudios(nss);
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
            lbnombre.Text = datos[3];
            lbpaterno.Text = datos[4];
            lbmaterno.Text = datos[5];
            lbnss.Text = datos[1];
            MostrarEstudios(datos[1]);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;//Contador de estudios
            int y = 0;//Contador de estudios que si se seleccionaron
            string[] listadeestudios = new string[18];
            for (x = 0; x < checkedListBox1.Items.Count; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    listadeestudios[y] = checkedListBox1.Items[x].ToString();
                    y++;
                }
                else
                {

                }
            }
            //MessageBox.Show(Capa_Negocio.Generar_Formato.NuevoFormato(listadeestudios, datos, y, comboBox1.SelectedItem.ToString())/*,Capa_Negocio.Generar_Formato.FormatoServicios(listadeestudios,datos,y,comboBox1.SelectedItem.ToString())*/);
            MessageBox.Show(/*Capa_Negocio.Generar_Formato.NuevoFormato(listadeestudios, datos, y, comboBox1.SelectedItem.ToString()), */Capa_Negocio.Generar_Formato.FormatoServicios(listadeestudios, datos, y, comboBox1.SelectedItem.ToString()));
        }
    }
}
