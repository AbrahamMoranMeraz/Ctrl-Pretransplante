﻿namespace Control_PreTransplante_V2
{
    partial class Paciente
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
            this.lbnss = new System.Windows.Forms.Label();
            this.lbmaterno = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbpaterno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataestudiosr = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataestudiosp = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataestudiosr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataestudiosp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnss
            // 
            this.lbnss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnss.AutoSize = true;
            this.lbnss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnss.Location = new System.Drawing.Point(124, 89);
            this.lbnss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnss.Name = "lbnss";
            this.lbnss.Size = new System.Drawing.Size(40, 17);
            this.lbnss.TabIndex = 4;
            this.lbnss.Text = "NSS:";
            // 
            // lbmaterno
            // 
            this.lbmaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmaterno.AutoSize = true;
            this.lbmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmaterno.Location = new System.Drawing.Point(124, 65);
            this.lbmaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmaterno.Name = "lbmaterno";
            this.lbmaterno.Size = new System.Drawing.Size(118, 17);
            this.lbmaterno.TabIndex = 3;
            this.lbmaterno.Text = "Apellido Materno:";
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(124, 16);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(62, 17);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbpaterno
            // 
            this.lbpaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpaterno.AutoSize = true;
            this.lbpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpaterno.Location = new System.Drawing.Point(124, 41);
            this.lbpaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpaterno.Name = "lbpaterno";
            this.lbpaterno.Size = new System.Drawing.Size(116, 17);
            this.lbpaterno.TabIndex = 2;
            this.lbpaterno.Text = "Apellido Paterno:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbpaterno);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbnombre);
            this.panel1.Controls.Add(this.lbmaterno);
            this.panel1.Controls.Add(this.lbnss);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 127);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Controls.Add(this.dataestudiosr);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataestudiosp);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(292, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 431);
            this.panel3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(324, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 75);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar Formato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Estudio 1",
            "Estudio 2",
            "Estudio 3",
            "Estudio 4",
            "Estudio 5",
            "Estudio 6",
            "Estudio 7",
            "Estudio 8",
            "Estudio 9",
            "Estudio 10",
            "Estudio 11",
            "Estudio 12",
            "Estudio 13",
            "Estudio 14",
            "Estudio 15",
            "Estudio 16",
            "Estudio 17",
            "Estudio 18"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 221);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(587, 124);
            this.checkedListBox1.TabIndex = 13;
            // 
            // dataestudiosr
            // 
            this.dataestudiosr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataestudiosr.Location = new System.Drawing.Point(13, 26);
            this.dataestudiosr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataestudiosr.Name = "dataestudiosr";
            this.dataestudiosr.RowHeadersWidth = 51;
            this.dataestudiosr.RowTemplate.Height = 24;
            this.dataestudiosr.Size = new System.Drawing.Size(586, 80);
            this.dataestudiosr.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(17, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estudios Realizados";
            // 
            // dataestudiosp
            // 
            this.dataestudiosp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataestudiosp.Location = new System.Drawing.Point(13, 136);
            this.dataestudiosp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataestudiosp.Name = "dataestudiosp";
            this.dataestudiosp.RowHeadersWidth = 51;
            this.dataestudiosp.RowTemplate.Height = 24;
            this.dataestudiosp.Size = new System.Drawing.Size(586, 80);
            this.dataestudiosp.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(17, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estudios Pendientes";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(9, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 304);
            this.panel2.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 304);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Location = new System.Drawing.Point(6, 24);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 277);
            this.panel6.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 277);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(0, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Notas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 368);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Estudios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataestudiosr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataestudiosp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbnss;
        private System.Windows.Forms.Label lbmaterno;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbpaterno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataestudiosr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataestudiosp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}