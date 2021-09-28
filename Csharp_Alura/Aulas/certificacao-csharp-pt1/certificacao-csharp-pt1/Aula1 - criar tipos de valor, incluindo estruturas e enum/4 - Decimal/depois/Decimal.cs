using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);

            float valorProduto1 = 10.10f;
            float valorProduto2 = 20.20f;
            float subtotal = 30.30f;

            Console.WriteLine("Descobrindo se (10.10 + 20.20) == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            Console.WriteLine(valorProduto1 + valorProduto2);

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);

            decimal valorProduto10 = 10.10m;
            decimal valorProduto20 = 20.20m;
            decimal subtotal0 = 30.30m;

            Console.WriteLine("Descobrindo se (10.10 + 20.20) == 30.30");
            Console.WriteLine((valorProduto10 + valorProduto20) == subtotal0);

            Console.WriteLine(valorProduto1 + valorProduto2);
        }
    }
}
