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
        CreateDatabase db = new CreateDatabase();
        public Buildyourbody()
        {
            InitializeComponent();
            label2.Text = FormLogin.islogged;

        }

        private void buttonEtrend_Click(object sender, EventArgs e)
        {
            Etrend d = new Etrend();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            db.torolTesztadatok();
        }

        private void buttonGyakorlatok_Click(object sender, EventArgs e)
        {
            Gyakorlatok gy = new Gyakorlatok();
            gy.Show();
            this.Hide();
        }

        private void buttonTesztadatok_Click(object sender, EventArgs e)
        {
            db.tesztadatokFeltoltese();
        }
    }
}
