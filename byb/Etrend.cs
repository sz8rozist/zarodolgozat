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
using byb.Modell;

namespace byb
{
    public partial class Etrend : UserControl
    {
        private Etelek etelekRepo = new Etelek();
        private DataTable etelekDT = new DataTable();
        public Etrend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Repoban lévő lista feltöltése adatbázis adatokkal
            etelekRepo.setEtelek(etelekRepo.getEtelekAdatbazisbol());
            //DGV adatainak frissítése
            frissitDGVEtelek();
            //DGV beállítása
            beallitEtelekDGV();
            
        }
        public void frissitDGVEtelek()
        {
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = etelekDT;
            etelekDT = etelekRepo.getListabolDataTable();
            
        }
        private void beallitEtelekDGV()
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
            dataGridViewEtelek.DefaultCellStyle.Font = new Font("Century Gothic",8);
            dataGridViewEtelek.AllowUserToResizeRows = false;
            dataGridViewEtelek.AllowUserToResizeColumns = false;
            dataGridViewEtelek.EnableHeadersVisualStyles = false;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtelek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEtelek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
