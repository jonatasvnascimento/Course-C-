using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda
{
    public partial class FormInserirEditar : Form
    {
        int indice;
        public FormInserirEditar()
        {
            InitializeComponent();
            //Chama metodo ConstroiLista ao iniciar
            ConstroiLista();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechar somente essa janela
            this.Close();

        }
        private void ConstroiLista()
        {
            //limpa lista de contatos
            lista_contactos.Items.Clear();
            foreach (cl_contacto contacto in cl_geral.LISTA_CONTACTOS)
            {
                lista_contactos.Items.Add($"{contacto.nome} ({contacto.numero}) - {contacto.cep} {contacto.email}");
            }
            label_numero_registros.Text = $"Registros: {lista_contactos.Items.Count}";

            //impede a eliminação e edição de registro sem selecionar
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        private void FormInserirEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //inseir novo resgistro a lista

            //verifica se todos os campos estão prenchidos
            //if(text_nome.Text == "" || text_numero.Text == "" || text_cep.Text == "" || text_email.Text == "")
            //{
            //}

            foreach (cl_contacto contacto in cl_geral.LISTA_CONTACTOS)
            {
                if (contacto.nome == text_nome.Text &&
                    contacto.numero == text_numero.Text &&
                    contacto.cep == text_cep.Text &&
                    contacto.email == text_email.Text)
                { 
                    MessageBox.Show("Erro! Esse registo já existe. ");
                    return;
                }
            }

            if (text_nome.Text == "" || text_numero.Text == "" || text_cep.Text == "" || text_email.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos.");
                return;
            }
            else
            {
                cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text, text_cep.Text, text_email.Text);
            }
            //grava novo registro

            //atualizar lista de contatos
            ConstroiLista();

            text_nome.Text = "";
            text_numero.Text = "";
            text_cep.Text = "";
            text_email.Text = "";
        }

        private void lista_contactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_contactos.SelectedIndex == -1) return;

            indice = lista_contactos.SelectedIndex;
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga registro selecionado

            //1 elimina o registro da lista
            cl_geral.LISTA_CONTACTOS.RemoveAt(indice);
            //2 renova o ficheiro
            cl_geral.GravarFicheiro();
            //3 recontroi a lsta de contactos
            ConstroiLista();
        }
    }
}
