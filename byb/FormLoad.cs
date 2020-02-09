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
    public partial class FormLoad : Form
    {
        CreateDatabase db = new CreateDatabase();
        Repo repo = new Repo();
        public int move = 2;
        public FormLoad()
        {
            InitializeComponent();
            db.createDataBase();
            db.createDataBaseTable();
            db.tesztadatokFeltoltese();
            repo.setFelhasznalok(repo.getFelhasznalokAdatbazisbol());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if(panelSlide.Left> 325)
            {
                panelSlide.Left = 0;
            }
            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
