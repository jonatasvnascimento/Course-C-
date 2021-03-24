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
    public partial class FormInserirEditar : Form
    {
        public FormInserirEditar()
        {
            InitializeComponent();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechar somente essa janela
            this.Close();
        }
    }
}
