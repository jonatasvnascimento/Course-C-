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
                lista_contactos.Items.Add($"{contacto.nome}       | {contacto.numero}     | {contacto.cep}  | {contacto.email}");
            }
            label_numero_registros.Text = $"Registros: {lista_contactos.Items.Count}";
        }

        private void FormInserirEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //inseir novo resgistro a lista

            //verifica se todos os campos estão prenchidos
            if(text_nome.Text == "" || text_numero.Text == "" || text_cep.Text == "" || text_email.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos.");
            }
            else
            {
                //gravar novo registros
                cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text, text_cep.Text, text_email.Text);

            }

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

                ConstroiLista();


            }

            //atualizar lista de contatos
        }
    }
}
