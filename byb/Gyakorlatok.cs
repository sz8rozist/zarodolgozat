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
        public Gyakorlatok()
        {
            InitializeComponent();
            repo.SetGyakorlatok(repo.getGyakorlatokFromDB());
            repo.setIzomcsoportok(repo.getIzomcsoportokFromDB());
            repo.setTervek(repo.getedzestervekFromDB());
            repo.setEdzesek(repo.getEdzesekFromDB());
            feltoltComboboxGyakorlatokkal();
            feltoltComboboxIdopontokkal();
            dataGridViewGyakorlatok.Visible = false;
            dataGridViewEdzesek.Visible = false;

        }
        private void feltoltComboboxIdopontokkal()
        {
            comboBoxIdopont.DataSource = repo.getIdopontok();
        }
        private void feltoltComboboxGyakorlatokkal()
        {
            comboBox1.DataSource = repo.getIzomcsoportNevek();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buildyourbody b = new Buildyourbody();
            b.Show();
            this.Hide();
        }
        private void feltoltDGVGyakorlatokkal()
        {
            dataGridViewGyakorlatok.DataSource = null;
            string izomcsoport = comboBox1.Text;
            dataGridViewGyakorlatok.DataSource = repo.getGyakorlatIzomcsoportAlapjan(izomcsoport);
            dataGridViewGyakorlatok.Columns["gynev"].HeaderText = "Gyakorlat";
            dataGridViewGyakorlatok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGyakorlatok.Columns[0].Visible = false;
            dataGridViewGyakorlatok.Columns[2].Visible = false;
            dataGridViewGyakorlatok.Columns[3].Visible = false;
            dataGridViewGyakorlatok.ReadOnly = true;
            dataGridViewGyakorlatok.AllowUserToDeleteRows = false;
            dataGridViewGyakorlatok.AllowUserToAddRows = false;
            dataGridViewGyakorlatok.MultiSelect = false;
            dataGridViewGyakorlatok.RowHeadersVisible = false;
            dataGridViewGyakorlatok.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewGyakorlatok.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewGyakorlatok.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridViewGyakorlatok.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewGyakorlatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGyakorlatok.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewGyakorlatok.AllowUserToResizeRows = false;
            dataGridViewGyakorlatok.AllowUserToResizeColumns = false;
            dataGridViewGyakorlatok.EnableHeadersVisualStyles = false;
            dataGridViewGyakorlatok.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewGyakorlatok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewGyakorlatok.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridViewGyakorlatok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;
            dataGridViewGyakorlatok.Visible = true;
            feltoltDGVGyakorlatokkal();
        }

        private void comboBoxIdopont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdopont.SelectedIndex < 0)
                return;
            dataGridViewEdzesek.Visible = true;
        }
    }
}
