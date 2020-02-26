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
            panel1.Visible = false;
            panel2.Visible = false;
            repo.setEtelek(repo.getEtelekFromDB());
            repo.setEtkezesek(repo.getEtkezesekFromDB());
            repo.setEtkezesekViewn(repo.getEtkezesekViewraFelhasznaloAlapjan(FormLogin.loggedID, repo.getEtelek(), repo.getEtkezesek()));
            frissitEtelDGV();
            beallitEtelDGV();
            frissitEtkezesekDGV();
            beallitEtkezesekDGV();
        }
        private void frissitEtelDGV()
        {
            etelekDT = repo.EtelDataTableEtelekListabol();
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = etelekDT;
        }
        private void beallitEtelDGV()
        {
            etelekDT.Columns[0].ColumnName = "Azonosító";
            etelekDT.Columns[1].ColumnName = "Étel";

            dataGridViewEtelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtelek.Columns[0].Visible = false;
            dataGridViewEtelek.ReadOnly = true;
            dataGridViewEtelek.AllowUserToDeleteRows = false;
            dataGridViewEtelek.AllowUserToAddRows = false;
            dataGridViewEtelek.MultiSelect = false;
            dataGridViewEtelek.RowHeadersVisible = false;
            dataGridViewEtelek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEtelek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEtelek.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewEtelek.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewEtelek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtelek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEtelek.AllowUserToResizeRows = false;
            dataGridViewEtelek.AllowUserToResizeColumns = false;
            dataGridViewEtelek.EnableHeadersVisualStyles = false;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtelek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
            dataGridViewEtkezesek.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewEtkezesek.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewEtkezesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtkezesek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEtkezesek.AllowUserToResizeRows = false;
            dataGridViewEtkezesek.AllowUserToResizeColumns = false;
            dataGridViewEtkezesek.EnableHeadersVisualStyles = false;
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtkezesek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEtkezesek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonUjEtel_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void buttonBezarUjEtel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void buttonBezarUjEtkezes_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        public void buttonEtkezesTorles_Click(object sender, EventArgs e)
        {

            FormMessage fm = new FormMessage("Biztos törölni szeretnél?");
            DialogResult result = fm.ShowDialog();
            fm.Show();
            if(result == DialogResult.OK)
            {
                //DataGridViewba kijelölt sor első cellájának az értéke
                int etkezesid = Convert.ToInt32(dataGridViewEtkezesek.SelectedRows[0].Cells[0].Value);
                //törlés listákból
                try
                {
                    repo.TorolEtkezesListabol(etkezesid);
                }
                catch (TorlesEtkezesException tee)
                {
                    Debug.WriteLine(tee.Message);
                }
                try
                {
                    repo.TorolEtkezesekViewListabol(etkezesid);
                }
                catch (TorlesEtkezesekViewnException teve)
                {
                    Debug.WriteLine(teve.Message);
                }
                //törlés adatbázisból
                repo.DeletEtkezes(etkezesid);
                //frissít datagridview
                frissitEtkezesekDGV();
                beallitEtkezesekDGV();
                fm.Hide();
            }
            else
            {
                fm.Hide();
            }
            

        }
        private void buttonMentesUjEtel_Click(object sender, EventArgs e)
        {
            Etel ujEtel = new Etel(repo.getKovetkezoEtelID(), textBoxEtelNev.Text);
            //hozzáadás listához
            try
            {
                repo.AddEtelListahoz(ujEtel);
            }
            catch (EtelekAddListahozException eale)
            {
                Debug.WriteLine(eale.Message);
            }
            //beszúrás adatbázisba
            repo.InsertEtelek(ujEtel);
            //datagridview frissítése
            frissitEtelDGV();
            beallitEtelDGV();
            textBoxEtelNev.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Etkezes ujEtkezes = new Etkezes(
                repo.KovetkezoEtkezesID(),
                dateTimePickerIdopont.Text,
                repo.getEtelNevhezID(textBoxEtel.Text),
                Convert.ToInt32(textBoxFeherje.Text),
                Convert.ToInt32(textBoxCh.Text),
                Convert.ToInt32(textBoxZs.Text),
                textBoxMennyiseg.Text,
                FormLogin.loggedID
                );
            EtkezesView ev = new EtkezesView(
                repo.KovetkezoEtkezesID(),
                textBoxEtel.Text,
                dateTimePickerIdopont.Text,
                Convert.ToInt32(textBoxFeherje.Text),
                Convert.ToInt32(textBoxCh.Text),
                Convert.ToInt32(textBoxZs.Text),
                textBoxMennyiseg.Text
                );
            //hozzáadás listához
            try
            {
                repo.AddEtkezesListahoz(ujEtkezes);
            }
            catch (EtkezesekAddListahozException etale)
            {
                Debug.WriteLine(etale.Message);
            }
            try
            {
                repo.addEtkezesekViewListahoz(ev);
            }
            catch (EtkezesekViewnAddListahozException evale)
            {
                Debug.WriteLine(evale.Message);
            }
            //beszúrás adatbázisba
            repo.InsertEtkezes(ujEtkezes);
            //DataGridView frissítés
            frissitEtkezesekDGV();
            beallitEtkezesekDGV();
            textBoxEtel.Text = string.Empty;
            textBoxCh.Text = string.Empty;
            textBoxFeherje.Text = string.Empty;
            textBoxZs.Text = string.Empty;
            textBoxMennyiseg.Text = string.Empty;
        }

        private void dataGridViewEtelek_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEtelek.SelectedRows.Count == 1)
            {
                textBoxEtel.Text = dataGridViewEtelek.SelectedRows[0].Cells[1].Value.ToString();
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
