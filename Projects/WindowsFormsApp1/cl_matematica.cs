using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class cl_matematica
    {
        int valor1;
        int valor2;
        public int Operacao(int valor1, int valor2, string sinal)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;

            int resultado = -1;

            if (sinal == "+")
                resultado = adicao();
            else if (sinal == "-")
                resultado = subtracao();
            else if (sinal == "*")
                resultado = multiplicacao();
            else if(sinal == "/")
                resultado = divisao();
            return resultado; 
        }

        private int adicao()
        {
            return valor1 + valor2;
        }
        private int subtracao()
        {
            return valor1 - valor2;
        }
        private int divisao()
        {
            return valor1 / valor2;
        }
        private int multiplicacao()
        {
            return valor1 * valor2;
        }
    }
}
