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

        public DataTable Matricula(string user)
        {
            DataTable tabla = new DataTable();
            tabla = Acceso.Matricula(user);
            return tabla;
        }

        public DataTable DatosMed(string matricula)
        {
            DataTable tabla = new DataTable();
            tabla = Acceso.MedicoDatos(matricula);
            return tabla;
        }
    }
}
