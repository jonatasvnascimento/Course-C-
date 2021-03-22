using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            int parcela1;
            int parcela2;
            string tipo_operação;
            string algoritmo = text_operacao.Text;
            string sinais = "+-*/";
            int index = 0;

            //verificação do que tem no campo text_operação
            foreach (char c in algoritmo)
            {
                foreach (char s in sinais)
                {
                    if (c == s)
                    {
                        //define o calculo a ser feito com o operador achado do laço
                        parcela1 = int.Parse(algoritmo.Substring(0, index));
                        //sinal
                        tipo_operação = c.ToString();
                        //parcela2
                        parcela2 = int.Parse(algoritmo.Substring(index + 1));
                    }
                }
                index++;
            }
        }
    }
}
