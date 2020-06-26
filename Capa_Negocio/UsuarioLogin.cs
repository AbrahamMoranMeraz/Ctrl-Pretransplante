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
        DatosUsuario usuari1 = new DatosUsuario();
        Acceso_Datos Acceso = new Acceso_Datos();

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuari1.Logi_Us(usuario, pass);
        }

        public List<string> infomed(string user)
        {
            List<string> datosmed = new List<string>();
            DataTable tabla = new DataTable();
            string matricula="";
            tabla = Acceso.Matricula(user);
            for (int x = 0; x < tabla.Rows.Count; x++)
            {
                matricula = (tabla.Rows[x].ItemArray[0].ToString());
            }
            tabla = Acceso.MedicoDatos(matricula);
            DataRow row = tabla.Rows[1];

            foreach (var item in row.ItemArray)
            {
                datosmed.Add(item.ToString());
            }

            return datosmed;
        }
    }
}
