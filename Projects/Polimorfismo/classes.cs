using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
  abstract class forma_geometrica
    {
        int _largura;
        int _altura;

        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public void Apresentar()
        {
            Console.WriteLine("Esse metodo pertence a classe base.");
        }

        //Metodo a ser implementado nas demais classes
        public abstract void Desenhar();

        public virtual void Desenhar_Outro()
        {
            Console.WriteLine("Metodo virtual da classe base.");
        }


    }
    class rectangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar rectangulo com as dimenções {Largura}x{Altura}");
        }

        public override void Desenhar_Outro()
        {
            Console.WriteLine("Metodo substituido da classe derivada");
        }
    }
    class triangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar triangulo com as dimenções {Largura}x{Altura}");
        }
    }
    class circuferencia : forma_geometrica
    {   
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar circuferencia com as dimenções {Largura}x{Altura}");
        }
    }
}
