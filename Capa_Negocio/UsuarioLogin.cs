using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_AccesoDatos
{
    public class UsuarioLogin
    {
        DatosUsuario usuari1 = new DatosUsuario();

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuari1.Logi_Us(usuario, pass);
        }
    }
}
