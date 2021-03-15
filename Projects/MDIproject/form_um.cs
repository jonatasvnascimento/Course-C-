using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIproject
{
    public partial class form_um : Form
    {
        public form_um(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;

            int altura = formParent.DisplayRectangle.Height;
            int larguta = formParent.DisplayRectangle.Width;

            //MessageBox.Show($"{altura.ToString()} x {larguta.ToString()}");

            this.Location = new Point(larguta / 2 - this.Width / 2,
                altura / 2 - this.Height / 2);
        }

        private void form_um_Load(object sender, EventArgs e)
        {

        }
    }
}
