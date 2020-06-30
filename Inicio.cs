using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Control_PreTransplante_V2
{
    public partial class Inicio : Form
    {
        public string UsuarioActual;
        public Inicio(string text)
        {
            InitializeComponent();
            UsuarioActual = text;
        }
        #region Funcionalidades Formulario

        //Arrarastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salir de la aplicación, ¿estas seguro?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }
        //Captura de posicion y tamaño antes de maximisar
        int lx, ly;
        int sw, sh;

        private void paneltitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void paneltitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnrestaurar.Visible = true;
            btnmaximisar.Visible = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnrestaurar.Visible = true;
            btnmaximisar.Visible = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Paciente>();
            MostrarSubmenu(panelsubmenupaciente);
        }

        private void btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(213, 63, 57);
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(13, 102, 87);
        }

        private void btnrestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(197, 162, 110);
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(13, 102, 87);
        }

        private void btnmaximisar_MouseEnter(object sender, EventArgs e)
        {
            btnmaximisar.BackColor = Color.FromArgb(197, 162, 110);
        }

        private void btnmaximisar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximisar.BackColor = Color.FromArgb(13, 102, 87);
        }

        private void btnminimizar_MouseEnter(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(197, 162, 110);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(13, 102, 87);
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            btnrestaurar.Visible = false;
            btnmaximisar.Visible = true;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void PersonalizarFormulario()//Escondemos todos los submenus
        {
            panelsubmenupaciente.Visible = false;
        }

        private void OcultarSubmenu()
        {
            if(panelsubmenupaciente.Visible == true)
            {
                panelsubmenupaciente.Visible = false;
                PersonalizarFormulario();
            }
            else { }
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            Form formulario;
            formulario = panelcentral.Controls.OfType<Lista_P>().FirstOrDefault();//buscaen la coleccion el formulario
            if(formulario == null)
            {

            }
            else
            {
                formulario.Close();
            }
            OcultarSubmenu();
            AbrirFormulario<Lista_P>();
        }

        private void btnnuevop_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            AbrirFormulario<RgPacientes>();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (UsuarioActual == "Abr06")
            {
                iconButtonEstudios.Enabled = true;
                iconButtonEstudios.Visible = true;
            }
            else
            {
                iconButtonEstudios.Enabled = false;
                iconButtonEstudios.Visible = false;
            }
            OcultarSubmenu();
            AbrirFormulario<Lista_P>();
            AbrirFormulario<RgPacientes>();
            AbrirFormulario<Blanco>();
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }
        #endregion

        public void AbrirFormulario<MiFormulario>() where MiFormulario:Form, new()
        {
            Form formulario;
            formulario = panelcentral.Controls.OfType<MiFormulario>().FirstOrDefault();//buscaen la coleccion el formulario
            //si el formulario/instancia no existe
            if(formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                panelcentral.Controls.Add(formulario);
                panelcentral.Tag = formulario;
                formulario.Dock = DockStyle.Fill;
                panelcentral.Size = formulario.MinimumSize;
                formulario.Show();
                formulario.BringToFront();
            }
            else//Si el formulario existe
            {
                formulario.BringToFront();
            }
        }

        private void panelmenu_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void panelsubmenupaciente_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void panelcentral_MouseEnter(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void iconButtonEstudios_Click(object sender, EventArgs e)
        {
            NuevosEstudiosCate nuevosEstudiosCate = new NuevosEstudiosCate();
            nuevosEstudiosCate.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login formulario = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Login))
                {
                    formulario = (Login)frm;
                    break;
                }
                else { return; }
            }
            formulario.Show();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            AbrirFormulario<Blanco>();
        }

        private void btncerrarsecion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar sesión, ¿estas seguro?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
