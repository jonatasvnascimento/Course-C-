using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    class Cl_carro : cl_veiculo
    {
        public int velocidade_maxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Carro acelerou");
        }

        public void LigarMotor()
        {

        }
        public override void Parar()
        {
            Console.WriteLine("Carro parou");
        }
    }
}
