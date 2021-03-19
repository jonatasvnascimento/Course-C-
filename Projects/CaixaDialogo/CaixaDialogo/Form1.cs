using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CaixaDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //simples
            //MessageBox.Show("TESTE");

            //Mesnage titulo buttons icon
            //MessageBox.Show("teste", "teste",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Caixa de dialogo com resultado
            if (MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return;
            else
                Application.Exit();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "Escolher arquivo";
            caixa.InitialDirectory = @"C:\";
            caixa.Filter = "Files txt (*.txt) |*.txt|JPEG imagens (*.jpg)|*.jpg";

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackgroundImage = Image.FromFile(caixa.FileName);
            caixa.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "Gravar arquivo";
            caixa.Filter = "TXT file(*.txt)|*.txt";
            //pasta my documents
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            string ficheiro = caixa.FileName;

            //escreve em arquivos
            StreamWriter file = new StreamWriter(ficheiro, false, Encoding.Default);
            file.WriteLine("teste");
            file.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixa = new FolderBrowserDialog();
            caixa.SelectedPath = @"C:\";

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            MessageBox.Show($"A pasta selecionada foi: {caixa.SelectedPath}");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog caixa = new ColorDialog();
            caixa.Color = pictureBox1.BackColor;

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackColor = caixa.Color;
        }
    }
}
