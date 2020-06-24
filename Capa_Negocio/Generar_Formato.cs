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
        #endregion

        static public String NuevoFormato(string [] e, string [] d, int y, string comboBox)
        {
            estudiosSeleccionados = e;
            datosPaciente = d;
            return CreateWordDocument(@"E:\Programas TEC\TEC\IS\F1.docx", @"E:\Programas TEC\TEC\IS\" + datosPaciente[5] + "1.docx", y, comboBox);
        }

        static public String FormatoServicios(string[] e, string[] d, int y, string comboBox)
        {
            estudiosSeleccionados = e;
            datosPaciente = d;
            for (int i = 0; i < y; i++)
            {
                int j = i;
                CreateWordDocument(@"E:\Programas TEC\TEC\IS\F3.docx", @"E:\Programas TEC\TEC\IS\" + datosPaciente[5] + "3.docx", j, comboBox);
            }
            return "Files Created!";
        }

        static public String FormatoRadiologia(string[] e, string[] d, int y, string comboBox)
        {
            estudiosSeleccionados = e;
            datosPaciente = d;

            while (y==0)
            {
                if ((y % 2) == 0)
                {//Par
                    CreateWordDocument(@"E:\Programas TEC\TEC\IS\F2_2.docx", @"E:\Programas TEC\TEC\IS\" + datosPaciente[5] + "_2.docx", y, comboBox);
                    y = y - 2;
                }
                else
                {//Impar
                    CreateWordDocument(@"E:\Programas TEC\TEC\IS\F2.docx", @"E:\Programas TEC\TEC\IS\" + datosPaciente[5] + "2.docx", y, comboBox);
                    y = y - 1;
                }
            }
            return "Files Created!";
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

        private static String CreateWordDocument(object filename, object SaveAs, int cantidaddeestudiosselect, string combobox)
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

                //find and replace
                FindAndReplace(wordApp, "<name>", datosPaciente[1]);
                FindAndReplace(wordApp, "<firstname>", datosPaciente[2]);
                FindAndReplace(wordApp, "<secondname>", datosPaciente[3]);
                FindAndReplace(wordApp, "<cedula>", datosPaciente[5]);
                FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                //Servicios
                FindAndReplace(wordApp, "<servicio>", estudiosSeleccionados[cantidaddeestudiosselect]);
                //Radiologogia 1 en una hoja
                FindAndReplace(wordApp, "<Tipo>", estudiosSeleccionados[cantidaddeestudiosselect]);
                FindAndReplace(wordApp, "<Anotaciones>", estudiosSeleccionados[cantidaddeestudiosselect]);
                //Radiologogia 2 en una hoja
                FindAndReplace(wordApp, "<Tipo2>", estudiosSeleccionados[cantidaddeestudiosselect]);
                FindAndReplace(wordApp, "<Anotaciones2>", estudiosSeleccionados[cantidaddeestudiosselect]);
                //------------//
                int y = 0;
                for (int x = 0; x <= 18; x++)
                {
                    if (y <= cantidaddeestudiosselect)
                    {
                        FindAndReplace(wordApp, $"<ex{x}>",estudiosSeleccionados[x]);
                        y++;
                    }
                    else
                    {
                        FindAndReplace(wordApp, $"<ex{x}>", "");
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

            wordApp.ActivePrinter =combobox;
            //Codigo para impresion de formatos y asi.
            //if (myWordDoc != null)
            //if (dialogResult == 1)
            //int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref missing);
            //if (dialogResult == 1)
            if (myWordDoc != null)
            {
                object copies = "1";
                object pages = "";
                object range = Word.WdPrintOutRange.wdPrintAllDocument;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;
                //myWordDoc.PrintOut(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                //                   ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                //                   ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                myWordDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                                   ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                   ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            }

            myWordDoc.Close();
            wordApp.Quit();

            File.Delete(SaveAs.ToString());

            return ("File Created!");
        }


    }
}
