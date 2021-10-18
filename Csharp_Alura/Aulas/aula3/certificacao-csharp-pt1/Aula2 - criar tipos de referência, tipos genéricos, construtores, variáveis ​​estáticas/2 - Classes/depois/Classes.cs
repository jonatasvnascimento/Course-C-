using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            Cliente teste = new Cliente()
            {
                Nome = "Teste",
                Idade = 99
            };
            Console.WriteLine(teste);

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
