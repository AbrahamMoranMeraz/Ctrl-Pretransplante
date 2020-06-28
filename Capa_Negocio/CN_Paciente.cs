using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class CN_Paciente
    {
        private Acceso_Datos objPaciente = new Acceso_Datos();
        public DataTable MostrarPaci()
        {
            return objPaciente.MostrarDatos();
        }

        public DataTable Estudios(string nss)
        {
            try
            {
                return objPaciente.MostrarDatos(nss);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable Vistas(string nombrevista)
        {
            try
            {
                return objPaciente.Vistas(nombrevista);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void GuardaEstudio(string nombre, int categoria)
        {
            objPaciente.GuardarNuevoEstudio(nombre, categoria);
        }

        public void BorrarEstudio(string nombre)
        {
            objPaciente.BorraEstudio(nombre);
        }

        public void Insertar(string num_seg, string curp1, string nom, string ap, string am, string sex, string nac)
        {
            objPaciente.InsertarDatos(num_seg, curp1, nom, ap, am, sex, nac);
        }
        public void Editar(string num_seg, string curp1, string nom, string ap, string am, string sex, string nac, string id)
        {
            objPaciente.EditarDatos(num_seg, curp1, nom, ap, am, sex, nac, Convert.ToInt16(id));
        }
        public void EliminarProd(string id)
        {
            objPaciente.EliminarDatos(Convert.ToInt16(id));
        }

        public void InsertarStudios(string num_seg, string nombre, string matricula)
        {
            objPaciente.InsertarEstudios(num_seg, nombre, matricula);
        }

        public String UsuarioActual(string usuario)
        {
           return objPaciente.UsuarioActual(usuario);
        }

    }
}
