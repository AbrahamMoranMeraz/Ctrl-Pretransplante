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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.registrarP = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 174);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(236, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Fotografia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1600, 542);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Paciente";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.monthCalendar1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(529, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(686, 513);
            this.panel5.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(190, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.registrarP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1215, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 513);
            this.panel4.TabIndex = 1;
            // 
            // registrarP
            // 
            this.registrarP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrarP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.registrarP.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.registrarP.IconColor = System.Drawing.Color.Black;
            this.registrarP.IconSize = 50;
            this.registrarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarP.Location = new System.Drawing.Point(0, 0);
            this.registrarP.Name = "registrarP";
            this.registrarP.Rotation = 0D;
            this.registrarP.Size = new System.Drawing.Size(382, 513);
            this.registrarP.TabIndex = 0;
            this.registrarP.Text = "Registrar";
            this.registrarP.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb_femenino);
            this.panel3.Controls.Add(this.rdb_masculino);
            this.panel3.Controls.Add(this.lbl_sexo);
            this.panel3.Controls.Add(this.txt_nombres);
            this.panel3.Controls.Add(this.lbl_apellidoP);
            this.panel3.Controls.Add(this.txt_numseg);
            this.panel3.Controls.Add(this.lbl_apellidoM);
            this.panel3.Controls.Add(this.lbl_nombres);
            this.panel3.Controls.Add(this.txt_curp);
            this.panel3.Controls.Add(this.lbl_numseg);
            this.panel3.Controls.Add(this.lbl_curp);
            this.panel3.Controls.Add(this.txt_apellidoP);
            this.panel3.Controls.Add(this.txt_apellidoM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 513);
            this.panel3.TabIndex = 0;
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Location = new System.Drawing.Point(87, 364);
            this.rdb_femenino.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(120, 29);
            this.rdb_femenino.TabIndex = 25;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Checked = true;
            this.rdb_masculino.Location = new System.Drawing.Point(87, 336);
            this.rdb_masculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(122, 29);
            this.rdb_masculino.TabIndex = 24;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(4, 340);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(58, 25);
            this.lbl_sexo.TabIndex = 23;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombres.Location = new System.Drawing.Point(233, 62);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.MaxLength = 15;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.ShortcutsEnabled = false;
            this.txt_nombres.Size = new System.Drawing.Size(251, 30);
            this.txt_nombres.TabIndex = 14;
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(4, 117);
            this.lbl_apellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(153, 25);
            this.lbl_apellidoP.TabIndex = 13;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_numseg
            // 
            this.txt_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numseg.Location = new System.Drawing.Point(233, 210);
            this.txt_numseg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numseg.MaxLength = 11;
            this.txt_numseg.Name = "txt_numseg";
            this.txt_numseg.Size = new System.Drawing.Size(251, 30);
            this.txt_numseg.TabIndex = 17;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.Location = new System.Drawing.Point(4, 166);
            this.lbl_apellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(158, 25);
            this.lbl_apellidoM.TabIndex = 19;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(4, 68);
            this.lbl_nombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(110, 25);
            this.lbl_nombres.TabIndex = 20;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // txt_curp
            // 
            this.txt_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_curp.Location = new System.Drawing.Point(233, 259);
            this.txt_curp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_curp.MaxLength = 18;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(251, 30);
            this.txt_curp.TabIndex = 18;
            // 
            // lbl_numseg
            // 
            this.lbl_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numseg.AutoSize = true;
            this.lbl_numseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numseg.Location = new System.Drawing.Point(4, 215);
            this.lbl_numseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numseg.Name = "lbl_numseg";
            this.lbl_numseg.Size = new System.Drawing.Size(153, 25);
            this.lbl_numseg.TabIndex = 21;
            this.lbl_numseg.Text = "Num.Seg.Social";
            // 
            // lbl_curp
            // 
            this.lbl_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.Location = new System.Drawing.Point(4, 265);
            this.lbl_curp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(67, 25);
            this.lbl_curp.TabIndex = 22;
            this.lbl_curp.Text = "CURP";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoP.Location = new System.Drawing.Point(233, 112);
            this.txt_apellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidoP.MaxLength = 15;
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(251, 30);
            this.txt_apellidoP.TabIndex = 15;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoM.Location = new System.Drawing.Point(233, 161);
            this.txt_apellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidoM.MaxLength = 15;
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(251, 30);
            this.txt_apellidoM.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_fecha);
            this.panel2.Controls.Add(this.btn_fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 285);
            this.panel2.TabIndex = 1;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha.Location = new System.Drawing.Point(190, 61);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(290, 30);
            this.txt_fecha.TabIndex = 12;
            // 
            // btn_fecha
            // 
            this.btn_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fecha.Location = new System.Drawing.Point(245, 4);
            this.btn_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(191, 49);
            this.btn_fecha.TabIndex = 13;
            this.btn_fecha.Text = "Agregar fecha";
            this.btn_fecha.UseVisualStyleBackColor = true;
            // 
            // RgPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RgPacientes";
            this.Text = "RgPacientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton registrarP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdb_femenino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.TextBox txt_numseg;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Label lbl_numseg;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Button btn_fecha;
    }
}