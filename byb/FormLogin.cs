﻿using byb.Database;
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
                timer1.Start();
                islogged = l.getUsername();
                loggedID = l.getLoginId();
                Buildyourbody b = new Buildyourbody();
                b.Show();
                this.Hide();
            }
            else
            {
                errorProviderLogin.SetError(buttonLogin, "Sikertelen Belépés!");
                //MessageBox.Show("Sikertelen Belépés", "Belépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
