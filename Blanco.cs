using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_PreTransplante_V2
{
    public partial class Blanco : Form
    {
        public Blanco()
        {
            InitializeComponent();
        }

        private void Blanco_Load(object sender, EventArgs e)
        {
            Inicio formulario = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Inicio))
                {
                    formulario = (Inicio)frm;
                    break;
                }
                else { }
            }
            Capa_Negocio.CN_Paciente datos = new Capa_Negocio.CN_Paciente();
            labelUsuario.Text = datos.UsuarioActual(formulario.UsuarioActual);
        }

        private void Blanco_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
