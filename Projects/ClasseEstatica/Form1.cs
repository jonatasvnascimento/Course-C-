using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = estatica.NomeProgran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal obj = new normal();
            obj.apresentar("Jonnes");

            normal obj2 = new normal();
            obj2.apresentar("Cllarkron");

            estatica.Nome = "Teste";
            estatica.Apresentar();
        }
    }
}
