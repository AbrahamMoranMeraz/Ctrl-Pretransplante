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

namespace Capa_Negocio
{
    public static class Generar_Formato
    {
        #region Variables
        static String[] estudiosSeleccionados;
        static String[] datosPaciente;
        static bool notaRadiologia;//Nota de impresio validacion
        static string ruta;
        //static string estudioespecial;
        #endregion

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

        static public String NuevoFormato_2(/*string estudioespecial_*/ string[] e, string[] datosdelpaciente, int y, string comboBox, List<string> medico)
        {
            //estudioespecial = estudioespecial_;
            estudiosSeleccionados = e;
            datosPaciente = datosdelpaciente;
            for (int i = 0; i < y; i++)
            {
                int j = i;
                CreateWordDocument($"{ruta}F4.docx", $"{ruta}" + datosPaciente[5] + "_4.docx", j, comboBox, medico);
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
                FindAndReplace(wordApp, "<servicio1>", estudiosSeleccionados[cantidaddeestudiosselect]);
                FindAndReplace(wordApp, "<servicio2>", estudiosSeleccionados[cantidaddeestudiosselect + 1]);
                //------------//
                #endregion
                #region Radiologia
                //Radiologogia 1 en una hoja
                FindAndReplace(wordApp, "<Tipo>", tipo);
                FindAndReplace(wordApp, "<Anotaciones>", estudiosSeleccionados[cantidaddeestudiosselect]);
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
                FindAndReplace(wordApp, "<Tipo2>", tipo);
                FindAndReplace(wordApp, "<Anotaciones2>", estudiosSeleccionados[cantidaddeestudiosselect + 1]);
                //-------------//
                #endregion
                //Codigo para formato de estudios base clinicos
                int y = 0;
                for (int x = 0; x <= 18; x++)
                {
                    if (y <= cantidaddeestudiosselect)
                    {
                        FindAndReplace(wordApp, $"<ex{x+1}>",estudiosSeleccionados[x]);
                        y++;
                    }
                    else
                    {
                        FindAndReplace(wordApp, $"<ex{x+1}>", "");
                    }
                }
            }
            else
            {
                return ("File not Found!");
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

        private static String CreateWordDocument(object filename, object SaveAs, int y, string combobox, List<string> medico)
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
                //Codigo para formato de estudios base clinicos
                FindAndReplace(wordApp, "<ex1>", estudiosSeleccionados[y]);
            }
            else
            {
                return ("File not Found!");
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
