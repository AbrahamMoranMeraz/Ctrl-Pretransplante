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
        string usuario;

        public Blanco(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public Blanco()
        {
            InitializeComponent();
        }

        private void Blanco_Load(object sender, EventArgs e)
        {
            Capa_Negocio.CN_Paciente datos = new Capa_Negocio.CN_Paciente();
            labelUsuario.Text = datos.UsuarioActual(usuario);
        }

        private void Blanco_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
