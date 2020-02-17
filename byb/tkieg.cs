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
        public tkieg()
        {
            InitializeComponent();
        }
        public void feltoltDGVKiegek()
        {
            dataGridViewKiegek.DataSource = null;

            int azon = FormLogin.loggedID;

            TaplalekkiegeszitokViews tkieg = new TaplalekkiegeszitokViews(
                azon,
                repo.getTkiegek(),
                repo.getKiegek()
                );
            dataGridViewKiegek.DataSource = tkieg.getTkgViewDT();
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
            feltoltDGVKiegek();
        }

        private void tkieg_Load(object sender, EventArgs e)
        {
            repo.setKiegek(repo.getKiegekAdatbazisbol());
            repo.setTkiegek(repo.getHasznaltKiegeszitoAdatokAdatbazisbol());
        }
        public void ujKiegeszito()
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
            }
            catch (Exception ex)
            {
                    Debug.Write(ex.Message);
            }
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            ujKiegeszito();
            feltoltDGVKiegek();
        }
    }
}
