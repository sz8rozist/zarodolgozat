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
        private int ImageNumber = 1;
        public Buildyourbody()
        {
            InitializeComponent();
            formIndulaskor();
            label2.Text = FormLogin.islogged;
        }
        private void Slider()
        {
            if(ImageNumber == 5)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        public void formIndulaskor()
        {
            etrend2.SendToBack();
            tkieg1.SendToBack();
        }

        private void buttonKezdolap_Click(object sender, EventArgs e)
        {
            etrend2.SendToBack();
            tkieg1.SendToBack();
        }


        private void buttonEdzes_Click(object sender, EventArgs e)
        {
        }

        private void buttonEtrend_Click(object sender, EventArgs e)
        {
            etrend2.BringToFront();
        }

        private void buttonKieg_Click(object sender, EventArgs e)
        {
            tkieg1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }
    }
}
