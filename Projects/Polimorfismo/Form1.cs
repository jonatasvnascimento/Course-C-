using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangulo forma1 = new rectangulo();
            forma1.Altura = 100;
            forma1.Largura = 50;
            forma1.Apresentar();
            forma1.Desenhar();
            forma1.Desenhar_Outro();

            triangulo forma2 = new triangulo();
            forma2.Altura = 170;
            forma2.Largura = 150;
            forma2.Apresentar();
            forma2.Desenhar();
            forma2.Desenhar_Outro();

            circuferencia forma3 = new circuferencia();
            forma3.Altura = 200;
            forma3.Largura = 350;
            forma3.Apresentar();
            forma3.Desenhar();
            forma3.Desenhar_Outro();
        }
    }
}
