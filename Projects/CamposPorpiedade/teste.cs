using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamposPorpiedade
{
    class teste
    {
        string _nome;

        public string Nome
        {

            set
            { 
                if (_nome == "teste")
                {
                    _nome = value;
                }else
                {
                    System.Windows.Forms.MessageBox.Show("");
                }
                
            }
            get { return _nome; }
        }

        public void apresentar()
        {
            System.Windows.Forms.MessageBox.Show(Nome);
        }
    }
}
