using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\dados.txt", false, Encoding.Default);

            ficheiro.WriteLine("Esta e uma frase");

            int valor = 100;
            ficheiro.WriteLine(valor);

            bool teste = false;
            ficheiro.WriteLine(teste);

            ficheiro.WriteLine(DateTime.Now);

            Color cor = Color.FromArgb(2, 167, 164);
            ficheiro.WriteLine(cor.ToArgb());

            ficheiro.Dispose();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\dados.txt", Encoding.Default);

            string a = ficheiro.ReadLine();
            int valor = int.Parse(ficheiro.ReadLine());
            bool teste = bool.Parse(ficheiro.ReadLine());
            DateTime time = DateTime.Parse(ficheiro.ReadLine());

            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));
            pictureBox1.BackColor = cor;

            MessageBox.Show($"{a} {valor} {teste} {time}");


            ficheiro.Dispose();
        }
    }
}
