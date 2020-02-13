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
        CreateDatabase cd = new CreateDatabase();
        Repo r = new Repo();
        public Buildyourbody()
        {
            InitializeComponent();
            formIndulaskor();
            label2.Text = FormLogin.islogged;
        }
        public void formIndulaskor()
        {
            home2.BringToFront();
            Slidepanel.Height = buttonKezdolap.Height;
            Slidepanel.Top = buttonKezdolap.Top;
        }

        private void buttonKezdolap_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = buttonKezdolap.Height;
            Slidepanel.Top = buttonKezdolap.Top;
            home2.BringToFront();
        }


        private void buttonEdzes_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = buttonEdzes.Height;
            Slidepanel.Top = buttonEdzes.Top;
        }

        private void buttonEtrend_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = buttonEtrend.Height;
            Slidepanel.Top = buttonEtrend.Top;
            etrend2.BringToFront();
        }

        private void buttonKieg_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = buttonKieg.Height;
            Slidepanel.Top = buttonKieg.Top;
            tkieg1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
