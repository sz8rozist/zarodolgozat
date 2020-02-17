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
using System.Diagnostics;

namespace byb
{
    public partial class tkieg : UserControl
    {
        Repo repo = new Repo();
        private DataTable tkiegDT = new DataTable();
        public tkieg()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        public void frissítDGVTkiegekViewn()
        {
            tkiegDT = repo.getTkgViewDT();
            dataGridViewKiegek.DataSource = null;
            dataGridViewKiegek.DataSource = tkiegDT;
        }
        public void beallitDGVKiegek()
        {
            dataGridViewKiegek.Columns["knev"].HeaderText = "Név";
            dataGridViewKiegek.Columns["tipus"].HeaderText = "Típus";
            dataGridViewKiegek.Columns["gyarto"].HeaderText = "Gyártó";
            dataGridViewKiegek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKiegek.ReadOnly = true;
            dataGridViewKiegek.AllowUserToDeleteRows = false;
            dataGridViewKiegek.AllowUserToAddRows = false;
            dataGridViewKiegek.MultiSelect = false;
            dataGridViewKiegek.RowHeadersVisible = false;
            dataGridViewKiegek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKiegek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKiegek.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKiegek.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKiegek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKiegek.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewKiegek.AllowUserToResizeRows = false;
            dataGridViewKiegek.AllowUserToResizeColumns = false;
            dataGridViewKiegek.EnableHeadersVisualStyles = false;
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewKiegek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKiegek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonKiegek_Click(object sender, EventArgs e)
        {
            frissítDGVTkiegekViewn();
            beallitDGVKiegek();
        }

        private void tkieg_Load(object sender, EventArgs e)
        {
            repo.setKiegek(repo.getKiegekAdatbazisbol());
            repo.setTkiegek(repo.getHasznaltKiegeszitoAdatokAdatbazisbol());
            repo.setTkiegView(repo.getTapkiegekListakbolUIDAlapjan(FormLogin.loggedID,repo.getTkiegek(),repo.getKiegek()));
        }
        private void buttonUj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                KiegAdat ujka = new KiegAdat(
                           textBoxKnev.Text,
                           textBoxKTipus.Text,
                           textBoxKgyarto.Text);
                repo.AddUjKiegAdatDB(ujka);
                repo.addUjKiegAdatListahoz(ujka);
                Kiegeszito ujkieg = new Kiegeszito(
                        repo.getKiegIDKiegeszitoTablaba(),
                        FormLogin.loggedID);
                repo.AddujKieg(ujkieg);
                repo.addUjKiegeszitoListahoz(ujkieg);
                TaplalekkiegeszitokView tkv = new TaplalekkiegeszitokView(
                        textBoxKnev.Text,
                        textBoxKTipus.Text,
                        textBoxKgyarto.Text
                    );
                repo.addTkiegViewList(tkv);
                frissítDGVTkiegekViewn();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
