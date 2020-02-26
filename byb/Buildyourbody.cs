using byb.Database;
using byb.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byb
{
    public partial class Buildyourbody : Form
    {
       
        public Buildyourbody()
        {
            InitializeComponent();
            label2.Text = FormLogin.islogged;
            etrend1.SendToBack();
        }
        private void buttonKezdolap_Click(object sender, EventArgs e)
        {
            etrend1.SendToBack();
        }

        private void buttonEdzes_Click(object sender, EventArgs e)
        {
        }

        private void buttonEtrend_Click(object sender, EventArgs e)
        {
            etrend1.BringToFront();
        }

        private void buttonKieg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
