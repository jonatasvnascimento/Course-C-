using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AprimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;


            resultado = parcela_1 - parcela_2;
            //resultado = parcela_1 * parcela_2;
            //resultado = parcela_1 / parcela_2;
            //resultado = parcela_1 % parcela_2;


            label_resultado.Text = resultado.ToString();
        }

        private void cmd_adicao_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;

            resultado = parcela_1 + parcela_2;

            label_resultado.Text = resultado.ToString();

        }

        private void cmd_subitracao_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;

            resultado = parcela_1 - parcela_2;

            label_resultado.Text = resultado.ToString();
        }

        private void cmd_muiltiplicar_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;

            resultado = parcela_1 * parcela_2;
            label_resultado.Text = resultado.ToString();
        }

        private void cmd_divisao_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;

            resultado = parcela_1 / parcela_2;
            label_resultado.Text = resultado.ToString();
        }

        private void cmd_modulo_Click(object sender, EventArgs e)
        {
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            int resultado;

            resultado = parcela_1 % parcela_2;
            label_resultado.Text = resultado.ToString();
        }

        private void btn_operation_math_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            resultado += 1;
            resultado++;
            resultado--;
            resultado -= 1;
            resultado *= 1;
            resultado /= 1;

            //x = y, x + = y, x -= y, x * = y, x /= y, x % = y, x &= y, x |= y, x ^ = y, x <<= y, x >>= y, x ?? = y, =>	Declaração de atribuição e lambda




            label_resultado.Text = resultado.ToString();
        }

        private void bnt_if_Click(object sender, EventArgs e)
        {
            int parcela_1 = 10; //int.Parse(text_parcela_1.Text);
            int parcela_2 = 20; //int.Parse(text_parcela_2.Text);
            
            if (parcela_1 >= 10 || parcela_2 <= 20)
            {
                label_resultado.Text = $"O valor informado e {parcela_1}";
            }else if (parcela_1 <= 10)
            {
                label_resultado.Text = "Valor inferior ao informado";
            }else
            {
                label_resultado.Text = "Error";
            }

            //x<y, x> y, x <= y, x > = y, é, como Teste de tipo e relacional
            //x = = y, x! = y Igualitário
            //x && y  AND condicional
            //x || y  OR condicional
            //x ?? y  Operador de coalescência nula
            //c? t : f Operador condicional

            label_resultado.Text = parcela_1 == 10 ? "Sim": "Não";

        }

        private void bnt_switch_Click(object sender, EventArgs e)
        {
            int valor = 10;

            switch (valor)
            {
                case 10:
                    label_resultado.Text = "1";
                    break;
                case 20:
                    label_resultado.Text = "2";
                    break;
                default:
                    label_resultado.Text = "";
                    break;
            }
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            //lista.Items.Add(1);

            for (int i = 0; i <= 100; i++)
            {
                lista.Items.Add(i);
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i <= 100)
            {
                lista.Items.Add(i++);
                
            }
        }

        private void btn_do_while_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                lista.Items.Add(i++);
            } while (i <= 100);
        }

        private void btn_foreach_Click(object sender, EventArgs e)
        {

            List<string> lista_nomes = new List<string>() { 
                "ana","maria","andre","jonnes","cllarkron"
            };

            foreach (string c in lista_nomes)
            {
                lista.Items.Add(c);
            }

            //string frase = "O teste do vazio";

            //foreach (char c in frase)
            //{
            //    lista.Items.Add(c);
            //}
            
        }

        private void btn_array_Click(object sender, EventArgs e)
        {
            //valores[0] = 10;
            //valores[1] = 20;
            //valores[2] = 30;
            //valores[3] = 40;
            //valores[5] = 50;

            //int result = valores[1] + valores[2];

            int[] valores = new int[]
            {
                10,20,30,40,50,60
            };

            //foreach (int c in valores)
            //    lista.Items.Add(c);

            for (int i = 0; i < valores.Length; i++)
                lista.Items.Add(valores[i]);
          
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            string frase = "Good Monging love of my life";
            string items = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20";
            string nome = "Dayse";
            string[] dados = items.Split(',');//fatia apartir da "," e tranforma em array

            label_resultado.Text = $"A frase '{frase}' contrem {frase.Length} caracteres ";
            label_resultado.Text = $"{frase.ToUpper()}";//maiuscula
            label_resultado.Text = $"{frase.ToLower()}";//minuscula
            label_resultado.Text = $"{frase.Substring(5)}";//fatia
            label_resultado.Text = $"{frase.Contains("A")}";//contem
            label_resultado.Text = $"{frase.StartsWith("A")}";//começa
            label_resultado.Text = $"{frase.EndsWith("A")}";//termina
            label_resultado.Text = $"{frase.Trim()}";//tira espaço
            label_resultado.Text = $"{frase.TrimEnd()}";//tira espaço
            label_resultado.Text = $"{frase.TrimStart()}";//tira espaço
            label_resultado.Text = $"{frase.IndexOf("G")}";//pegar primeiro indice
            label_resultado.Text = $"{frase.LastIndexOf("e")}";//pegar ultimo indice
            label_resultado.Text = $"{frase.Replace('i', '_')}";//trocar algo por algo
            label_resultado.Text = $"{dados[3]}";//tira espaço


            if (!frase.EndsWith("."))
            {
                frase += ".";
            }

            


        }


    }
}
