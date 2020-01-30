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
        public FormLogin()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            trd.Abort();
        }

        private void formRun()
        {
            Application.Run(new FormLoad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginCheck lc = new LoginCheck();
            lc.uname = username.Text;
            lc.pwd = pwd.Text;
            if(lc.loginCheck() == true)
            {
                Buildyourbody b = new Buildyourbody();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sikertelen Belépés", "Belépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
