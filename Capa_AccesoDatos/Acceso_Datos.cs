using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Acceso_Datos : AD_ConexionMySQL
    {
        private ConexionSQL conexion = new ConexionSQL();
        SqlDataReader leerdatos;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void GuardarNuevoEstudio(string nombre, int categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarEstudioNuevo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreEst ", nombre);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }

        public void BorraEstudio(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BorrarEstudio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreEst", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }

        public DataTable Matricula(string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "IDoctor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario);
            SqlDataReader t = comando.ExecuteReader();
            tabla.Load(t);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MedicoDatos(string matricula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InfoDoc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula_", matricula);
            SqlDataReader t = comando.ExecuteReader();
            tabla.Load(t);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDatos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Paciente";
            //comando.CommandType = CommandType.StoredProcedure;
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDatos(int idpaciente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EstudiosdelPaciente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDPaciente", idpaciente);
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Vistas(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from " + nombre;
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarDatos(string num_seg, string curp1, string nom, string ap, string am, string sex, string nac)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDatosPaciente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_ ", nom);
            comando.Parameters.AddWithValue("@ApellidoP_", ap);
            comando.Parameters.AddWithValue("@ApellidoM_", am);
            comando.Parameters.AddWithValue("@CURP_", curp1);
            comando.Parameters.AddWithValue("@Num_Social_ ", num_seg);
            comando.Parameters.AddWithValue("@fechaNa_", nac);
            comando.Parameters.AddWithValue("@Sexo_ ", sex);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarDatos(string num_seg, string curp1, string nom, string ap, string am, string sex, string nac, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDatosPaciente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Num_Social_", num_seg);
            comando.Parameters.AddWithValue("@CURP_", curp1);
            comando.Parameters.AddWithValue("@Nombre_", nom);
            comando.Parameters.AddWithValue("@ApellidoP_", ap);
            comando.Parameters.AddWithValue("@ApellidoM_", am);
            comando.Parameters.AddWithValue("@Sexo_ ", sex);
            comando.Parameters.AddWithValue("@fechaNa_", nac);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EliminarDatos(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDatosPaciente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarEstudios(int idpaciente, string nombre, string matricula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEstudiosP";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdPaciente", idpaciente);
            comando.Parameters.AddWithValue("@NombreE", nombre);
            comando.Parameters.AddWithValue("@mat", matricula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.CerrarConexion();
        }
        
        public String UsuarioActual(string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "NombreUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_", usuario);
            SqlDataReader t = comando.ExecuteReader();
            tabla.Load(t);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla.Rows[0]["Nombre"].ToString() +" "+ tabla.Rows[0]["ApellidoP"].ToString()+" "+ tabla.Rows[0]["ApellidoM"].ToString();
        }
    }
}
