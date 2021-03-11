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
    public partial class frmUm : Form
    {
        string valor;

        public frmUm(string valor_nome)
        {
            InitializeComponent();
            valor = valor_nome;
            label_final.Text = valor;//geral.nome;
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            lbl_text.Text = geral.nome;
        }
    }
}
