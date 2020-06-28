namespace Control_PreTransplante_V2
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnrestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.btnmaximisar = new FontAwesome.Sharp.IconPictureBox();
            this.btnminimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btncerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btncerrarsecion = new FontAwesome.Sharp.IconButton();
            this.panelsubmenupaciente = new System.Windows.Forms.Panel();
            this.btnnuevop = new FontAwesome.Sharp.IconButton();
            this.btnlista = new FontAwesome.Sharp.IconButton();
            this.btnpaciente = new FontAwesome.Sharp.IconButton();
            this.btninicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.iconButtonEstudios = new FontAwesome.Sharp.IconButton();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.panelsubmenupaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.paneltitulo.Controls.Add(this.btnrestaurar);
            this.paneltitulo.Controls.Add(this.btnmaximisar);
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1040, 32);
            this.paneltitulo.TabIndex = 0;
            this.paneltitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDoubleClick);
            this.paneltitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseMove);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnrestaurar.IconColor = System.Drawing.Color.White;
            this.btnrestaurar.IconSize = 23;
            this.btnrestaurar.Location = new System.Drawing.Point(980, 5);
            this.btnrestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(26, 23);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnrestaurar.TabIndex = 5;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.restaurar_Click);
            this.btnrestaurar.MouseEnter += new System.EventHandler(this.btnrestaurar_MouseEnter);
            this.btnrestaurar.MouseLeave += new System.EventHandler(this.btnrestaurar_MouseLeave);
            // 
            // btnmaximisar
            // 
            this.btnmaximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.btnmaximisar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnmaximisar.IconColor = System.Drawing.Color.White;
            this.btnmaximisar.IconSize = 23;
            this.btnmaximisar.Location = new System.Drawing.Point(980, 5);
            this.btnmaximisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmaximisar.Name = "btnmaximisar";
            this.btnmaximisar.Size = new System.Drawing.Size(26, 23);
            this.btnmaximisar.TabIndex = 4;
            this.btnmaximisar.TabStop = false;
            this.btnmaximisar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnmaximisar.MouseEnter += new System.EventHandler(this.btnmaximisar_MouseEnter);
            this.btnmaximisar.MouseLeave += new System.EventHandler(this.btnmaximisar_MouseLeave);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnminimizar.IconColor = System.Drawing.Color.White;
            this.btnminimizar.IconSize = 21;
            this.btnminimizar.Location = new System.Drawing.Point(956, 5);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(21, 23);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnminimizar.TabIndex = 0;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.label2_Click);
            this.btnminimizar.MouseEnter += new System.EventHandler(this.btnminimizar_MouseEnter);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncerrar.IconColor = System.Drawing.Color.White;
            this.btncerrar.IconSize = 23;
            this.btncerrar.Location = new System.Drawing.Point(1012, 5);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(26, 23);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.label1_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(162)))), ((int)(((byte)(110)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 20);
            this.panel1.TabIndex = 1;
            // 
            // panelmenu
            // 
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.panelmenu.Controls.Add(this.iconButtonEstudios);
            this.panelmenu.Controls.Add(this.btncerrarsecion);
            this.panelmenu.Controls.Add(this.panelsubmenupaciente);
            this.panelmenu.Controls.Add(this.btnpaciente);
            this.panelmenu.Controls.Add(this.btninicio);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 52);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(214, 588);
            this.panelmenu.TabIndex = 3;
            this.panelmenu.MouseLeave += new System.EventHandler(this.panelmenu_MouseLeave);
            // 
            // btncerrarsecion
            // 
            this.btncerrarsecion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncerrarsecion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncerrarsecion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncerrarsecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncerrarsecion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncerrarsecion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btncerrarsecion.IconColor = System.Drawing.Color.White;
            this.btncerrarsecion.IconSize = 30;
            this.btncerrarsecion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsecion.Location = new System.Drawing.Point(0, 522);
            this.btncerrarsecion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncerrarsecion.Name = "btncerrarsecion";
            this.btncerrarsecion.Rotation = 0D;
            this.btncerrarsecion.Size = new System.Drawing.Size(214, 66);
            this.btncerrarsecion.TabIndex = 0;
            this.btncerrarsecion.Text = "Cerrar Sesión";
            this.btncerrarsecion.UseVisualStyleBackColor = true;
            this.btncerrarsecion.Click += new System.EventHandler(this.btncerrarsecion_Click);
            // 
            // panelsubmenupaciente
            // 
            this.panelsubmenupaciente.Controls.Add(this.btnnuevop);
            this.panelsubmenupaciente.Controls.Add(this.btnlista);
            this.panelsubmenupaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenupaciente.Location = new System.Drawing.Point(0, 210);
            this.panelsubmenupaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelsubmenupaciente.Name = "panelsubmenupaciente";
            this.panelsubmenupaciente.Size = new System.Drawing.Size(214, 76);
            this.panelsubmenupaciente.TabIndex = 3;
            this.panelsubmenupaciente.MouseLeave += new System.EventHandler(this.panelsubmenupaciente_MouseLeave);
            // 
            // btnnuevop
            // 
            this.btnnuevop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnuevop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnnuevop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnnuevop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnnuevop.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnnuevop.IconColor = System.Drawing.Color.White;
            this.btnnuevop.IconSize = 30;
            this.btnnuevop.Location = new System.Drawing.Point(0, 37);
            this.btnnuevop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnuevop.Name = "btnnuevop";
            this.btnnuevop.Rotation = 0D;
            this.btnnuevop.Size = new System.Drawing.Size(214, 37);
            this.btnnuevop.TabIndex = 4;
            this.btnnuevop.Text = "Nuevo Paciente";
            this.btnnuevop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevop.UseVisualStyleBackColor = true;
            this.btnnuevop.Click += new System.EventHandler(this.btnnuevop_Click);
            // 
            // btnlista
            // 
            this.btnlista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlista.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlista.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnlista.IconColor = System.Drawing.Color.White;
            this.btnlista.IconSize = 30;
            this.btnlista.Location = new System.Drawing.Point(0, 0);
            this.btnlista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlista.Name = "btnlista";
            this.btnlista.Rotation = 0D;
            this.btnlista.Size = new System.Drawing.Size(214, 37);
            this.btnlista.TabIndex = 3;
            this.btnlista.Text = "Lista Pacientes";
            this.btnlista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // btnpaciente
            // 
            this.btnpaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpaciente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnpaciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btnpaciente.IconColor = System.Drawing.Color.White;
            this.btnpaciente.IconSize = 30;
            this.btnpaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpaciente.Location = new System.Drawing.Point(0, 173);
            this.btnpaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnpaciente.Rotation = 0D;
            this.btnpaciente.Size = new System.Drawing.Size(214, 37);
            this.btnpaciente.TabIndex = 3;
            this.btnpaciente.Text = "Paciente";
            this.btnpaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpaciente.UseVisualStyleBackColor = true;
            this.btnpaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninicio
            // 
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btninicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btninicio.IconColor = System.Drawing.Color.White;
            this.btninicio.IconSize = 35;
            this.btninicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.Location = new System.Drawing.Point(0, 136);
            this.btninicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninicio.Name = "btninicio";
            this.btninicio.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btninicio.Rotation = 0D;
            this.btninicio.Size = new System.Drawing.Size(214, 37);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "Inicio";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Control_PreTransplante_V2.Properties.Resources.logo_imss;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelcentral);
            this.panelContenedor.Controls.Add(this.panelmenu);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.paneltitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1040, 640);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.White;
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelcentral.Location = new System.Drawing.Point(214, 52);
            this.panelcentral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(826, 588);
            this.panelcentral.TabIndex = 4;
            this.panelcentral.MouseEnter += new System.EventHandler(this.panelcentral_MouseEnter);
            // 
            // iconButtonEstudios
            // 
            this.iconButtonEstudios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonEstudios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonEstudios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButtonEstudios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonEstudios.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonEstudios.IconColor = System.Drawing.Color.White;
            this.iconButtonEstudios.IconSize = 30;
            this.iconButtonEstudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEstudios.Location = new System.Drawing.Point(0, 456);
            this.iconButtonEstudios.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonEstudios.Name = "iconButtonEstudios";
            this.iconButtonEstudios.Rotation = 0D;
            this.iconButtonEstudios.Size = new System.Drawing.Size(214, 66);
            this.iconButtonEstudios.TabIndex = 4;
            this.iconButtonEstudios.Text = "Editar Estudios";
            this.iconButtonEstudios.UseVisualStyleBackColor = true;
            this.iconButtonEstudios.Click += new System.EventHandler(this.iconButtonEstudios_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1023, 590);
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelsubmenupaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private FontAwesome.Sharp.IconPictureBox btnrestaurar;
        private FontAwesome.Sharp.IconPictureBox btnmaximisar;
        private FontAwesome.Sharp.IconPictureBox btnminimizar;
        private FontAwesome.Sharp.IconPictureBox btncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton btncerrarsecion;
        private System.Windows.Forms.Panel panelsubmenupaciente;
        private FontAwesome.Sharp.IconButton btnnuevop;
        private FontAwesome.Sharp.IconButton btnlista;
        private FontAwesome.Sharp.IconButton btnpaciente;
        private FontAwesome.Sharp.IconButton btninicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.Panel panelcentral;
        private FontAwesome.Sharp.IconButton iconButtonEstudios;
    }
}

