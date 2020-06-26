using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_AccesoDatos
{
    public class UsuarioLogin
    {
        string matricula = "";
        DatosUsuario usuari1 = new DatosUsuario();
        Acceso_Datos Acceso = new Acceso_Datos();

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuari1.Logi_Us(usuario, pass);
        }

        //public void Matricula(string usuario)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Acceso.Matricula(usuario);
        //    for (int x = 0; x < tabla.Rows.Count; x++)
        //    {
        //        matricula = (tabla.Rows[x].ItemArray[0].ToString());
        //    }
        //}

        //public DataTable DatosMed()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Acceso.MedicoDatos(matricula);
        //    return tabla;
        //}

        //public void DatosMedico()
        //{
        //    DataTable tabla = new DataTable();
        //    string[] Medico = new string[4];
        //    tabla = Acceso_Datos.MedicoDatos(matricula);
        //    for (int x = 0; x < tabla.Rows.Count; x++)
        //    {
        //        Medico[x] = (tabla.Rows[x].ItemArray[0].ToString());
        //    }

        //    int i = 0;

        //    foreach (DataRow row in tabla.Rows)
        //    {
        //        foreach (var item in row.ItemArray)
        //        {
        //            Medico[i] = item.ToString();
        //            i++;
        //        }
        //    }
        //}
    }
}
