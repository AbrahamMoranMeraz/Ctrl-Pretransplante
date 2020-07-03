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
    public partial class Acerca_de_ : Form
    {
        public Acerca_de_()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Red;
            btncerrar.ForeColor = Color.White;
            btncerrar.IconColor = Color.White;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Transparent;
            btncerrar.ForeColor = Color.Black;
            btncerrar.IconColor = Color.Black;
        }
    }
}
