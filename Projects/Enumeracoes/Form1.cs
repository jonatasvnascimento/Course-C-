using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        teste jogador;
        public Form1()
        {
            InitializeComponent();
            jogador = new teste();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cima_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Moviment.cima);
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Moviment.direita);

        }

        private void btn_baixo_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Moviment.baixo);

        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Moviment.esquerda);

        }
    }
}
