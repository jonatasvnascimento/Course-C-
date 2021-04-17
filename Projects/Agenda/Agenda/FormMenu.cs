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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            
            InitializeComponent();
      
            //Carrega os contatos
            cl_geral.ConstroiListaContactos();

            //apresentar verção do projeto da classe cl_geral
            lbl_version.Text = cl_geral.version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?","SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            //abre aba inserir e editar
            FormInserirEditar formulario = new FormInserirEditar();
            formulario.ShowDialog();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //abre o quadro de pesquisa
            FormTexto pesquisa = new FormTexto();
            pesquisa.ShowDialog();

            if (pesquisa.cancelado) return;

            //abri quadro com resultado com pesquisas
            FormResultado resultado = new FormResultado(pesquisa.texto);
            resultado.ShowDialog();
        }
    }
}
