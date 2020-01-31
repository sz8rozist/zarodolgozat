using byb.Database;
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
            formIndulaskor();
            label2.Text = FormLogin.islogged;
        }
        public void formIndulaskor()
        {
            home1.BringToFront();
            buttonKezdolap.BackColor = Color.DarkSlateGray;
            Logo.Visible = false;
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (panelSlideMenu.Height == 538 && panelSlideMenu.Width == 45)
            {
                panelSlideMenu.Height = 538;
                panelSlideMenu.Width = 218;
                Logo.Visible = true;
            }
            else
            {
                panelSlideMenu.Height = 538;
                panelSlideMenu.Width = 45;
                Logo.Visible = false;
            }
        }

        private void buttonKezdolap_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
            buttonKezdolap.BackColor = Color.DarkSlateGray;
            buttonEdzes.BackColor = Color.FromArgb(27, 32, 49);
            buttonEtrend.BackColor = Color.FromArgb(27, 32, 49);
            buttonKieg.BackColor = Color.FromArgb(27, 32, 49);
        }


        private void buttonEdzes_Click(object sender, EventArgs e)
        {
            buttonEdzes.BackColor = Color.DarkSlateGray;
            buttonEtrend.BackColor = Color.FromArgb(27, 32, 49);
            buttonKieg.BackColor = Color.FromArgb(27, 32, 49);
            buttonKezdolap.BackColor = Color.FromArgb(27, 32, 49);
        }

        private void buttonEtrend_Click(object sender, EventArgs e)
        {
            buttonEtrend.BackColor = Color.DarkSlateGray;
            buttonEdzes.BackColor = Color.FromArgb(27, 32, 49);
            buttonKieg.BackColor = Color.FromArgb(27, 32, 49);
            buttonKezdolap.BackColor = Color.FromArgb(27, 32, 49);
        }

        private void buttonKieg_Click(object sender, EventArgs e)
        {
            buttonKieg.BackColor = Color.DarkSlateGray;
            buttonEtrend.BackColor = Color.FromArgb(27, 32, 49);
            buttonEdzes.BackColor = Color.FromArgb(27, 32, 49);
            buttonKezdolap.BackColor = Color.FromArgb(27, 32, 49);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
