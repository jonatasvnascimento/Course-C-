using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ApagarPastaFicheiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lista_ficheiros = Directory.GetFiles(@"C:\", "*.dat");

            foreach (string item in lista_ficheiros)
            {
                File.Move(item, @"C:\config\" + Path.GetFileName(item));
            }
            MessageBox.Show("Terminado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //File.Delete(@"C:\dados.dat");
            if(Directory.Exists(@"C:\config"))
                Directory.Delete(@"C:\config", true);

            MessageBox.Show("Terminado");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //* todos arquivos 
            //s*.* todos os arquivos com começar com s
            //*t*.* tudo que tem t no meio vai trazer
            //*.
            
            string[] ficheiros = Directory.GetFiles(@"C:\dados");

            foreach (string item in ficheiros)
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(item));

            //listBox1.Items.AddRange(ficheiros); busca ficheiro
        }
    }
}
