using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            //apresentar verção do projeto da classe cl_geral
            lbl_version.Text = cl_geral.version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
