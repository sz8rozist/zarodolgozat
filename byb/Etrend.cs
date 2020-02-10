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
    public partial class Etrend : UserControl
    {
        Repo repo = new Repo();
        private DataTable etkezesekDT = new DataTable();
        private DataTable etelekDT = new DataTable();
        public Etrend()
        {
            InitializeComponent();
            panelEtelek.Visible = false;
        }
        public void frissitDGVEtelek()
        {
            etelekDT = repo.getListabolDataTable();
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = etelekDT;
        }
        public void frissitDGVEtkezesek()
        {
            etkezesekDT = repo.getEtkezesDTListabol();
            dataGridViewEtkezesek.DataSource = null;
            dataGridViewEtkezesek.DataSource = etkezesekDT;
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
        public void beallitEtkezesekDGV()
        {
            etkezesekDT.Columns[0].ColumnName = "Időpont";
            etkezesekDT.Columns[1].ColumnName = "Étel ID";

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
            repo.setEtelek(repo.getEtelekAdatbazisbol());
            //DGV adatainak frissítése
            frissitDGVEtelek();
            //DGV beállítása
            beallitEtelekDGV();
        }

        private void buttonEtkezesek_Click(object sender, EventArgs e)
        {
            panelEtelek.Visible = false;
            repo.setEtkezesek(repo.getEtkezesekAdatbazisbol());
            frissitDGVEtkezesek();
            beallitEtkezesekDGV();
        }

        private void buttonTorolEtel_Click(object sender, EventArgs e)
        {
            if ((dataGridViewEtelek.Rows == null) ||
                (dataGridViewEtelek.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewEtelek.SelectedRows[0].Index;
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
    }
}
