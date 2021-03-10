using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            label1.Text = "Teste";
            label1.BackColor = Color.Red;
            label1.Size = new Size(100,100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
                label1.Visible = true;
            else
                label1.Visible = false;*/

            label1.Visible = checkBox1.Checked;
        }
    }
}
