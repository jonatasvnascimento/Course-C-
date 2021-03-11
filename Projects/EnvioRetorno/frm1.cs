using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm1 : Form
    {
        string nome = null;
        public frm1()
        {
            InitializeComponent();
        }

        private void cmd_avancar_Click(object sender, EventArgs e)
        {
            if (label_texto.Text != "")
                nome = label_texto.Text;

            frm2 formulario = new frm2(nome);
            formulario.ShowDialog();

            if (formulario.nome != null)
                label_texto.Text = formulario.nome;
        }
    }
}
