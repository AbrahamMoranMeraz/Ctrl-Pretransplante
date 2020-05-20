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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tap = new System.Windows.Forms.TabControl();
            this.listapaceintes = new System.Windows.Forms.TabPage();
            this.pacientes = new System.Windows.Forms.TabPage();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.tap.SuspendLayout();
            this.listapaceintes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // tap
            // 
            this.tap.Controls.Add(this.listapaceintes);
            this.tap.Controls.Add(this.pacientes);
            this.tap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tap.Location = new System.Drawing.Point(0, 0);
            this.tap.Name = "tap";
            this.tap.SelectedIndex = 0;
            this.tap.Size = new System.Drawing.Size(1334, 707);
            this.tap.TabIndex = 0;
            // 
            // listapaceintes
            // 
            this.listapaceintes.Controls.Add(this.Lista);
            this.listapaceintes.Location = new System.Drawing.Point(4, 25);
            this.listapaceintes.Name = "listapaceintes";
            this.listapaceintes.Padding = new System.Windows.Forms.Padding(3);
            this.listapaceintes.Size = new System.Drawing.Size(1326, 678);
            this.listapaceintes.TabIndex = 0;
            this.listapaceintes.Text = "Lista Pacientes";
            this.listapaceintes.UseVisualStyleBackColor = true;
            // 
            // pacientes
            // 
            this.pacientes.Location = new System.Drawing.Point(4, 25);
            this.pacientes.Name = "pacientes";
            this.pacientes.Padding = new System.Windows.Forms.Padding(3);
            this.pacientes.Size = new System.Drawing.Size(1326, 678);
            this.pacientes.TabIndex = 1;
            this.pacientes.Text = "Pacientes";
            this.pacientes.UseVisualStyleBackColor = true;
            this.pacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pacientes_MouseDoubleClick);
            // 
            // Lista
            // 
            this.Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista.BackgroundColor = System.Drawing.Color.Teal;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Lista.ColumnHeadersHeight = 29;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista.EnableHeadersVisualStyles = false;
            this.Lista.GridColor = System.Drawing.Color.Teal;
            this.Lista.Location = new System.Drawing.Point(3, 3);
            this.Lista.Name = "Lista";
            this.Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Lista.RowHeadersVisible = false;
            this.Lista.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Lista.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Lista.RowTemplate.Height = 24;
            this.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lista.Size = new System.Drawing.Size(1320, 672);
            this.Lista.TabIndex = 2;
            this.Lista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Lista_CellMouseDoubleClick);
            // 
            // Lista_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 707);
            this.Controls.Add(this.tap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_P";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lista_P_Load);
            this.tap.ResumeLayout(false);
            this.listapaceintes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tap;
        private System.Windows.Forms.TabPage listapaceintes;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.TabPage pacientes;
    }
}