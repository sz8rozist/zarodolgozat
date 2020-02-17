﻿using System;
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
        public etrend()
        {
            InitializeComponent();
            panel1.Visible = false;

        }
        private void Etrend_Load(object sender, EventArgs e)
        {
            repo.setEtkezesek(repo.getEtkezesekAdatbazisbol());
            repo.setEtelek(repo.getEtelekAdatbazisbol());
        }
        public void frissítDGVEtrendek()
        {
            int azon = FormLogin.loggedID;
            Etrendek etrendek = new Etrendek(
                    azon,
                    repo.getEtelek(),
                    repo.getEtkezesek()
                    );
            dataGridViewEtrend.DataSource = null;
            dataGridViewEtrend.DataSource = etrendek.getEtrendDT();
        }
        public void feltoltDGVEtrendek()
        {
            dataGridViewEtrend.Columns["idopont"].HeaderText = "Időpont";
            dataGridViewEtrend.Columns["enev"].HeaderText = "Név";
            dataGridViewEtrend.Columns["feherje"].HeaderText = "Fehérj";
            dataGridViewEtrend.Columns["szenhidrat"].HeaderText = "Szénhidrát";
            dataGridViewEtrend.Columns["zsir"].HeaderText = "Zsír";
            dataGridViewEtrend.Columns["mennyiseg"].HeaderText = "Mennyiség";
            dataGridViewEtrend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtrend.ReadOnly = true;
            dataGridViewEtrend.AllowUserToDeleteRows = false;
            dataGridViewEtrend.AllowUserToAddRows = false;
            dataGridViewEtrend.MultiSelect = false;
            dataGridViewEtrend.RowHeadersVisible = false;
            dataGridViewEtrend.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEtrend.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEtrend.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewEtrend.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewEtrend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtrend.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewEtrend.AllowUserToResizeRows = false;
            dataGridViewEtrend.AllowUserToResizeColumns = false;
            dataGridViewEtrend.EnableHeadersVisualStyles = false;
            dataGridViewEtrend.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewEtrend.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEtrend.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEtrend.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void buttonEtkezesek_Click(object sender, EventArgs e)
        {
            frissítDGVEtrendek();
            feltoltDGVEtrendek();
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Etel ujetel = new Etel(
                textBoxEnev.Text,
               Convert.ToInt32( textBoxFeherje.Text),
                Convert.ToInt32(textBoxCh.Text),
                Convert.ToInt32(textBoxZs.Text),
                textBoxMennyiseg.Text
                
                );
            repo.AddEtelAdatbazishoz(ujetel);
            repo.AddEtelListahoz(ujetel);
            Etkezes ujetkezes = new Etkezes(
                    dateTimePickerIdopont.Text,
                    repo.getEtelIDEtkezeshez(),
                    FormLogin.loggedID
                   );
            repo.AddEtkezesAdatbazishoz(ujetkezes);
            repo.AddEtkezesListahoz(ujetkezes);
            frissítDGVEtrendek();
        }
    }
}
