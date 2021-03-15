using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FicheirosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\teste.txt",true, Encoding.Default);
            ficheiro.WriteLine(textBox1.Text);
            ficheiro.Dispose();

            textBox1.Text = "";
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\teste.txt", Encoding.Default);

            while (ficheiro.EndOfStream == false)
            {
                lista.Items.Add(ficheiro.ReadLine());
            }

            //MessageBox.Show(ficheiro.ReadToEnd().ToString());
            ficheiro.Dispose();

        }
    }
}
