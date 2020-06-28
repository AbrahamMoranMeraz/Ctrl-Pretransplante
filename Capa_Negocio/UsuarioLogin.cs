using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<string> matricula = new List<string>();
            DataTable tablab = Acceso.Matricula(user);
            DataRow row = tablab.Rows[0];

            foreach (var item in row.ItemArray)
            {
                matricula.Add(item.ToString());
            }
            tablab = Acceso.MedicoDatos(matricula[0]);
            DataRow row2 = tablab.Rows[1];

            foreach (var item in row2.ItemArray)
            {
                datosmed.Add(item.ToString());
            }

            return datosmed;
        }
    }
}
