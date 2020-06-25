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

        public DataTable MostrarDatos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Paciente";
            //comando.CommandType = CommandType.StoredProcedure;
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDatos(string consulta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = consulta;
            //comando.CommandType = CommandType.StoredProcedure;
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
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
            comando.Parameters.AddWithValue("@Donador_", 0);
            comando.Parameters.AddWithValue("@fechaNa_", nac);
            comando.Parameters.AddWithValue("@Sexo_ ", sex);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
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
        }
        public void EliminarDatos(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDatosPaciente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void InsertarEstudios(string nss, int idformato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEstudios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NSS_", nss);
            comando.Parameters.AddWithValue("@Idformato_", idformato);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        } 

    }
}
