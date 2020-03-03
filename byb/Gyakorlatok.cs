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
    public partial class Gyakorlatok : Form
    {
        Repo repo = new Repo();
        DataTable edzesDT = new DataTable();
        public Gyakorlatok()
        {
            InitializeComponent();
            repo.SetGyakorlatok(repo.getGyakorlatokFromDB());
            repo.setIzomcsoportok(repo.getIzomcsoportokFromDB());
            repo.setTervek(repo.getedzestervekFromDB());
            repo.setEdzesek(repo.getEdzesekFromDB());
            
            feltoltComboboxIdopontokkal();
            label1.Visible = false;
            dataGridViewEdzesek.Visible = false;
            
        }
        private void feltoltComboboxIdopontokkal()
        {
            comboBoxIdopont.DataSource = repo.getIdopontok(FormLogin.loggedID);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buildyourbody b = new Buildyourbody();
            b.Show();
            this.Hide();
        }
       
        private void beallitEdzesekDGV()
        {
            dataGridViewEdzesek.DataSource = null;
            string idopont = comboBoxIdopont.Text;
            dataGridViewEdzesek.DataSource = repo.getEdzesekViewraIdopontAlapjan(idopont);
            dataGridViewEdzesek.Columns[0].HeaderText = "Gyakorlat";
            dataGridViewEdzesek.Columns[1].HeaderText = "Sorozatszám";
            dataGridViewEdzesek.Columns[2].HeaderText = "Ismétlésszám";
            dataGridViewEdzesek.Columns[3].HeaderText = "Időpont";
            dataGridViewEdzesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEdzesek.ReadOnly = true;
            dataGridViewEdzesek.AllowUserToDeleteRows = false;
            dataGridViewEdzesek.AllowUserToAddRows = false;
            dataGridViewEdzesek.MultiSelect = false;
            dataGridViewEdzesek.RowHeadersVisible = false;
            dataGridViewEdzesek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEdzesek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEdzesek.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridViewEdzesek.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewEdzesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEdzesek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEdzesek.AllowUserToResizeRows = false;
            dataGridViewEdzesek.AllowUserToResizeColumns = false;
            dataGridViewEdzesek.EnableHeadersVisualStyles = false;
            dataGridViewEdzesek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEdzesek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEdzesek.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridViewEdzesek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void comboBoxIdopont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdopont.SelectedIndex < 0)
                return;
            dataGridViewEdzesek.Visible = true;
            label1.Visible = true;
            beallitEdzesekDGV();
        }

        private void Gyakorlatok_Load(object sender, EventArgs e)
        {
            repo.setListEdzesViewn(repo.getEdzesekViewra(FormLogin.loggedID, repo.getGyakorlatok(), repo.getTervek(), repo.getEdzesek()));
        }
    }
}
