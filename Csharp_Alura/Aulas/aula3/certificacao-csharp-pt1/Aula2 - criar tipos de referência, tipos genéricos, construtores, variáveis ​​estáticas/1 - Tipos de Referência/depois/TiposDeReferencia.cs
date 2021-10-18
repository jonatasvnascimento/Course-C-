using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 42;");
            Console.WriteLine($"idade: { idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");
        }

        class Cliente
        {
            public Cliente()
            {
            }



            public string Nome { get; set; }
            public int Idade { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome} Idade: {Idade}";
            }

        }

    }
}
