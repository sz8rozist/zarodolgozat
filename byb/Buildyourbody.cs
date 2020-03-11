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
        Repo r = new Repo();
        public Buildyourbody()
        {
            InitializeComponent();
            label2.Text = FormLogin.islogged;

            panel2.Visible = false;
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
        }

        private void buttonTesztadatok_Click(object sender, EventArgs e)
        {
            db.tesztadatokFeltoltese();
        }

        private void buttonEtelek_Click(object sender, EventArgs e)
        {
            this.Hide();
            Etelek etelek = new Etelek();
            etelek.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
               
            }
        }

        private void buttonMutatBMIPanel_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            textBox1.Text = FormLogin.loggedTsuly.ToString();
            textBox3.Text = FormLogin.loggedTmagassag.ToString();
        }

        private void buttonSzamolBMI_Click(object sender, EventArgs e)
        {
            double tsuly = Convert.ToInt32(textBox1.Text);
            double tmagassag = Convert.ToInt32(textBox3.Text);
            double bmi = tsuly/(Math.Pow(tmagassag,2)/10000);
            double eredmeny = Math.Round(bmi, 1);
            textBox2.Text = eredmeny.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
