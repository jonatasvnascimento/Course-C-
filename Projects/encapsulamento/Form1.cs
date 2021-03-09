using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            cl_calculo calculadora = new cl_calculo();
            int price_initial = Convert.ToInt16(caixa_preco.Text);

            int produc = 0;

            if (rd1.Checked)
                produc = 1;
            else if (rd2.Checked)
                produc = 2;
            else if (rd3.Checked)
                produc = 3;

            lbl_display.Text = calculadora.CalcFinal(price_initial, 0).ToString();
            MessageBox.Show($"Calculo final = {calculadora.CalcFinal(price_initial, 0)}");
        }
    }
}
