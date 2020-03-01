using byb.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byb
{
    public partial class Gyakorlatok : Form
    {
        Repo repo = new Repo();
        public Gyakorlatok()
        {
            InitializeComponent();
            try
            {
                repo.SetGyakorlatok(repo.getGyakorlatokFromDB());
                repo.setIzomcsoportok(repo.getIzomcsoportokFromDB());
            }catch(RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buildyourbody b = new Buildyourbody();
            b.Show();
            this.Hide();
        }
    }
}
