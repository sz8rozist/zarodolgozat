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
            panelEtel.Visible = false;
            buttonSaveUjEtel.Visible = false;
            panelEtkezes.Visible = false;
            buttonUjEtel.Visible = false;
            buttonUjEtkezes.Visible = false;
        }
        public void beallitDataGridView()
        {
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = r.getEtelEtelNevAlapjan(textBox1.Text);
            dataGridViewEtelek.Columns["feherje"].HeaderText = "Fehérje";
            dataGridViewEtelek.Columns["szenhidrat"].HeaderText = "Szénhidrát";
            dataGridViewEtelek.Columns["zsir"].HeaderText = "Zsír";
            dataGridViewEtelek.Columns["kaloria"].HeaderText = "Kalória";
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
            buttonUjEtel.Visible = true;
            buttonUjEtkezes.Visible = true;
        }

        private void dataGridViewEtelek_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridViewEtelek.SelectedRows.Count == 1)
            {
                panelEtel.Visible = true;
                textBoxEtelNev.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[1].Value.ToString();
                Feherje.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[4].Value.ToString();
                textBoxCh.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[3].Value.ToString();
                textBoxZsir.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[5].Value.ToString();
                textBoxKaloria.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[2].Value.ToString();
                textBoxMennyiseg.Text =
                    dataGridViewEtelek.SelectedRows[0].Cells[6].Value.ToString();
            }
            
        }

        private void buttonUjEtel_Click(object sender, EventArgs e)
        {
            textBoxCh.Text = string.Empty;
            textBoxEtelNev.Text = string.Empty;
            Feherje.Text = string.Empty;
            textBoxKaloria.Text = string.Empty;
            textBoxMennyiseg.Text = string.Empty;
            textBoxZsir.Text = string.Empty;
            buttonSaveUjEtel.Visible = true;
            
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
                panelEtel.Visible = false;
                fs.Hide();
            }
        }

        private void buttonUjEtkezes_Click(object sender, EventArgs e)
        {
            panelEtkezes.Visible = true;
        }

        private void buttonSaveUjEtkezes_Click(object sender, EventArgs e)
        {
            if (dataGridViewEtelek.SelectedRows.Count != 1)
            {
                FormError fe = new FormError("Nincs kiválasztva étel!");
                DialogResult result = fe.ShowDialog();
                if (result == DialogResult.OK)
                    fe.Hide();
            }
            int etelid = Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[0].Value);
            Etkezes ujEtkezes = new Etkezes(
                    dateTimePickerIdopont.Text,
                    etelid,
                    FormLogin.loggedID
                );
            string etelnev = dataGridViewEtelek.SelectedRows[0].Cells[1].Value.ToString();
            int feherje = Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[4].Value);
            int szenhidrat = Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[3].Value);
            int zsir = Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[5].Value);
            int kaloria = Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[2].Value);
            string mennyiseg = dataGridViewEtelek.SelectedRows[0].Cells[6].Value.ToString();
            EtkezesView ev = new EtkezesView(
                    etelnev,
                    dateTimePickerIdopont.Text,
                    feherje,
                    szenhidrat,
                    zsir,
                    kaloria,
                    mennyiseg
                );
            //Beszúrás az adatbázisba
            r.insertEtkezesToDatabase(ujEtkezes);
            r.addEtkezesViewnToLIst(ev);
            //Beszúrás a listába
            r.addEtkezesToList(ujEtkezes);
            FormSucces fs = new FormSucces("Sikeres Mentés!");
            DialogResult resultt = fs.ShowDialog();
            if (resultt == DialogResult.OK)
            {
                fs.Hide();
            }
        }
    }
}
