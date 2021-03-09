using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrutorOverloarding
{
    class teste
    {
        string _nome;
        int _idade;
        public teste(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public void apresenta()
        {
            System.Windows.Forms.MessageBox.Show($"{_nome} > {_idade}");
        }
        public void apresenta(string separador)
        {
            System.Windows.Forms.MessageBox.Show($"{_nome} {separador} {_idade}");
        }
        public void apresenta(string separador, int idade)
        {
            System.Windows.Forms.MessageBox.Show($"{_nome} {separador} {idade}");
        }
    }
}
