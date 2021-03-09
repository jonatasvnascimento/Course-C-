using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseEstatica
{
    public static class estatica
    {
        public static string Nome;

        public static string NomeProgran = "Teste";
        

        public static void Apresentar()
        {
            Console.WriteLine(Nome);
        }
    }
}
