using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    abstract class cl_veiculo
    {
        public string cor { get; set; }
        public string marca { get; set; }
        abstract public void Acelerar();

        public virtual void Parar()
        {
            Console.WriteLine("Parou.");
        }


    }
}
