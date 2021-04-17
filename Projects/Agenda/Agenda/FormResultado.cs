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
    public partial class FormResultado : Form
    {
        string texto;
        public FormResultado(string texto)
        {
            InitializeComponent();
            //define texto de pesquisa
            this.texto = texto.ToUpper();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            //executa pesquisa e controi a lista
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e apresenta dados
            List<cl_contacto> lista_resultados = new List<cl_contacto>();
            
            foreach(cl_contacto contacto in cl_geral.LISTA_CONTACTOS)
            {
                if (contacto.nome.ToUpper().Contains(texto) || 
                    contacto.numero.ToUpper().Contains(texto)||
                    contacto.cep.ToUpper().Contains(texto)||
                    contacto.email.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contacto);
                }
                //apresenta resultado na lista
                lista_final.Items.Clear();

                foreach(cl_contacto contactos in lista_resultados)
                {
                    lista_final.Items.Add($"{contactos.nome} ({contactos.numero}) {contactos.cep} {contactos.email}");
                }

                label_numero_registros.Text = $"Registros: {lista_final.Items.Count}";

            }
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            FormTexto pesquisa = new FormTexto();
            pesquisa.ShowDialog();

            //guando o guadro e fechado
            if (pesquisa.cancelado) return;

            texto = pesquisa.texto.ToUpper();
            ExecutaPesquisa();
       }
    }
}
