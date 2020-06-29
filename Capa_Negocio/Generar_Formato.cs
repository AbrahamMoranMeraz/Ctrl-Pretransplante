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

        //provisional
        static List<int> Contadores;

        static List<string> ListaPIR;//Protocolo Inicial Relacionado
        static List<string> ListaPINR;//Protocolo Inicial No Relacionado
        static List<string> ListaSPI;//Protocolo Inicial (Servicios)
        static List<string> ListaS2P;//2do Protocolo (Servicios)
        static List<string> ListaOS;//Otros (Servicios)
        static List<string> ListaPIRA;//Protocolo Inicial (Radiología)
        static List<string> ListaSPRA;//2do Protocolo (Radiología)
        static List<string> ListaPREOP;//PREOPERATORIOS
        static List<string> ListaDONA;//DONADOR
        static List<string> ListaESPEC;//ESPECIALES

        //static DataTable listaN;
        //***************************//
        //static string estudioespecial;
        #endregion

        static public String ImpresioEnLista(string impresora, List<string> medico, string [] paciente, List<int> MisContadores, 
        List<string> lista1, List<string> lista2, List<string> lista3, List<string> lista4, List<string> lista5, List<string> lista6,
        List<string> lista7, List<string> lista8, List<string> lista9, List<string> lista10, bool nota)
        {
            Contadores = MisContadores;
            ListaPIR = lista1;
            ListaPINR = lista2;
            ListaSPI = lista3;
            ListaS2P = lista4;
            ListaOS = lista5;
            ListaPIRA = lista6;
            ListaSPRA = lista7;
            ListaPREOP = lista8;
            ListaDONA = lista9;
            ListaESPEC = lista10;

            datosPaciente = paciente;

            string algo = "Archivos Impresos!";
            
            if (Contadores[0] != 0)
            {
                string tipo = "Protocolo Inicial Relacionado";
                CreateWordDocument($"{ruta}F1.docx", $"{ruta}" + datosPaciente[5] + "1.docx", Contadores[0], impresora, tipo, medico);
            }
            else
            if (Contadores[1] != 0)
            {
                string tipo = "Protocolo Inicial No Relacionado";
                CreateWordDocument($"{ruta}F1.docx", $"{ruta}" + datosPaciente[5] + "1.docx", Contadores[1], impresora, tipo, medico);
            }
            else
            if (Contadores[2] != 0)
            {
                string tipo = "Protocolo Inicial (Servicios)";

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
            else
            if (Contadores[3] != 0)
            {
                string tipo = "2do Protocolo (Servicios)";

                int j = 0;

                while (Contadores[3] > 0)
                {
                    if (Contadores[3] > 1)
                    {
                        CreateWordDocument($"{ruta}F3_2.docx", $"{ruta}" + datosPaciente[5] + "_3.docx", j, impresora, tipo, medico);
                        j = j + 2;
                        Contadores[3] = Contadores[3] - 2;
                    }
                    else if (Contadores[3] == 1)
                    {
                        CreateWordDocument($"{ruta}F3.docx", $"{ruta}" + datosPaciente[5] + "3.docx", j, impresora, tipo, medico);
                        Contadores[3] = Contadores[3] - 1;
                    }
                }
            }
            else
            if (Contadores[4] != 0)
            {
                string tipo = "Otros (Servicios)";

                int j = 0;

                while (Contadores[4] > 0)
                {
                    if (Contadores[4] > 1)
                    {
                        CreateWordDocument($"{ruta}F3_2.docx", $"{ruta}" + datosPaciente[5] + "_3.docx", j, impresora, tipo, medico);
                        j = j + 2;
                        Contadores[4] = Contadores[4] - 2;
                    }
                    else if (Contadores[4] == 1)
                    {
                        CreateWordDocument($"{ruta}F3.docx", $"{ruta}" + datosPaciente[5] + "3.docx", j, impresora, tipo, medico);
                        Contadores[4] = Contadores[4] - 1;
                    }
                }
            }
            else
            if (Contadores[5] != 0)
            {
                string tipo = "Protocolo Inicial (Radiología)";

                notaRadiologia = nota;

                int j = 0;

                while (Contadores[5] > 0)
                {
                    if (Contadores[5] > 1)
                    {
                        CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_2.docx", j, impresora, tipo, medico); 
                        j = j + 2;
                        Contadores[5] = Contadores[5] - 2;
                    }
                    else if (Contadores[5] == 1)
                    {
                        CreateWordDocument($"{ruta}F2.docx", $"{ruta}" + datosPaciente[5] + "2.docx", j, impresora, tipo, medico);
                        Contadores[5] = Contadores[5] - 1;
                    }
                }
            }
            else
            if (Contadores[6] != 0)
            {
                string tipo = "2do Protocolo (Radiología)";

                notaRadiologia = nota;

                int j = 0;

                while (Contadores[6] > 0)
                {
                    if (Contadores[6] > 1)
                    {
                        CreateWordDocument($"{ruta}F2_2.docx", $"{ruta}" + datosPaciente[5] + "_2.docx", j, impresora, tipo, medico);
                        j = j + 2;
                        Contadores[6] = Contadores[6] - 2;
                    }
                    else if (Contadores[6] == 1)
                    {
                        CreateWordDocument($"{ruta}F2.docx", $"{ruta}" + datosPaciente[5] + "2.docx", j, impresora, tipo, medico);
                        Contadores[6] = Contadores[6] - 1;
                    }
                }
            }
            else
            if (Contadores[7] != 0)
            {
                string tipo = "PREOPERATORIOS";

                notaRadiologia = nota;

                for (int i = 0; i < Contadores[7] ; i++)
                {
                    int j = i;
                    CreateWordDocument($"{ruta}F4.docx", $"{ruta}" + datosPaciente[5] + "_4.docx", j, impresora, medico, tipo);
                }
            }
            else
            if (Contadores[8] != 0)
            {
                string tipo = "DONADOR";

                for (int i = 0; i < Contadores[8]; i++)
                {
                    int j = i;
                    CreateWordDocument($"{ruta}F4.docx", $"{ruta}" + datosPaciente[5] + "_4.docx", j, impresora, medico, tipo);
                }
            }
            else
            if (Contadores[9] != 0)
            {
                string tipo = "ESPECIALES";

                for (int i = 0; i < Contadores[9]; i++)
                {
                    int j = i;
                    CreateWordDocument($"{ruta}F4.docx", $"{ruta}" + datosPaciente[5] + "_4.docx", j, impresora, medico, tipo);
                }
            }
            else
            {
                algo = "No selecciono elementos!";
            }
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
                if (tipo == "Protocolo Inicial (Servicios)")
                {
                    FindAndReplace(wordApp, "<servicio1>", ListaSPI[cantidaddeestudiosselect]);
                    try
                    {
                        FindAndReplace(wordApp, "<servicio2>", ListaSPI[cantidaddeestudiosselect + 1]);

                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<servicio2>", "");
                    }
                    
                }
                //Lista para servicio 2do
                if (tipo == "2do Protocolo (Servicios)")
                {
                    FindAndReplace(wordApp, "<servicio1>", ListaS2P[cantidaddeestudiosselect]);
                    try
                    {
                        FindAndReplace(wordApp, "<servicio2>", ListaS2P[cantidaddeestudiosselect + 1]);

                    }
                    catch (Exception)
                    {
                        FindAndReplace(wordApp, "<servicio2>", "");
                    }

                }

                //Lista para servicio 2do
                if (tipo == "Otros (Servicios)")
                {
                    FindAndReplace(wordApp, "<servicio1>", ListaOS[cantidaddeestudiosselect]);
                    try
                    {
                        FindAndReplace(wordApp, "<servicio2>", ListaOS[cantidaddeestudiosselect + 1]);

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
                object copies = "1";
                object pages = "";
                object range = Word.WdPrintOutRange.wdPrintAllDocument;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
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
                if (tipo == "PREOPERATORIOS")
                {
                    FindAndReplace(wordApp, "<ex1>", ListaPREOP[y]);

                }
                if (tipo == "DONADOR")
                {
                    FindAndReplace(wordApp, "<ex1>", ListaDONA[y]);

                }
                if (tipo == "ESPECIALES")
                {
                    FindAndReplace(wordApp, "<ex1>", ListaESPEC[y]);

                }
                //FindAndReplace(wordApp, "<ex1>", estudiosSeleccionados[y]);
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
                object pages = "";
                object range = Word.WdPrintOutRange.wdPrintAllDocument;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
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
