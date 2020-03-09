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
        public static int loggedTsuly = 0;
        public static int loggedTmagassag = 0;
        public FormLogin()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            trd.Abort();
            pwd.PasswordChar = '*';
            timer1.Start();
        }

        private void formRun()
        {
            Application.Run(new FormLoad());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();

            Login l = new Login(username.Text, pwd.Text);
            if (l.loginCheck() == true)
            {
                islogged = l.getUsername();
                loggedID = l.getLoginId();
                loggedTsuly = l.Tsuly;
                loggedTmagassag = l.Tmagassag;
                FormSucces fs = new FormSucces("Sikeres Bejelentkezés!");
                DialogResult result = fs.ShowDialog();
                if(result == DialogResult.OK)
                {
                    Buildyourbody b = new Buildyourbody();
                    b.Show();
                    this.Hide();
                    fs.Hide();
                }

            }
            else
            {
                FormError fe = new FormError("Sikertelen bejelentkezés!");
                DialogResult result = fe.ShowDialog();
                if(result == DialogResult.OK)
                {
                    fe.Hide();
                }
                
                //errorProviderLogin.SetError(buttonLogin, "Sikertelen Belépés!");
                //MessageBox.Show("Sikertelen Belépés", "Belépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}
