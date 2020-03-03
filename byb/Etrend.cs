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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byb
{
    public partial class Etrend : Form
    {
        Repo repo = new Repo();
        DataTable etelekDT = new DataTable();
        public Etrend()
        {
            InitializeComponent();
            repo.setEtelek(repo.getEtelekFromDB());
            repo.setEtkezesek(repo.getEtkezesekFromDB());
            dataGridViewEtkezesek.Visible = false;
            label1.Visible = false;
            repo.setEtkezesekViewn(repo.getEtkezesekViewraFelhasznaloAlapjan(FormLogin.loggedID, repo.getEtelek(), repo.getEtkezesek()));
          
        }

        private void frissitEtkezesekDGV()
        {
            dataGridViewEtkezesek.DataSource = null;
            dataGridViewEtkezesek.DataSource = repo.getEtkezesekViewFelhasznaloAlapjanDT();
        }
        private void beallitEtkezesekDGV()
        {
            dataGridViewEtkezesek.Columns["etkezesek_id"].HeaderText = "ÉtkezésID";
            dataGridViewEtkezesek.Columns["enev"].HeaderText = "Étel";
            dataGridViewEtkezesek.Columns["idopont"].HeaderText = "Időpont";
            dataGridViewEtkezesek.Columns["feherje"].HeaderText = "Fehérje";
            dataGridViewEtkezesek.Columns["szenhidrat"].HeaderText = "Szénhidrát";
            dataGridViewEtkezesek.Columns["zsir"].HeaderText = "Zsír";
            dataGridViewEtkezesek.Columns["mennyiseg"].HeaderText = "Mennyiség";
            dataGridViewEtkezesek.Columns[0].Visible = false;
            dataGridViewEtkezesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtkezesek.ReadOnly = true;
            dataGridViewEtkezesek.AllowUserToDeleteRows = false;
            dataGridViewEtkezesek.AllowUserToAddRows = false;
            dataGridViewEtkezesek.MultiSelect = false;
            dataGridViewEtkezesek.RowHeadersVisible = false;
            dataGridViewEtkezesek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEtkezesek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEtkezesek.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridViewEtkezesek.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewEtkezesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtkezesek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEtkezesek.AllowUserToResizeRows = false;
            dataGridViewEtkezesek.AllowUserToResizeColumns = false;
            dataGridViewEtkezesek.EnableHeadersVisualStyles = false;
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtkezesek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buildyourbody b = new Buildyourbody();
            b.Show();
            this.Hide();
        }

        private void buttonEtkezesek_Click(object sender, EventArgs e)
        {
            dataGridViewEtkezesek.Visible = true;
            label1.Visible = true;
            frissitEtkezesekDGV();
            beallitEtkezesekDGV();
        }
    }
}
