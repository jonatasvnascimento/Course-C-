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
            int resultado = -1;
            string tipo_operação;
            string algoritmo = text_operacao.Text;
            string sinais = "+-*/%";
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

                        //analiza a operação
                        switch (tipo_operação)
                        {
                            case "+":
                                resultado = parcela1 + parcela2;
                                break;
                            case "-":
                                resultado = parcela1 - parcela2;
                                break;
                            case "*":
                                resultado = parcela2 * parcela2;
                                break;
                            case "/":
                                resultado = parcela1 / parcela2;
                                break;
                            case "%":
                                resultado = parcela1 % parcela2;
                                break;

                        }
                        break;
                    }
                }

                if (resultado != -1)
                    break;
                index++;
            }
            if (resultado == -1)
                lbl_result_calc.Text = "Valor invalido";
            else
                lbl_result_calc.Text = resultado.ToString();
                //text_operacao.Text = resultado.ToString();
                //MessageBox.Show($"{algoritmo} = {resultado}");


            text_operacao.Text = "";
            text_operacao.Focus();
        }

        private void text_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (text_operacao.Text == "") return;

            if (e.KeyCode == Keys.Return)
                cmd_calcular_Click(cmd_calcular, EventArgs.Empty);
            else if(e.KeyCode == Keys.Escape)
            {
                text_operacao.Text = "";
                text_operacao.Focus();
            }
        }
    }
}
