using Capa_AccesoDatos;
using FontAwesome.Sharp;
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
            txt_contra.Focus();
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
                        //DataTable tabla = new DataTable();
                        //tabla = loginUsuario.Matricula(txt_usuario.Text);
                        //string matricula="";
                        //for (int x = 0; x < tabla.Rows.Count; x++)
                        //{
                        //    matricula = (tabla.Rows[x].ItemArray[0].ToString());
                        //}

                        //tabla = loginUsuario.DatosMed(matricula);

                        //string[] medicodatos = new string[4];
                        //int i = 0;
                        //foreach (DataRow row in tabla.Rows)
                        //{
                        //    foreach (var item in row.ItemArray)
                        //    {
                        //        medicodatos[i] = item.ToString();
                        //        i++;
                        //    }
                        //}

                        //Paciente paciente = new Paciente(medicodatos);

                        Inicio mostrarInicio = new Inicio();
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
    }
}
