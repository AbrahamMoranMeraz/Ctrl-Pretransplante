namespace Control_PreTransplante_V2
{
    partial class EditarPacientes
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
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.MinimumSize = new System.Drawing.Size(911, 598);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(911, 598);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Paciente";
            // 
            // btncancelar
            // 
            this.btncancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconSize = 40;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(738, 343);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Rotation = 0D;
            this.btncancelar.Size = new System.Drawing.Size(171, 253);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconSize = 40;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(738, 21);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Rotation = 0D;
            this.btneditar.Size = new System.Drawing.Size(171, 253);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Actualizar\r\nDatos\r\n";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.monthCalendar1);
            this.panel5.Controls.Add(this.btn_fecha);
            this.panel5.Controls.Add(this.txt_fecha);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(423, 21);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 575);
            this.panel5.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // btn_fecha
            // 
            this.btn_fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fecha.ForeColor = System.Drawing.Color.Black;
            this.btn_fecha.Location = new System.Drawing.Point(0, 467);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(315, 76);
            this.btn_fecha.TabIndex = 17;
            this.btn_fecha.Text = "Agregar fecha";
            this.btn_fecha.UseVisualStyleBackColor = true;
            this.btn_fecha.Click += new System.EventHandler(this.btn_fecha_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(0, 543);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(315, 32);
            this.txt_fecha.TabIndex = 14;
            this.txt_fecha.Text = "AÑO-MES-DIA";
            this.txt_fecha.Click += new System.EventHandler(this.txt_fecha_Click);
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
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 575);
            this.panel3.TabIndex = 0;
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.ForeColor = System.Drawing.Color.Black;
            this.rdb_femenino.Location = new System.Drawing.Point(65, 344);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(98, 24);
            this.rdb_femenino.TabIndex = 25;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            this.rdb_femenino.Click += new System.EventHandler(this.rdb_femenino_CheckedChanged);
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Checked = true;
            this.rdb_masculino.ForeColor = System.Drawing.Color.Black;
            this.rdb_masculino.Location = new System.Drawing.Point(65, 322);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(98, 24);
            this.rdb_masculino.TabIndex = 24;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            this.rdb_masculino.Click += new System.EventHandler(this.rdb_masculino_CheckedChanged);
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.ForeColor = System.Drawing.Color.Black;
            this.lbl_sexo.Location = new System.Drawing.Point(3, 325);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(45, 20);
            this.lbl_sexo.TabIndex = 23;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombres.Location = new System.Drawing.Point(175, 50);
            this.txt_nombres.MaxLength = 15;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.ShortcutsEnabled = false;
            this.txt_nombres.Size = new System.Drawing.Size(216, 26);
            this.txt_nombres.TabIndex = 14;
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidoP.Location = new System.Drawing.Point(3, 105);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(124, 20);
            this.lbl_apellidoP.TabIndex = 13;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_numseg
            // 
            this.txt_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numseg.Location = new System.Drawing.Point(175, 200);
            this.txt_numseg.MaxLength = 11;
            this.txt_numseg.Name = "txt_numseg";
            this.txt_numseg.Size = new System.Drawing.Size(216, 26);
            this.txt_numseg.TabIndex = 17;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidoM.Location = new System.Drawing.Point(3, 154);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(128, 20);
            this.lbl_apellidoM.TabIndex = 19;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombres.Location = new System.Drawing.Point(3, 55);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(87, 20);
            this.lbl_nombres.TabIndex = 20;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // txt_curp
            // 
            this.txt_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_curp.Location = new System.Drawing.Point(175, 249);
            this.txt_curp.MaxLength = 18;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(216, 26);
            this.txt_curp.TabIndex = 18;
            // 
            // lbl_numseg
            // 
            this.lbl_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numseg.AutoSize = true;
            this.lbl_numseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numseg.ForeColor = System.Drawing.Color.Black;
            this.lbl_numseg.Location = new System.Drawing.Point(3, 204);
            this.lbl_numseg.Name = "lbl_numseg";
            this.lbl_numseg.Size = new System.Drawing.Size(122, 20);
            this.lbl_numseg.TabIndex = 21;
            this.lbl_numseg.Text = "Num.Seg.Social";
            // 
            // lbl_curp
            // 
            this.lbl_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.ForeColor = System.Drawing.Color.Black;
            this.lbl_curp.Location = new System.Drawing.Point(3, 254);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(54, 20);
            this.lbl_curp.TabIndex = 22;
            this.lbl_curp.Text = "CURP";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoP.Location = new System.Drawing.Point(175, 101);
            this.txt_apellidoP.MaxLength = 15;
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(216, 26);
            this.txt_apellidoP.TabIndex = 15;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidoM.Location = new System.Drawing.Point(175, 150);
            this.txt_apellidoM.MaxLength = 15;
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(216, 26);
            this.txt_apellidoM.TabIndex = 16;
            // 
            // EditarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 598);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RgPacientes";
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.Label lbl_numseg;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.RadioButton rdb_femenino;
        public System.Windows.Forms.RadioButton rdb_masculino;
        public System.Windows.Forms.TextBox txt_nombres;
        public System.Windows.Forms.TextBox txt_numseg;
        public System.Windows.Forms.TextBox txt_curp;
        public System.Windows.Forms.TextBox txt_apellidoP;
        public System.Windows.Forms.TextBox txt_apellidoM;
        public System.Windows.Forms.TextBox txt_fecha;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneditar;
    }
}