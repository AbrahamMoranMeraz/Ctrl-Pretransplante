using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class DatosUsuario : ConexionSQL
    {
        public bool Logi_Us(string usuario, string pass)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from UsuarioDoctor where Usuario=@usuario and Contraseña=@contra";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contra", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)//Obtiene un valor que especifica si existe
                    {
                        return true;//Si existe retorna true
                    }
                    else
                    {
                        return false;//Si no existe retorna false
                    }
                }
            }
        }
    }

}
