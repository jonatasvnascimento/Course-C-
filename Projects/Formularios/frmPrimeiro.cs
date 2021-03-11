using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPrimeiro : Form
    {
        public frmPrimeiro()
        {
            InitializeComponent();
        }

        private void cmd_um_Click(object sender, EventArgs e)
        {
            geral.nome = text_nome.Text;
            frmUm formulario = new frmUm(text_nome.Text);
            formulario.ShowDialog();
        }

        private void cmd_dois_Click(object sender, EventArgs e)
        {
            frmDois formulario1 = new frmDois();
            formulario1.ShowDialog();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
