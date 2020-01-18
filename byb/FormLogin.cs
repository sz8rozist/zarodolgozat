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
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
        }

        private void formRun()
        {
            Application.Run(new FormLoad());
        }
    }
}
