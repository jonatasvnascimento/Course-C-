using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumeracoes
{
    class teste
    {
        public enum DayOfWeek
        {
            domingo, segunda, terça, quarta, quinta, sexta, sábado
        }
        public enum Moviment
        {
            cima, baixo, esquerda, direita
        }
        public void ApresentarDia(DayOfWeek dia)
        {
            Console.WriteLine($"O dia e {dia}");
        }

        public void Mover(Moviment direcao)
        {
            Console.WriteLine($"O jogardor se moveu para: {direcao}");
        }
    }
}
