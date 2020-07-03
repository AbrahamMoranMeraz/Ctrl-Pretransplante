namespace Control_PreTransplante_V2
{
    partial class Lista_P
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
            this.tap = new System.Windows.Forms.TabControl();
            this.listapaceintes = new System.Windows.Forms.TabPage();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panellateral = new System.Windows.Forms.Panel();
            this.btnestudios = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnactualizar = new FontAwesome.Sharp.IconButton();
            this.pacientes = new System.Windows.Forms.TabPage();
            this.tap.SuspendLayout();
            this.listapaceintes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.panel1.SuspendLayout();
            this.panellateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tap
            // 
            this.tap.Controls.Add(this.listapaceintes);
            this.tap.Controls.Add(this.pacientes);
            this.tap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tap.Location = new System.Drawing.Point(0, 0);
            this.tap.Margin = new System.Windows.Forms.Padding(2);
            this.tap.Name = "tap";
            this.tap.SelectedIndex = 0;
            this.tap.Size = new System.Drawing.Size(834, 588);
            this.tap.TabIndex = 0;
            // 
            // listapaceintes
            // 
            this.listapaceintes.Controls.Add(this.Lista);
            this.listapaceintes.Controls.Add(this.panel1);
            this.listapaceintes.Controls.Add(this.panellateral);
            this.listapaceintes.Location = new System.Drawing.Point(4, 22);
            this.listapaceintes.Margin = new System.Windows.Forms.Padding(2);
            this.listapaceintes.Name = "listapaceintes";
            this.listapaceintes.Padding = new System.Windows.Forms.Padding(2);
            this.listapaceintes.Size = new System.Drawing.Size(826, 562);
            this.listapaceintes.TabIndex = 0;
            this.listapaceintes.Text = "Lista Pacientes";
            this.listapaceintes.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Lista.ColumnHeadersHeight = 29;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista.EnableHeadersVisualStyles = false;
            this.Lista.GridColor = System.Drawing.Color.Teal;
            this.Lista.Location = new System.Drawing.Point(2, 32);
            this.Lista.Margin = new System.Windows.Forms.Padding(2);
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Lista.RowHeadersVisible = false;
            this.Lista.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Lista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Lista.RowTemplate.Height = 24;
            this.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lista.Size = new System.Drawing.Size(643, 528);
            this.Lista.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 30);
            this.panel1.TabIndex = 13;
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(63, 0);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(580, 28);
            this.txt_buscar.TabIndex = 18;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar:";
            // 
            // panellateral
            // 
            this.panellateral.Controls.Add(this.btnestudios);
            this.panellateral.Controls.Add(this.btneditar);
            this.panellateral.Controls.Add(this.btnactualizar);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panellateral.Location = new System.Drawing.Point(645, 2);
            this.panellateral.Margin = new System.Windows.Forms.Padding(2);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(179, 558);
            this.panellateral.TabIndex = 4;
            // 
            // btnestudios
            // 
            this.btnestudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnestudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnestudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudios.ForeColor = System.Drawing.Color.Black;
            this.btnestudios.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnestudios.IconColor = System.Drawing.Color.Black;
            this.btnestudios.IconSize = 40;
            this.btnestudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestudios.Location = new System.Drawing.Point(0, 130);
            this.btnestudios.Margin = new System.Windows.Forms.Padding(2);
            this.btnestudios.Name = "btnestudios";
            this.btnestudios.Rotation = 0D;
            this.btnestudios.Size = new System.Drawing.Size(179, 303);
            this.btnestudios.TabIndex = 7;
            this.btnestudios.Text = "Estudios";
            this.btnestudios.UseVisualStyleBackColor = true;
            this.btnestudios.Click += new System.EventHandler(this.Estudios_Click);
            // 
            // btneditar
            // 
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconSize = 40;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(0, 0);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Rotation = 0D;
            this.btneditar.Size = new System.Drawing.Size(179, 130);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar\r\nPaciente";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnactualizar.IconColor = System.Drawing.Color.Black;
            this.btnactualizar.IconSize = 40;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(0, 433);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Rotation = 0D;
            this.btnactualizar.Size = new System.Drawing.Size(179, 125);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = " Actualizar\r\nLista";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pacientes
            // 
            this.pacientes.Location = new System.Drawing.Point(4, 22);
            this.pacientes.Margin = new System.Windows.Forms.Padding(2);
            this.pacientes.Name = "pacientes";
            this.pacientes.Padding = new System.Windows.Forms.Padding(2);
            this.pacientes.Size = new System.Drawing.Size(826, 562);
            this.pacientes.TabIndex = 1;
            this.pacientes.Text = "Pacientes";
            this.pacientes.UseVisualStyleBackColor = true;
            // 
            // Lista_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 588);
            this.Controls.Add(this.tap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lista_P";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lista_P_Load);
            this.SizeChanged += new System.EventHandler(this.Lista_Resize);
            this.tap.ResumeLayout(false);
            this.listapaceintes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panellateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tap;
        private System.Windows.Forms.TabPage listapaceintes;
        private System.Windows.Forms.TabPage pacientes;
        private FontAwesome.Sharp.IconButton btnactualizar;
        private System.Windows.Forms.Panel panellateral;
        private FontAwesome.Sharp.IconButton btnestudios;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}