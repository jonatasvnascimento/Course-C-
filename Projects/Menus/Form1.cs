using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Add opções so menu_combo1*/
            menu_combo_1.Items.Add("Valor 1");
            menu_combo_1.Items.Add("Valor 2");
            menu_combo_1.Items.Add("Valor 3");
            menu_combo_1.Items.Add("Valor 4");
            menu_combo_1.Items.Add("Valor 5");


        }

        private void menu_combo_1_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_combo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_combo_1.Text == "Valor 1")
                MessageBox.Show("Valor 1");

            label_resultado.Text = menu_combo_1.Text;
        }
    }
}
