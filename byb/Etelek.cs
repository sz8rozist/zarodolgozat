using byb.Modell;
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
    public partial class Etelek : Form
    {
        Repo r = new Repo();
        public Etelek()
        {
            InitializeComponent();
            r.setEtelek(r.getEtelekFromDB());
            dataGridViewEtelek.Visible = false;
            panel1.Visible = false;
        }
        public void beallitDataGridView()
        {
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = r.getEtelEtelNevAlapjan(textBox1.Text);
            dataGridViewEtelek.Columns["feherje"].HeaderText = "Fehérje";
            dataGridViewEtelek.Columns["szenhidrat"].HeaderText = "Szénhidrát";
            dataGridViewEtelek.Columns["zsir"].HeaderText = "Zsír";
            dataGridViewEtelek.Columns["kaloria"].HeaderText = "Zsír";
            dataGridViewEtelek.Columns["mennyiseg"].HeaderText = "Mennyiség";
            dataGridViewEtelek.Columns[0].Visible = false;
            dataGridViewEtelek.Columns[1].Visible = false;
            dataGridViewEtelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtelek.ReadOnly = true;
            dataGridViewEtelek.AllowUserToDeleteRows = false;
            dataGridViewEtelek.AllowUserToAddRows = false;
            dataGridViewEtelek.MultiSelect = false;
            dataGridViewEtelek.RowHeadersVisible = false;
            dataGridViewEtelek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEtelek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEtelek.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridViewEtelek.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewEtelek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtelek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEtelek.AllowUserToResizeRows = false;
            dataGridViewEtelek.AllowUserToResizeColumns = false;
            dataGridViewEtelek.EnableHeadersVisualStyles = false;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtelek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buildyourbody b = new Buildyourbody();
            b.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beallitDataGridView();
            dataGridViewEtelek.Visible = true;
            
            
        }

        private void dataGridViewEtelek_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonUjEtel_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonSaveUjEtel_Click(object sender, EventArgs e)
        {
            Etel ujEtel = new Etel(
                    textBoxEtelNev.Text,
                    Convert.ToInt32(Feherje.Text),
                    Convert.ToInt32(textBoxCh.Text),
                    Convert.ToInt32(textBoxZsir.Text),
                    Convert.ToInt32(textBoxKaloria.Text),
                    textBoxMennyiseg.Text
                );
            //Beszúrás listába
            r.addEtelToList(ujEtel);
            //Beszúrás adatbázisba
            r.insertEtelToDatabase(ujEtel);
            //Frissít DataGridView
            beallitDataGridView();
            FormSucces fs = new FormSucces("Sikeres Mentés!");
            DialogResult result = fs.ShowDialog();
            if (result == DialogResult.OK)
            {
                panel1.Visible = false;
                fs.Hide();
            }
        }
    }
}
