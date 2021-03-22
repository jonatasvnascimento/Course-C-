using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nome = new string[5];

            nome[0] = "Antony";
            nome[1] = "Mary";
            nome[2] = "Bartholomeu";
            nome[3] = "Cheng";
            nome[4] = "Mia";

            List<string> nomes = new List<string>();
            nomes.Add("Antony");
            nomes.Add("Mary");
            nomes.Add("Bartholomeu");
            nomes.Add("Cheng");
            nomes.Add("Mia");
            nomes.Add("Joselyn");
            nomes.Add("Antony");
            nomes.Add("Mary");
            nomes.Add("Bartholomeu");
            nomes.Add("Cheng");
            nomes.Add("Mia");
            nomes.Add("Joselyn");
            nomes.Add("Antony");
            nomes.Add("Mary");
            nomes.Add("Bartholomeu");
            nomes.Add("Cheng");
            nomes.Add("Mia");
            nomes.Add("Joselyn");

            //nomes.RemoveAt(10);
            //nomes.Remove("Mia");//remove so o primeiro item da lista
            //MessageBox.Show(nomes.Count.ToString());

            //foreach (string item in nomes)
            //    listBox1.Items.Add(item);

            //if (nomes.Contains("Mia"))
            //{
            //    MessageBox.Show("Contains");
            //}else
            //{
            //    MessageBox.Show("Não conteins");
            //}

            MessageBox.Show(nomes.LastIndexOf("Mia").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> inteiros = new List<int>() {1,2,3,4,5,6,7,8,9 };

            foreach (int valor in inteiros)
                listBox1.Items.Add(valor);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet<string> lista_nome = new HashSet<string>()
            {
                "João", "Pedro", "Caris"
            };
            if (!lista_nome.Add("joão"))
            {
                MessageBox.Show("Erro!");
            }

            foreach(string nome in lista_nome)
            {
                listBox1.Items.Add(nome);
            }

            //MessageBox.Show(lista_nome.Count.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lista_valores = new Dictionary<string, string>();

            lista_valores.Add("button4", "Dictionry");
            lista_valores.Add("button3", "HashSet");
            lista_valores.Add("button2", "List inline");

            //MessageBox.Show(lista_valores["button4"]);

            foreach(KeyValuePair<string, string> item in lista_valores)
            {
                listBox1.Items.Add(item.Value);
            }

            if (lista_valores.ContainsKey("button3"))
                MessageBox.Show("Contains");
            else
                MessageBox.Show("Not contains");
        }
    }
}
