using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;//Libreria para word
using System.Reflection;//Libreria para word
using System.IO;//libreria para archivos
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace Capa_Negocio
{
    public static class Generar_Formato
    {
        #region Variables
        static String[] estudiosSeleccionados;
        static String[] datosPaciente;
        static bool notaRadiologia;//Nota de impresio validacion
        static string ruta;

        //Contadores
        static List<int> Contadores;
        //Listas
        static List<string> ListaPIR;//Protocolo Inicial Relacionado
        static List<string> ListaPINR;//Protocolo Inicial No Relacionado
        static List<string> ListaServicios;//Servicios
        static List<string> ListaPIRA;//Protocolo Inicial (Radiología)
        static List<string> ListaSPRA;//2do Protocolo (Radiología)
        static List<string> ListaOtros;//PREOPERATORIOS//DONADOR//ESPECIALES

        //***************************//
        //static string estudioespecial;
        #endregion

        static public String ImpresioEnLista(string impresora, List<string> medico, string [] paciente, List<int> MisContadores, 
        List<string> lista1, List<string> lista2, List<string> lista3, List<string> lista4, List<string> lista5, List<string> lista6, bool nota)
        {
            Contadores = MisContadores;
            ListaPIR = lista1;
            ListaPINR = lista2;
            ListaServicios = lista3;
            ListaPIRA = lista4;
            ListaSPRA = lista5;
            ListaOtros = lista6;

            datosPaciente = paciente;

            string algo = "Archivos Impresos!";

            #region Union de dos formatos impares
            //1-PIR-PINR
            if (Contadores[0] != 0 && Contadores[1] != 0)
            {
                string tipo1 = "Protocolo Inicial Relacionado";
                string tipo2 = "Protocolo Inicial No Relacionado";
                CreateWordDocument($"{ruta}F_B1.docx", $"{ruta}" + datosPaciente[5] + "_F_B1.docx", Contadores[0], Contadores[1], impresora, medico, tipo1, tipo2);
                Contadores[0] = Contadores[0] - Contadores[0];
                Contadores[1] = Contadores[1] - Contadores[1];
            }
            //2-PIRA-SPRA
            if ((Contadores[3] % 2) != 0 && (Contadores[4] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial (Radiología)";
                string tipo2 = "2do Protocolo (Radiología)";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_F2_2.docx", Contadores[3], Contadores[4], impresora, medico, tipo1, tipo2);
                ListaPIRA.RemoveAt(ListaPIRA.Count - 1);
                ListaSPRA.RemoveAt(ListaSPRA.Count - 1);
                Contadores[3] = Contadores[3] - 1;
                Contadores[4] = Contadores[4] - 1;
            }
            //3-PIR-SERVICIO
            if (Contadores[0] != 0 && (Contadores[2] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial Relacionado";
                string tipo2 = "Servicios";
                CreateWordDocument($"{ruta}F_U1.docx", $"{ruta}" + datosPaciente[5] + "_F_U1.docx", Contadores[0], Contadores[2], impresora, medico, tipo1, tipo2);
                ListaServicios.RemoveAt(ListaServicios.Count - 1);
                Contadores[0] = Contadores[0] - Contadores[0];
                Contadores[2] = Contadores[2] - 1;
            }
            //4-PINR-SERVICIO
            if (Contadores[1] != 0 && (Contadores[2] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial No Relacionado";
                string tipo2 = "Servicios";
                CreateWordDocument($"{ruta}F_U1.docx", $"{ruta}" + datosPaciente[5] + "_F_U1.docx", Contadores[1], Contadores[2], impresora, medico, tipo1, tipo2);
                ListaServicios.RemoveAt(ListaServicios.Count - 1);
                Contadores[1] = Contadores[1] - Contadores[1];
                Contadores[2] = Contadores[2] - 1;
            }
            //5-SERVICIO-PIRA
            if ((Contadores[3] % 2) != 0 && (Contadores[2] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial (Radiología)";
                string tipo2 = "Servicios";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U2.docx", $"{ruta}" + datosPaciente[5] + "_F_U2.docx", Contadores[3], Contadores[2], impresora, medico, tipo1, tipo2);
                ListaPIRA.RemoveAt(ListaPIRA.Count - 1);
                ListaServicios.RemoveAt(ListaServicios.Count - 1);
                Contadores[3] = Contadores[3] - 1;
                Contadores[2] = Contadores[2] - 1;
            }
            //6-SERVICIO-2PRA
            if ((Contadores[4] % 2) != 0 && (Contadores[2] % 2) != 0)
            {
                string tipo1 = "2do Protocolo (Radiología)";
                string tipo2 = "Servicios";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U2.docx", $"{ruta}" + datosPaciente[5] + "_F_U2.docx", Contadores[4], Contadores[2], impresora, medico, tipo1, tipo2);
                ListaSPRA.RemoveAt(ListaSPRA.Count - 1);
                ListaServicios.RemoveAt(ListaServicios.Count - 1);
                Contadores[4] = Contadores[4] - 1;
                Contadores[2] = Contadores[2] - 1;
            }
            //7-PIR-PIRA
            if (Contadores[0] != 0 && (Contadores[3] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial Relacionado";
                string tipo2 = "Protocolo Inicial (Radiología)";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U3.docx", $"{ruta}" + datosPaciente[5] + "_F_U3.docx", Contadores[0], Contadores[3], impresora, medico, tipo1, tipo2);
                ListaPIRA.RemoveAt(ListaPIRA.Count - 1);
                Contadores[0] = Contadores[0] - Contadores[0];
                Contadores[3] = Contadores[3] - 1;
            }
            //8-PIR-SPRA
            if (Contadores[0] != 0 && (Contadores[4] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial Relacionado";
                string tipo2 = "2do Protocolo (Radiología)";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U3.docx", $"{ruta}" + datosPaciente[5] + "_F_U3.docx", Contadores[0], Contadores[4], impresora, medico, tipo1, tipo2);
                ListaSPRA.RemoveAt(ListaSPRA.Count - 1);
                Contadores[0] = Contadores[0] - Contadores[0];
                Contadores[4] = Contadores[4] - 1;
            }
            //9-PIR-OTROS
            if (Contadores[0] != 0 && (Contadores[5] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial Relacionado";
                string tipo2 = "Otros";
                CreateWordDocument($"{ruta}F_U4.docx", $"{ruta}" + datosPaciente[5] + "_F_U4.docx", Contadores[0], Contadores[5], impresora, medico, tipo1, tipo2);
                ListaOtros.RemoveAt(ListaOtros.Count - 1);
                Contadores[0] = Contadores[0] - Contadores[0];
                Contadores[5] = Contadores[5] - 1;
            }
            //10-PINR-PIRA
            if (Contadores[1] != 0 && (Contadores[3] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial No Relacionado";
                string tipo2 = "Protocolo Inicial (Radiología)";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U3.docx", $"{ruta}" + datosPaciente[5] + "_F_U3.docx", Contadores[1], Contadores[3], impresora, medico, tipo1, tipo2);
                ListaPIRA.RemoveAt(ListaPIRA.Count - 1);
                Contadores[1] = Contadores[1] - Contadores[1];
                Contadores[3] = Contadores[3] - 1;
            }
            //11-PINR-SPRA
            if (Contadores[1] != 0 && (Contadores[4] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial No Relacionado";
                string tipo2 = "2do Protocolo (Radiología)";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U3.docx", $"{ruta}" + datosPaciente[5] + "_F_U3.docx", Contadores[1], Contadores[4], impresora, medico, tipo1, tipo2);
                ListaSPRA.RemoveAt(ListaSPRA.Count - 1);
                Contadores[1] = Contadores[1] - Contadores[1];
                Contadores[4] = Contadores[4] - 1;
            }
            //12-PINR-OTROS
            if (Contadores[1] != 0 && (Contadores[5] % 2) != 0)
            {
                string tipo1 = "Protocolo Inicial No Relacionado";
                string tipo2 = "Otros";
                CreateWordDocument($"{ruta}F_U4.docx", $"{ruta}" + datosPaciente[5] + "_F_U4.docx", Contadores[1], Contadores[5], impresora, medico, tipo1, tipo2);
                ListaOtros.RemoveAt(ListaOtros.Count - 1);
                Contadores[1] = Contadores[1] - Contadores[1];
                Contadores[5] = Contadores[5] - 1;
            }
            //13-PIRA-OTROS
            if ((Contadores[3] % 2) != 0 && (Contadores[5] % 2) != 0)
            {
                string tipo2 = "Protocolo Inicial (Radiología)";
                string tipo1 = "Otros";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U5.docx", $"{ruta}" + datosPaciente[5] + "_F_U5.docx", Contadores[5], Contadores[3], impresora, medico, tipo1, tipo2);
                ListaPIRA.RemoveAt(ListaPIRA.Count - 1);
                ListaOtros.RemoveAt(ListaOtros.Count - 1);
                Contadores[3] = Contadores[3] - 1;
                Contadores[5] = Contadores[5] - 1;
            }
            //14-PIRA-OTROS
            if ((Contadores[4] % 2) != 0 && (Contadores[5] % 2) != 0)
            {
                string tipo2 = "2do Protocolo (Radiología)";
                string tipo1 = "Otros";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U5.docx", $"{ruta}" + datosPaciente[5] + "_F_U5.docx", Contadores[5], Contadores[4], impresora, medico, tipo1, tipo2);
                ListaSPRA.RemoveAt(ListaSPRA.Count - 1);
                ListaOtros.RemoveAt(ListaOtros.Count - 1);
                Contadores[4] = Contadores[4] - 1;
                Contadores[5] = Contadores[5] - 1;
            }
            //15-PIRA-OTROS
            if ((Contadores[2] % 2) != 0 && (Contadores[5] % 2) != 0)
            {
                string tipo2 = "Servicios";
                string tipo1 = "Otros";
                notaRadiologia = nota;
                CreateWordDocument($"{ruta}F_U6.docx", $"{ruta}" + datosPaciente[5] + "_F_U6.docx", Contadores[5], Contadores[2], impresora, medico, tipo1, tipo2);
                ListaServicios.RemoveAt(ListaServicios.Count - 1);
                ListaOtros.RemoveAt(ListaOtros.Count - 1);
                Contadores[2] = Contadores[2] - 1;
                Contadores[5] = Contadores[5] - 1;
            }
            #endregion

            #region Una 1 o 2 por Hoja
            if (Contadores[0] != 0)
            {
                string tipo = "Protocolo Inicial Relacionado";
                CreateWordDocument($"{ruta}F_A1.docx", $"{ruta}" + datosPaciente[5] + "1.docx", Contadores[0], impresora, tipo, medico);
            }
            
            if (Contadores[1] != 0)
            {
                string tipo = "Protocolo Inicial No Relacionado";
                CreateWordDocument($"{ruta}F_A1.docx", $"{ruta}" + datosPaciente[5] + "1.docx", Contadores[1], impresora, tipo, medico);
            }
            
            if (Contadores[2] != 0)
            {
                string tipo = "Servicios";

                int j = 0;

                while (Contadores[2] > 0)
                {
                    if (Contadores[2] > 1)
                    {
                        CreateWordDocument($"{ruta}F3_2.docx", $"{ruta}" + datosPaciente[5] + "_3.docx", j, impresora, tipo, medico);
                        j = j + 2;
                        Contadores[2] = Contadores[2] - 2;
                    }
                    else if (Contadores[2] == 1)
                    {
                        CreateWordDocument($"{ruta}F3.docx", $"{ruta}" + datosPaciente[5] + "3.docx", j, impresora, tipo, medico);
                        Contadores[2] = Contadores[2] - 1;
                    }
                }
            }
            
            if (Contadores[3] != 0)
            {
                string tipo = "Protocolo Inicial (Radiología)";

                notaRadiologia = nota;

                int j = 0;

                while (Contadores[3] > 0)
                {
                    if (Contadores[3] > 1)
                    {
                        CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_2.docx", j, impresora, tipo, medico); 
                        j = j + 2;
                        Contadores[3] = Contadores[3] - 2;
                    }
                    else if (Contadores[3] == 1)
                    {
                        CreateWordDocument($"{ruta}F2.docx", $"{ruta}" + datosPaciente[5] + "2.docx", j, impresora, tipo, medico);
                        Contadores[3] = Contadores[3] - 1;
                    }
                }
            }
            
            if (Contadores[4] != 0)
            {
                string tipo = "2do Protocolo (Radiología)";

                notaRadiologia = nota;

                int j = 0;

                while (Contadores[4] > 0)
                {
                    if (Contadores[4] > 1)
                    {
                        CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_2.docx", j, impresora, tipo, medico);
                        j = j + 2;
                        Contadores[4] = Contadores[4] - 2;
                    }
                    else if (Contadores[4] == 1)
                    {
                        CreateWordDocument($"{ruta}F2.docx", $"{ruta}" + datosPaciente[5] + "2.docx", j, impresora, tipo, medico);
                        Contadores[4] = Contadores[4] - 1;
                    }
                }
            }
            
            if (Contadores[5] != 0)
            {
                string tipo = "Otros";

                int j = 0;

                while (Contadores[5] > 0)
                {
                    if (Contadores[5] > 1)
                    {
                        CreateWordDocument($"{ruta}F_OB1.docx", $"{ruta}" + datosPaciente[5] + "F_OB1.docx", j, impresora, medico, tipo);
                        j = j + 2;
                        Contadores[5] = Contadores[5] - 2;
                    }
                    else if (Contadores[5] == 1)
                    {
                        CreateWordDocument($"{ruta}F_OA1.docx", $"{ruta}" + datosPaciente[5] + "F_OA1.docx", j, impresora, medico, tipo);
                        Contadores[5] = Contadores[5] - 1;
                    }
                }
            }
            #endregion

            return algo;
        }

        public static void CalcularRuta()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory;
            string directoryName = null;
            int i = 0;
            while (i != 4)
            {
                directoryName = Path.GetDirectoryName(filePath);
                filePath = directoryName;
                if (i == 1)
                {
                    filePath = directoryName + @"\";  // this will preserve the previous path
                }
                else { }
                i++;
            }
            ruta = directoryName + @"\Resources\";
        }

        
        
        static public String NuevoFormato(string [] e, string [] d, int y, string comboBox, string tipo, List<string>medico)
        {
            estudiosSeleccionados = e;
            datosPaciente = d;
            return CreateWordDocument($"{ruta}F1.docx", $"{ruta}" + datosPaciente[5] + "4.docx", y, comboBox, tipo, medico);
        }

        static public String NuevoFormato_2(/*string estudioespecial_*/ string[] e, string[] datosdelpaciente, int y, string comboBox, List<string> medico, string tipo)
        {
            //estudioespecial = estudioespecial_;
            estudiosSeleccionados = e;
            datosPaciente = datosdelpaciente;
            for (int i = 0; i < y; i++)
            {
                int j = i;
                CreateWordDocument($"{ruta}F4.docx", $"{ruta}" + datosPaciente[5] + "_4.docx", j, comboBox, medico, tipo);
            }
            return "Formatos Impresos!";
        }
        static public String FormatoServicios(string[] e, string[] d, int y, string comboBox, string tipo, List<string> medico)
        {
            estudiosSeleccionados = e;
            datosPaciente = d;
            
            int j = 0;

            while (y > 0)
            {
                if (y > 1)
                {
                    CreateWordDocument($"{ruta}F3_2.docx", $"{ruta}" + datosPaciente[5] + "_3.docx", j, comboBox, tipo, medico);
                    j = j + 2;
                    y = y - 2;
                }
                else if (y == 1)
                {
                    CreateWordDocument($"{ruta}F3.docx", $"{ruta}" + datosPaciente[5] + "3.docx", j, comboBox, tipo, medico);
                    y = y - 1;
                }
            }

            return "Formatos Impresos!";
        }

        static public String FormatoRadiologia(string[] e, string[] d, int y, string comboBox, string tipo, List<string> medico,bool nota)
        {
            notaRadiologia = nota;
            estudiosSeleccionados = e;
            datosPaciente = d;
            int j = 0;

            while (y > 0)
            {
                if (y > 1)
                {
                    CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_2.docx", j, comboBox, tipo, medico);
                    j = j + 2;
                    y = y - 2;
                }
                else if (y == 1)
                {
                    CreateWordDocument($"{ruta}F2.docx", $"{ruta}" + datosPaciente[5] + "2.docx", j, comboBox, tipo, medico);
                    y = y - 1;
                }
            }
            return "Formatos Impresos!";
        }
        private static void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        private static String CreateWordDocument(object filename, object SaveAs, int cantidaddeestudiosselect, string combobox, string tipo, List<string> medico)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //Encontrar y remplazar daots basicos del paciente
                FindAndReplace(wordApp, "<name>", datosPaciente[1]);
                FindAndReplace(wordApp, "<firstname>", datosPaciente[2]);
                FindAndReplace(wordApp, "<secondname>", datosPaciente[3]);
                FindAndReplace(wordApp, "<cedula>", datosPaciente[5]);
                FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                //Datos basicos del medico
                FindAndReplace(wordApp, "<mname>", medico[1]);
                FindAndReplace(wordApp, "<mfname>", medico[2]);
                FindAndReplace(wordApp, "<msname>", medico[3]);
                FindAndReplace(wordApp, "<matricula>", medico[4]);
                #region Servicios
                //Servicios

                //FindAndReplace(wordApp, "<servicio1>", estudiosSeleccionados[cantidaddeestudiosselect]);
                //FindAndReplace(wordApp, "<servicio2>", estudiosSeleccionados[cantidaddeestudiosselect + 1]);

                //Lista para servicios iniciales
                if (tipo == "Servicios")
                {
                    FindAndReplace(wordApp, "<servicio1>", ListaServicios[cantidaddeestudiosselect]);
                    try
                    {
                        FindAndReplace(wordApp, "<servicio2>", ListaServicios[cantidaddeestudiosselect + 1]);

                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<servicio2>", "");
                    }
                    
                }
                //------------//
                #endregion
                #region Radiologia
                //Radiologogia 1 en una hoja

                //FindAndReplace(wordApp, "<Tipo>", tipo);
                //FindAndReplace(wordApp, "<Anotaciones>", estudiosSeleccionados[cantidaddeestudiosselect]);

                //Lista para radiologia inicio
                if (tipo == "Protocolo Inicial (Radiología)")
                {
                    //1 en una hoja
                    FindAndReplace(wordApp, "<Tipo>", tipo);
                    FindAndReplace(wordApp, "<Anotaciones>", ListaPIRA[cantidaddeestudiosselect]);
                    //2 en una hoja
                    FindAndReplace(wordApp, "<Tipo2>", tipo);

                    try
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", ListaPIRA[cantidaddeestudiosselect + 1]);
                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", "");
                    }
                }

                //Lista para radiologia inicio
                if (tipo == "2do Protocolo (Radiología)")
                {
                    //1 en una hoja
                    FindAndReplace(wordApp, "<Tipo>", tipo);
                    FindAndReplace(wordApp, "<Anotaciones>", ListaSPRA[cantidaddeestudiosselect]);
                    //2 en una hoja
                    FindAndReplace(wordApp, "<Tipo2>", tipo);

                    try
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", ListaSPRA[cantidaddeestudiosselect + 1]);
                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", "");
                    }
                }


                //Nota de impresion en radiologia si esta habilitada el checkbox de paciente
                if (notaRadiologia)
                {
                    FindAndReplace(wordApp, "<nota>", "Impresión diagnóstica: Protocolo de trasplante");
                    FindAndReplace(wordApp, "<nota2>", "Impresión diagnóstica: Protocolo de trasplante");
                }
                else
                {
                    FindAndReplace(wordApp, "<nota>", "");
                    FindAndReplace(wordApp, "<nota2>", "");
                }
                //************************************************************************//
                //Radiologogia 2 en una hoja

                //FindAndReplace(wordApp, "<Tipo2>", tipo);
                //FindAndReplace(wordApp, "<Anotaciones2>", estudiosSeleccionados[cantidaddeestudiosselect + 1]);

                //-------------//
                #endregion
                //Codigo para formato de estudios base clinicos

                //int y = 0;
                //for (int x = 0; x <= 18; x++)
                //{
                //    if (y <= cantidaddeestudiosselect)
                //    {
                //        FindAndReplace(wordApp, $"<ex{x+1}>",estudiosSeleccionados[x]);
                //        y++;
                //    }
                //    else
                //    {
                //        FindAndReplace(wordApp, $"<ex{x+1}>", "");
                //    }
                //}

                //Lista Estudios Clinicos
                if (tipo == "Protocolo Inicial Relacionado")
                {
                    int q = 0;
                    for (int x = 0; x <= 18; x++)
                    {
                        if (q <= cantidaddeestudiosselect-1)
                        {
                            FindAndReplace(wordApp, $"<ex{x+1}>", ListaPIR[x]);
                            q++;
                        }
                        else
                        {
                            FindAndReplace(wordApp, $"<ex{x+1}>", "");
                        }
                    }
                }
                if (tipo == "Protocolo Inicial No Relacionado")
                {
                    int q = 0;
                    for (int x = 0; x <= 18; x++)
                    {
                        if (q <= cantidaddeestudiosselect-1)
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", ListaPINR[x]);
                            q++;
                        }
                        else
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", "");
                        }
                    }
                }
                //----------------------------------------------//
            }
            else
            {
                return ("Archivo no encontrado!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            //-----------------------------------------------------//
            wordApp.ActivePrinter =combobox;
            //Codigo para impresion de formatos y asi.
            if (myWordDoc != null)
            {
                //object copies = "1";
                //object pages = "";
                //object range = Word.WdPrintOutRange.wdPrintAllDocument;
                //object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                //object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                //object oTrue = true;
                //object oFalse = false;
                //myWordDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                //                   ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                //                   ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintSelection;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintOddPagesOnly;
                object oTrue = true;
                object oFalse = false;
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref missing, ref missing, ref missing, ref missing,
                                   ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                   ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            }

            myWordDoc.Close();
            wordApp.Quit();

            File.Delete(SaveAs.ToString());

            return ("Formato Impreso!");
        }

        private static String CreateWordDocument(object filename, object SaveAs, int y, string combobox, List<string> medico, string tipo)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //Encontrar y remplazar daots basicos del paciente
                FindAndReplace(wordApp, "<name>", datosPaciente[1]);
                FindAndReplace(wordApp, "<firstname>", datosPaciente[2]);
                FindAndReplace(wordApp, "<secondname>", datosPaciente[3]);
                FindAndReplace(wordApp, "<cedula>", datosPaciente[5]);
                FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                //Datos basicos del medico
                FindAndReplace(wordApp, "<mname>", medico[1]);
                FindAndReplace(wordApp, "<mfname>", medico[2]);
                FindAndReplace(wordApp, "<msname>", medico[3]);
                FindAndReplace(wordApp, "<matricula>", medico[4]);
                //Codigo para formato de estudios base clinicos por lista
                if (tipo == "Otros")
                {
                    FindAndReplace(wordApp, "<ex1>", ListaOtros[y]);
                    try
                    {
                        FindAndReplace(wordApp, "<2ex1>", ListaOtros[y+1]);
                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<2ex1>", "");
                    }
                }
            }
            else
            {
                return ("Archivo no encontrado!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            //-----------------------------------------------------//
            wordApp.ActivePrinter = combobox;
            //Codigo para impresion de formatos y asi.
            if (myWordDoc != null)
            {
                object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintSelection;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintOddPagesOnly;
                object oTrue = true;
                object oFalse = false;
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref missing, ref missing, ref missing, ref missing,
                                   ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                   ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            }

            myWordDoc.Close();
            wordApp.Quit();

            File.Delete(SaveAs.ToString());

            return ("Formato Impreso!");
        }

        private static String CreateWordDocument(object filename, object SaveAs, int y, int w , string combobox, List<string> medico, string tipo1, string tipo2)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //Encontrar y remplazar daots basicos del paciente
                FindAndReplace(wordApp, "<name>", datosPaciente[1]);
                FindAndReplace(wordApp, "<firstname>", datosPaciente[2]);
                FindAndReplace(wordApp, "<secondname>", datosPaciente[3]);
                FindAndReplace(wordApp, "<cedula>", datosPaciente[5]);
                FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                //Datos basicos del medico
                FindAndReplace(wordApp, "<mname>", medico[1]);
                FindAndReplace(wordApp, "<mfname>", medico[2]);
                FindAndReplace(wordApp, "<msname>", medico[3]);
                FindAndReplace(wordApp, "<matricula>", medico[4]);

                //Lista Estudios Clinicos
                #region Tipos 1
                if (tipo1 == "Protocolo Inicial Relacionado")
                {
                    int q = 0;
                    for (int x = 0; x <= 18; x++)
                    {
                        if (q <= y - 1)
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", ListaPIR[x]);
                            q++;
                        }
                        else
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", "");
                        }
                    }
                }

                if (tipo1 == "Protocolo Inicial No Relacionado")
                {
                    int q = 0;
                    for (int x = 0; x <= 18; x++)
                    {
                        if (q <= y - 1)
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", ListaPINR[x]);
                            q++;
                        }
                        else
                        {
                            FindAndReplace(wordApp, $"<ex{x + 1}>", "");
                        }
                    }
                }

                if (tipo1 == "Protocolo Inicial (Radiología)")
                {
                    FindAndReplace(wordApp, "<Tipo>", tipo1);
                    FindAndReplace(wordApp, "<Anotaciones>", ListaPIRA[y-1]);
                }

                if (tipo1 == "2do Protocolo (Radiología)")
                {
                    FindAndReplace(wordApp, "<Tipo>", tipo1);
                    FindAndReplace(wordApp, "<Anotaciones>", ListaSPRA[y - 1]);
                }

                if (tipo1 == "Otros")
                {
                    FindAndReplace(wordApp, "<ex1>", ListaOtros[w - 1]);
                }
                #endregion

                #region Tipos 2
                if (tipo2 == "Protocolo Inicial No Relacionado")
                {
                    int q = 0;
                    for (int x = 0; x <= 18; x++)
                    {
                        if (q <= w - 1)
                        {
                            FindAndReplace(wordApp, $"<2ex{x + 1}>", ListaPINR[x]);
                            q++;
                        }
                        else
                        {
                            FindAndReplace(wordApp, $"<2ex{x + 1}>", "");
                        }
                    }
                }

                if (tipo2 == "Protocolo Inicial (Radiología)")
                {
                    FindAndReplace(wordApp, "<Tipo>", tipo2);
                    FindAndReplace(wordApp, "<Anotaciones>", ListaPIRA[w - 1]);
                }

                if (tipo2 == "Servicios")
                {
                    FindAndReplace(wordApp, "<servicio1>", ListaServicios[w-1]);
                }

                if (tipo2 == "2do Protocolo (Radiología)")
                {
                    FindAndReplace(wordApp, "<Tipo>", tipo2);
                    try
                    {
                        FindAndReplace(wordApp, "<Anotaciones>", ListaSPRA[w - 1]);
                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<Anotaciones>", "");
                        throw;
                    }
                    FindAndReplace(wordApp, "<Tipo2>", tipo2);
                    try
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", ListaSPRA[w - 1]);
                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<Anotaciones2>", "");
                        throw;
                    }
                }

                if (tipo2 == "Otros")
                {
                    FindAndReplace(wordApp, "<2ex1>", ListaOtros[w-1]);
                }
                #endregion

                if (notaRadiologia)
                {
                    FindAndReplace(wordApp, "<nota>", "Impresión diagnóstica: Protocolo de trasplante");
                    FindAndReplace(wordApp, "<nota2>", "Impresión diagnóstica: Protocolo de trasplante");
                }
                else
                {
                    FindAndReplace(wordApp, "<nota>", "");
                    FindAndReplace(wordApp, "<nota2>", "");
                }

            }
            else
            {
                return ("Archivo no encontrado!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            //-----------------------------------------------------//
            wordApp.ActivePrinter = combobox;
            //Codigo para impresion de formatos y asi.
            if (myWordDoc != null)
            {
                object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintSelection;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintOddPagesOnly;
                object oTrue = true;
                object oFalse = false;
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref missing, ref missing, ref missing, ref missing,
                                   ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                   ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            }

            myWordDoc.Close();
            wordApp.Quit();

            File.Delete(SaveAs.ToString());

            return ("Formato Impreso!");
        }


    }
}
