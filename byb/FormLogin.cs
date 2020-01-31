using byb.Database;
using byb.Modell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byb
{
    public partial class FormLogin : Form
    {
        public static string islogged = "";
        public FormLogin()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            trd.Abort();
            pwd.PasswordChar = '*';
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void formRun()
        {
            Application.Run(new FormLoad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Felhasznalo fl = new Felhasznalo(username.Text, pwd.Text);
            if(fl.loginCheck() == true)
            {
                panel5.Visible = true;
                timer1.Start();
                islogged = fl.getFname();
            }
            else
            {
                MessageBox.Show("Sikertelen Belépés", "Belépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                panel5.Visible = false;
            }
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel5.Width += 4;
            if(panel5.Width >= 273)
            {
                timer1.Stop();
                Buildyourbody b = new Buildyourbody();
                b.Show();
                this.Hide();

            }
            
        }
    }
}
