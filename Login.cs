using Capa_AccesoDatos;
using FontAwesome.Sharp;
using Spire.Spreadsheet.Forms.Utility;
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
    public partial class Login : Form
    {
        //Logica_Secion secion;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Login_();
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txt_usuario.Clear();
            txt_contra.Clear();
            this.Show();
        }
        private void txt_contra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Login_();
            }
            else
            {

            }
        }

        private void Login_()
        {
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Llenar el campo de usuario");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_contra.Text))
                {
                    MessageBox.Show("Llenar el campo de contraseña");
                    return;
                }
                else
                {
                    UsuarioLogin loginUsuario = new UsuarioLogin();
                    var validacion = loginUsuario.LoginUsuario(txt_usuario.Text, txt_contra.Text);
                    if (validacion == true)
                    {
                        
                        Inicio mostrarInicio = new Inicio(txt_usuario.Text);
                        mostrarInicio.Show();
                        mostrarInicio.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        txt_contra.Clear();
                        txt_usuario.Clear();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_usuario.Focus();
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_();
            }
            else
            {

            }
        }

        private void txt_contra_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_();
            }
            else
            {

            }
        }

        private void txt_usuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_();
            }
            else
            {

            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
