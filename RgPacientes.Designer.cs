namespace Control_PreTransplante_V2
{
    partial class RgPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registrarP = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_femenino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.txt_numseg = new System.Windows.Forms.TextBox();
            this.lbl_apellidoM = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.lbl_numseg = new System.Windows.Forms.Label();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.registrarP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(852, 588);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Paciente";
            // 
            // registrarP
            // 
            this.registrarP.Dock = System.Windows.Forms.DockStyle.Right;
            this.registrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.registrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarP.ForeColor = System.Drawing.Color.Black;
            this.registrarP.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.registrarP.IconColor = System.Drawing.Color.Black;
            this.registrarP.IconSize = 80;
            this.registrarP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registrarP.Location = new System.Drawing.Point(677, 27);
            this.registrarP.Margin = new System.Windows.Forms.Padding(2);
            this.registrarP.Name = "registrarP";
            this.registrarP.Rotation = 0D;
            this.registrarP.Size = new System.Drawing.Size(173, 559);
            this.registrarP.TabIndex = 0;
            this.registrarP.Text = "Registrar";
            this.registrarP.UseVisualStyleBackColor = true;
            this.registrarP.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_femenino);
            this.panel1.Controls.Add(this.rdb_masculino);
            this.panel1.Controls.Add(this.lbl_sexo);
            this.panel1.Controls.Add(this.txt_nombres);
            this.panel1.Controls.Add(this.lbl_apellidoP);
            this.panel1.Controls.Add(this.txt_numseg);
            this.panel1.Controls.Add(this.lbl_apellidoM);
            this.panel1.Controls.Add(this.lbl_nombres);
            this.panel1.Controls.Add(this.txt_curp);
            this.panel1.Controls.Add(this.lbl_numseg);
            this.panel1.Controls.Add(this.lbl_curp);
            this.panel1.Controls.Add(this.txt_apellidoP);
            this.panel1.Controls.Add(this.txt_apellidoM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 559);
            this.panel1.TabIndex = 25;
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_femenino.ForeColor = System.Drawing.Color.Black;
            this.rdb_femenino.Location = new System.Drawing.Point(72, 348);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(115, 28);
            this.rdb_femenino.TabIndex = 38;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            this.rdb_femenino.CheckedChanged += new System.EventHandler(this.rdb_femenino_CheckedChanged);
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Checked = true;
            this.rdb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_masculino.ForeColor = System.Drawing.Color.Black;
            this.rdb_masculino.Location = new System.Drawing.Point(72, 315);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(114, 28);
            this.rdb_masculino.TabIndex = 37;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            this.rdb_masculino.CheckedChanged += new System.EventHandler(this.rdb_masculino_CheckedChanged);
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.ForeColor = System.Drawing.Color.Black;
            this.lbl_sexo.Location = new System.Drawing.Point(10, 318);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(45, 20);
            this.lbl_sexo.TabIndex = 36;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(182, 43);
            this.txt_nombres.MaximumSize = new System.Drawing.Size(376, 30);
            this.txt_nombres.MaxLength = 30;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.ShortcutsEnabled = false;
            this.txt_nombres.Size = new System.Drawing.Size(159, 29);
            this.txt_nombres.TabIndex = 27;
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidoP.Location = new System.Drawing.Point(10, 98);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(124, 20);
            this.lbl_apellidoP.TabIndex = 26;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_numseg
            // 
            this.txt_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numseg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numseg.Location = new System.Drawing.Point(182, 193);
            this.txt_numseg.MaximumSize = new System.Drawing.Size(376, 30);
            this.txt_numseg.MaxLength = 20;
            this.txt_numseg.Name = "txt_numseg";
            this.txt_numseg.Size = new System.Drawing.Size(159, 29);
            this.txt_numseg.TabIndex = 30;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidoM.Location = new System.Drawing.Point(10, 147);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(128, 20);
            this.lbl_apellidoM.TabIndex = 32;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombres.Location = new System.Drawing.Point(10, 48);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(87, 20);
            this.lbl_nombres.TabIndex = 33;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // txt_curp
            // 
            this.txt_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_curp.Location = new System.Drawing.Point(182, 242);
            this.txt_curp.MaximumSize = new System.Drawing.Size(376, 30);
            this.txt_curp.MaxLength = 20;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(159, 29);
            this.txt_curp.TabIndex = 31;
            // 
            // lbl_numseg
            // 
            this.lbl_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numseg.AutoSize = true;
            this.lbl_numseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numseg.ForeColor = System.Drawing.Color.Black;
            this.lbl_numseg.Location = new System.Drawing.Point(10, 197);
            this.lbl_numseg.Name = "lbl_numseg";
            this.lbl_numseg.Size = new System.Drawing.Size(122, 20);
            this.lbl_numseg.TabIndex = 34;
            this.lbl_numseg.Text = "Num.Seg.Social";
            // 
            // lbl_curp
            // 
            this.lbl_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.ForeColor = System.Drawing.Color.Black;
            this.lbl_curp.Location = new System.Drawing.Point(10, 247);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(54, 20);
            this.lbl_curp.TabIndex = 35;
            this.lbl_curp.Text = "CURP";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoP.Location = new System.Drawing.Point(182, 94);
            this.txt_apellidoP.MaximumSize = new System.Drawing.Size(376, 30);
            this.txt_apellidoP.MaxLength = 30;
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(159, 29);
            this.txt_apellidoP.TabIndex = 28;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoM.Location = new System.Drawing.Point(182, 143);
            this.txt_apellidoM.MaximumSize = new System.Drawing.Size(376, 30);
            this.txt_apellidoM.MaxLength = 30;
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(159, 29);
            this.txt_apellidoM.TabIndex = 29;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(358, 27);
            this.txt_fecha.MaxLength = 10;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(319, 32);
            this.txt_fecha.TabIndex = 26;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(358, 59);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(248, 446);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.Tag = "";
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // RgPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 588);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RgPacientes";
            this.Text = "RgPacientes";
            this.Load += new System.EventHandler(this.RgPacientes_Load);
            this.SizeChanged += new System.EventHandler(this.RgPacientes_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton registrarP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton rdb_femenino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Label lbl_sexo;
        public System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lbl_apellidoP;
        public System.Windows.Forms.TextBox txt_numseg;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_nombres;
        public System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Label lbl_numseg;
        private System.Windows.Forms.Label lbl_curp;
        public System.Windows.Forms.TextBox txt_apellidoP;
        public System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.TextBox txt_fecha;
    }
}