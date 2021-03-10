using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    class cl_bicicleta: cl_veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Bicicleta acelerou");
        }
        public void Pedalar()
        {

        }

      
    }
}
