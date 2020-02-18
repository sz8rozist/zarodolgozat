using byb.Database;
using byb.Modell;
using byb.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byb
{
    public  partial class FormLogin : Form
    {
        public static string islogged = "";
        public static int loggedID = 0;
        Repo repo = new Repo();
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
            errorProviderLogin.Clear();
            
            Login l = new Login(username.Text, pwd.Text);
            if(l.loginCheck() == true)
            {
                panel5.Visible = true;
                timer1.Start();
                islogged = l.getUsername();
                loggedID = l.getLoginId();

            }
            else
            {
                errorProviderLogin.SetError(button1, "Sikertelen Belépés!");
                //MessageBox.Show("Sikertelen Belépés", "Belépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
