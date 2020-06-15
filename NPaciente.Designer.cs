namespace Control_PreTransplante_V2
{
    partial class NPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbc_datosGenerales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Foto = new System.Windows.Forms.PictureBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbx_Registro = new System.Windows.Forms.GroupBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.txt_numseg = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_apellidoM = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.ibtn_enviar = new FontAwesome.Sharp.IconButton();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.rdb_femenino = new System.Windows.Forms.RadioButton();
            this.lbl_numseg = new System.Windows.Forms.Label();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.lbl_fechaNa = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.tbc_datosGenerales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbx_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_datosGenerales
            // 
            this.tbc_datosGenerales.Controls.Add(this.tabPage1);
            this.tbc_datosGenerales.Controls.Add(this.tabPage2);
            this.tbc_datosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_datosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_datosGenerales.Location = new System.Drawing.Point(0, 0);
            this.tbc_datosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_datosGenerales.Name = "tbc_datosGenerales";
            this.tbc_datosGenerales.SelectedIndex = 0;
            this.tbc_datosGenerales.Size = new System.Drawing.Size(1639, 937);
            this.tbc_datosGenerales.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbx_Registro);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1631, 899);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_Foto);
            this.panel1.Controls.Add(this.btn_foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1623, 277);
            this.panel1.TabIndex = 23;
            // 
            // ptb_Foto
            // 
            this.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Foto.Location = new System.Drawing.Point(4, 4);
            this.ptb_Foto.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_Foto.Name = "ptb_Foto";
            this.ptb_Foto.Size = new System.Drawing.Size(257, 219);
            this.ptb_Foto.TabIndex = 18;
            this.ptb_Foto.TabStop = false;
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(300, 186);
            this.btn_foto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(187, 37);
            this.btn_foto.TabIndex = 12;
            this.btn_foto.Text = "Agregar foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_borrar);
            this.tabPage2.Controls.Add(this.btn_editar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1631, 899);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes registrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(197, 671);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(160, 37);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(29, 671);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(160, 37);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1565, 629);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbx_Registro
            // 
            this.gbx_Registro.Controls.Add(this.txt_fecha);
            this.gbx_Registro.Controls.Add(this.btn_fecha);
            this.gbx_Registro.Controls.Add(this.btn_agregar);
            this.gbx_Registro.Controls.Add(this.txt_nombres);
            this.gbx_Registro.Controls.Add(this.lbl_apellidoP);
            this.gbx_Registro.Controls.Add(this.txt_numseg);
            this.gbx_Registro.Controls.Add(this.monthCalendar1);
            this.gbx_Registro.Controls.Add(this.lbl_apellidoM);
            this.gbx_Registro.Controls.Add(this.lbl_nombres);
            this.gbx_Registro.Controls.Add(this.ibtn_enviar);
            this.gbx_Registro.Controls.Add(this.txt_curp);
            this.gbx_Registro.Controls.Add(this.rdb_femenino);
            this.gbx_Registro.Controls.Add(this.lbl_numseg);
            this.gbx_Registro.Controls.Add(this.rdb_masculino);
            this.gbx_Registro.Controls.Add(this.lbl_curp);
            this.gbx_Registro.Controls.Add(this.txt_apellidoP);
            this.gbx_Registro.Controls.Add(this.lbl_fechaNa);
            this.gbx_Registro.Controls.Add(this.lbl_sexo);
            this.gbx_Registro.Controls.Add(this.txt_apellidoM);
            this.gbx_Registro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_Registro.Location = new System.Drawing.Point(4, 281);
            this.gbx_Registro.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_Registro.Name = "gbx_Registro";
            this.gbx_Registro.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_Registro.Size = new System.Drawing.Size(1623, 614);
            this.gbx_Registro.TabIndex = 24;
            this.gbx_Registro.TabStop = false;
            this.gbx_Registro.Text = "Registro de paciente";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(657, 402);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(259, 30);
            this.txt_fecha.TabIndex = 8;
            // 
            // btn_fecha
            // 
            this.btn_fecha.Location = new System.Drawing.Point(657, 350);
            this.btn_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(160, 37);
            this.btn_fecha.TabIndex = 9;
            this.btn_fecha.Text = "Agregar fecha";
            this.btn_fecha.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.CausesValidation = false;
            this.btn_agregar.Location = new System.Drawing.Point(1255, 427);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(160, 59);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Registrar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombres.Location = new System.Drawing.Point(266, 94);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.MaxLength = 15;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.ShortcutsEnabled = false;
            this.txt_nombres.Size = new System.Drawing.Size(251, 30);
            this.txt_nombres.TabIndex = 3;
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(37, 149);
            this.lbl_apellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(153, 25);
            this.lbl_apellidoP.TabIndex = 0;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_numseg
            // 
            this.txt_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_numseg.Location = new System.Drawing.Point(266, 242);
            this.txt_numseg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numseg.MaxLength = 11;
            this.txt_numseg.Name = "txt_numseg";
            this.txt_numseg.Size = new System.Drawing.Size(251, 30);
            this.txt_numseg.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(657, 128);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.Location = new System.Drawing.Point(37, 198);
            this.lbl_apellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(158, 25);
            this.lbl_apellidoM.TabIndex = 9;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(37, 100);
            this.lbl_nombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(110, 25);
            this.lbl_nombres.TabIndex = 10;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // ibtn_enviar
            // 
            this.ibtn_enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtn_enviar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_enviar.IconColor = System.Drawing.Color.Black;
            this.ibtn_enviar.IconSize = 16;
            this.ibtn_enviar.Location = new System.Drawing.Point(1455, 427);
            this.ibtn_enviar.Margin = new System.Windows.Forms.Padding(4);
            this.ibtn_enviar.Name = "ibtn_enviar";
            this.ibtn_enviar.Rotation = 0D;
            this.ibtn_enviar.Size = new System.Drawing.Size(160, 59);
            this.ibtn_enviar.TabIndex = 11;
            this.ibtn_enviar.Text = "Generar PDF";
            this.ibtn_enviar.UseVisualStyleBackColor = true;
            // 
            // txt_curp
            // 
            this.txt_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_curp.Location = new System.Drawing.Point(266, 291);
            this.txt_curp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_curp.MaxLength = 18;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(251, 30);
            this.txt_curp.TabIndex = 7;
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Location = new System.Drawing.Point(141, 427);
            this.rdb_femenino.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(120, 29);
            this.rdb_femenino.TabIndex = 16;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // lbl_numseg
            // 
            this.lbl_numseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_numseg.AutoSize = true;
            this.lbl_numseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numseg.Location = new System.Drawing.Point(37, 247);
            this.lbl_numseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numseg.Name = "lbl_numseg";
            this.lbl_numseg.Size = new System.Drawing.Size(153, 25);
            this.lbl_numseg.TabIndex = 11;
            this.lbl_numseg.Text = "Num.Seg.Social";
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Checked = true;
            this.rdb_masculino.Location = new System.Drawing.Point(141, 399);
            this.rdb_masculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(122, 29);
            this.rdb_masculino.TabIndex = 15;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_curp
            // 
            this.lbl_curp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.Location = new System.Drawing.Point(37, 297);
            this.lbl_curp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(67, 25);
            this.lbl_curp.TabIndex = 12;
            this.lbl_curp.Text = "CURP";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_apellidoP.Location = new System.Drawing.Point(266, 144);
            this.txt_apellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidoP.MaxLength = 15;
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(251, 30);
            this.txt_apellidoP.TabIndex = 4;
            // 
            // lbl_fechaNa
            // 
            this.lbl_fechaNa.AutoSize = true;
            this.lbl_fechaNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNa.Location = new System.Drawing.Point(652, 92);
            this.lbl_fechaNa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaNa.Name = "lbl_fechaNa";
            this.lbl_fechaNa.Size = new System.Drawing.Size(193, 25);
            this.lbl_fechaNa.TabIndex = 13;
            this.lbl_fechaNa.Text = "Fecha de nacimiento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(58, 403);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(58, 25);
            this.lbl_sexo.TabIndex = 14;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_apellidoM.Location = new System.Drawing.Point(266, 193);
            this.txt_apellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidoM.MaxLength = 15;
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(251, 30);
            this.txt_apellidoM.TabIndex = 5;
            // 
            // NPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1639, 937);
            this.Controls.Add(this.tbc_datosGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NPaciente";
            this.Text = "NPaciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.tbc_datosGenerales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbx_Registro.ResumeLayout(false);
            this.gbx_Registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_datosGenerales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox ptb_Foto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbx_Registro;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.TextBox txt_numseg;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_nombres;
        private FontAwesome.Sharp.IconButton ibtn_enviar;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.RadioButton rdb_femenino;
        private System.Windows.Forms.Label lbl_numseg;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.Label lbl_fechaNa;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_apellidoM;
    }
}