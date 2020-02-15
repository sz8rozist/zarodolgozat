using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using byb.Repository;

namespace byb
{
    public partial class tkieg : UserControl
    {
        Repo repo = new Repo();
        private DataTable kiegekDT = new DataTable();
        public tkieg()
        {
            InitializeComponent();
        }
        public void beallitKiegekDGV()
        {
            kiegekDT.Columns[0].ColumnName = "K_ID";
            kiegekDT.Columns[1].ColumnName = "Név";
            kiegekDT.Columns[2].ColumnName = "Típus";
            kiegekDT.Columns[3].ColumnName = "Gyártó";
            kiegekDT.Columns[4].ColumnName = "Kiszerelés";
            kiegekDT.Columns[5].ColumnName = "Mértékegység";
            //kiegekDT.Columns[6].ColumnName = "F_ID";
            dataGridViewKiegek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKiegek.ReadOnly = true;
            dataGridViewKiegek.AllowUserToDeleteRows = false;
            dataGridViewKiegek.AllowUserToAddRows = false;
            dataGridViewKiegek.MultiSelect = false;
            dataGridViewKiegek.RowHeadersVisible = false;
            dataGridViewKiegek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKiegek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKiegek.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKiegek.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKiegek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKiegek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewKiegek.AllowUserToResizeRows = false;
            dataGridViewKiegek.AllowUserToResizeColumns = false;
            dataGridViewKiegek.EnableHeadersVisualStyles = false;
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewKiegek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void frissitDGVKiegek()
        {
            kiegekDT = repo.getKiegDT();
            dataGridViewKiegek.DataSource = null;
            dataGridViewKiegek.DataSource = kiegekDT;
        }

        private void buttonKiegek_Click(object sender, EventArgs e)
        {
            frissitDGVKiegek();
            beallitKiegekDGV();
            
        }

        private void tkieg_Load(object sender, EventArgs e)
        {
            repo.setKiegek(repo.getKiegekAdatbazisbol());
        }
    }
}
