using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class AD_ConexionMySQL
    {
        //protected MySqlConnection GetMySqlConnection()//Para el Logion
        //{
        //    return new MySqlConnection(@"server=localhost;database=Pacientespretrasplante;user id=root;Integrated Security=True;");
        //}

        //private MySqlConnection connection = new MySqlConnection(@"server=localhost;database=Pacientespretrasplante;user id=root;Integrated Security=True;");

        ////Metodo publico para abrir conexion
        //public MySqlConnection AbrirConexion()
        //{
        //    //if (connection.State.ToString()=="Close")
        //    connection.Open();
        //    return connection;
        //}
        ////Metodo publico para cerrar conexion
        //public MySqlConnection CerrarConexion()
        //{
        //    //if (connection.State.ToString()=="Open")
        //    connection.Close();
        //    return connection;
        //}
    }
}
