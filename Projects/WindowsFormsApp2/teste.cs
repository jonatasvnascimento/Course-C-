using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class teste
    {
        public int acrecent(int x, int valor = 10)
        {
            valor += x;
            return valor;
        }
        public void decrement(ref int valor)
        {
            valor -= 5;
        }
    }
}
