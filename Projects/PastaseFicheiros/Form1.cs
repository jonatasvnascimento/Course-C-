using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PastaseFicheiros
{
    public partial class Form1 : Form
    {
        string pasta_trabalho = @"C:\config\";
        string ficheiro_config = "config.dat";
        public Form1()
        {
            InitializeComponent();
            pasta_trabalho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GravarConfig();
            MessageBox.Show("Config salvo com success.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validação se existe diretorio ou arquivo de configuração
            if (!File.Exists($"{pasta_trabalho}{ficheiro_config}"))
            {
                GravarConfig();
            }

            StreamReader ficheiro = new StreamReader($"{pasta_trabalho}{ficheiro_config}", Encoding.Default);
            text_nome.Text = ficheiro.ReadLine();
            data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());

            ficheiro.Dispose();
        }

        private void GravarConfig()
        {
            if (!Directory.Exists(pasta_trabalho))
                Directory.CreateDirectory(pasta_trabalho);

            StreamWriter ficheiro = new StreamWriter($"{pasta_trabalho}{ficheiro_config}", false, Encoding.Default);

            ficheiro.WriteLine(text_nome.Text);
            ficheiro.WriteLine(data_hora.Value);

            ficheiro.Dispose();

        }
    }
}
