using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class ConexionSQL
    {
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-D8KS8FVM;Initial Catalog=SistemaPretrasplante;Integrated Security=True");
        }
        private SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-D8KS8FVM;Initial Catalog=SistemaPretrasplante;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
