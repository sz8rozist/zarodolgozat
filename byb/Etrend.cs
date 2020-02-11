using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using byb.Modell;
using System.Diagnostics;
using byb.Repository;

namespace byb
{
    public partial class etrend : UserControl
    {
        Repo repo = new Repo();
        private DataTable etelekDT = new DataTable();
        public etrend()
        {
            InitializeComponent();
            panelEtelek.Visible = false;
            panelUjEtel.Visible = false;
            panelEtkezesek.Visible = false;
            panelUjEtkezes.Visible = false;

        }
        private void Etrend_Load(object sender, EventArgs e)
        {
            repo.setEtkezesek(repo.getEtkezesekAdatbazisbol());
            repo.setEtelek(repo.getEtelekAdatbazisbol());
        }
        public void feltoltComboboxEtelNevekkel()
        {
            comboBoxEtelNev.DataSource = repo.getEtelNevek();
        }
        public void frissitDGVEtelek()
        {
            etelekDT = repo.getListabolDataTable();
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = etelekDT;
        }
       
        public void beallitEtelekDGV()
        {
            etelekDT.Columns[0].ColumnName = "Név";
            etelekDT.Columns[1].ColumnName = "Kalória";
            etelekDT.Columns[2].ColumnName = "Fehérje";
            etelekDT.Columns[3].ColumnName = "Szénhidrát";
            etelekDT.Columns[4].ColumnName = "Zsír";
            etelekDT.Columns[5].ColumnName = "Mennyiség";

            dataGridViewEtelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        public void feltoltDGVEtkezesekEtrendekkel()
        {
            dataGridViewEtkezesek.DataSource = null;

            int azon = FormLogin.loggedID;

            Etrendek etrend = new Etrendek(
                azon,
                repo.getEtelek(),
                repo.getEtkezesek()
                );
            dataGridViewEtkezesek.DataSource = etrend.getEtrendDT();
            dataGridViewEtkezesek.Columns["idopont"].HeaderText = "Időpont";
            dataGridViewEtkezesek.Columns["enev"].HeaderText = "Étel";
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
        private void buttonEtelek_Click(object sender, EventArgs e)
        {
            panelEtelek.Visible = true;
            panelEtkezesek.Visible = false;
            //DGV adatainak frissítése
            frissitDGVEtelek();
            //DGV beállítása
            beallitEtelekDGV();
        }

        private void buttonEtkezesek_Click(object sender, EventArgs e)
        {
            panelEtelek.Visible = false;
            panelEtkezesek.Visible = true;
            feltoltComboboxEtelNevekkel();
            feltoltDGVEtkezesekEtrendekkel();

        }

        private void buttonTorolEtel_Click(object sender, EventArgs e)
        {
            if ((dataGridViewEtelek.Rows == null) ||
                (dataGridViewEtelek.Rows.Count == 0))
                return;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //1. törölni kell a listából
                //DGV - be kijelölt sor első cellájának az értéke (név) ami alapján törlünk.
                string nev = dataGridViewEtelek.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    repo.torolEtelListabol(nev);
                }
                catch (RepositoryException rex)
                {
                    Debug.WriteLine(rex.Message);
                    Debug.WriteLine("Az étel törlése nem sikerült.");
                }
                //2. törölni kell az adatbázisból
                try
                {
                    repo.torolEtelAdatbazisbol(nev);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                frissitDGVEtelek();

            }
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            panelUjEtel.Visible = true;
        }

        private void buttonUjMentes_Click(object sender, EventArgs e)
        {
            try
            {
                Etel ujetel = new Etel(
                    repo.getKovetkezoEtelID(),
                    EtelNev.Text,
                    Convert.ToInt32(textBoxKaloria.Text),
                    Convert.ToInt32(textBoxFeherje.Text),
                    Convert.ToInt32(textBoxSzenhidrat.Text),
                    Convert.ToInt32(textBoxZsir.Text),
                    textBoxMennyiseg.Text
                    );
                //hozzáadás listához
                repo.AddEtelListahoz(ujetel);
                //hozzáadás adatbázishoz
                repo.AddEtelAdatbazishoz(ujetel);
                //DGV frissítés
                EtelNev.Text = string.Empty;
                textBoxKaloria.Text = string.Empty;
                textBoxFeherje.Text = string.Empty;
                textBoxSzenhidrat.Text = string.Empty;
                textBoxZsir.Text = string.Empty;
                textBoxMennyiseg.Text = string.Empty;
                frissitDGVEtelek();
                
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Új Étel hozzáadás sikertelen");
            }
        }
        private void buttonMentesEtkezes_Click(object sender, EventArgs e)
        {

        }
        private void buttonMegse_Click(object sender, EventArgs e)
        {
            panelUjEtel.Visible = false;
        }

        private void buttonTorolEtkezes_Click(object sender, EventArgs e)
        {
            
        }



        private void buttonUjEtkezes_Click(object sender, EventArgs e)
        {
            panelUjEtkezes.Visible = true;
        }

        private void buttonEtkezesMegse_Click(object sender, EventArgs e)
        {
            panelUjEtkezes.Visible = false;
        }


    }
}
