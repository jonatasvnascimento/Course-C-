using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContantesEstruturas
{
    public partial class Form1 : Form
    {
        struct struc_pessoa
        {
            public string Nome;
            public string Sobrenome;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal nome = new normal();
            Console.WriteLine(nome.Nome);
            Console.WriteLine(estatica.nome);

            pessoa p1 = new pessoa();
            p1.Nome = "C";
            p1.Sobrenome = "D";

            //struc_pessoa p2 = new struc_pessoa();
            //p2.Nome = "t";
            //p2.Sobrenome = "F";

            struc_pessoa p2 = new struc_pessoa()
            {
                Nome = "teste",
                Sobrenome = "Dio"
            };

        }
    }
}
