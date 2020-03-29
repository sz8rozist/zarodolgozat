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
    public partial class Etelek : Form
    {
        Repo r = new Repo();
        public Etelek()
        {
            InitializeComponent();
            r.setEtelek(r.getEtelekFromDB());
            dataGridViewEtelek.Visible = false;
            panelEtel.Visible = false;
            panelEtkezes.Visible = false;
            buttonUjEtel.Visible = false;
            buttonUjEtkezes.Visible = false;
            buttonDeleteEtel.Visible = false;
            label10.Visible = false;
            feltoltComboboxEtelek();
        }
        public void feltoltComboboxEtelek()
        {
            comboBoxEtel.DataSource = r.getEtelNevek();
        }
        public void beallitDataGridView()
        {
            dataGridViewEtelek.DataSource = null;
            dataGridViewEtelek.DataSource = r.getEtelEtelNevAlapjan(comboBoxEtel.Text);
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

        private void buttonUjEtel_Click(object sender, EventArgs e)
        {

            panelEtel.Visible = true;
            
        }

        private void buttonSaveUjEtel_Click(object sender, EventArgs e)
        {
            errorProviderMindenMezo.Clear();
            errorProviderEtelNev.Clear();
            errorProviderFeherje.Clear();
            errorProviderEnevFirstLetter.Clear();
            errorProviderMennyiseg.Clear();
            try
            {
              
               
                if(textBoxEtelNev.Text == string.Empty || Feherje.Text == string.Empty || textBoxCh.Text == string.Empty || textBoxZsir.Text == string.Empty || textBoxKaloria.Text == string.Empty || textBoxMennyiseg.Text == string.Empty)
                {
                    errorProviderMindenMezo.SetError(buttonSaveUjEtel, "Minden mező kitöltése kötelező!");
                }
                else
                {
                    Etel ujEtel = new Etel(
                   r.getNextEtelID(),
                   textBoxEtelNev.Text,
                 Convert.ToInt32(Feherje.Text),
                 Convert.ToInt32(textBoxCh.Text),
                 Convert.ToInt32(textBoxZsir.Text),
                 Convert.ToInt32(textBoxKaloria.Text),
                 textBoxMennyiseg.Text
                   );
                    if (!ujEtel.validate())
                    {
                        return;
                    }
                    else
                    {
                        //Beszúrás listába
                        r.addEtelToList(ujEtel);
                        //Beszúrás adatbázisba
                        r.insertEtelToDatabase(ujEtel);
                        //Frissít DataGridView
                        beallitDataGridView();
                        FormSucces fs = new FormSucces("Étel mentése sikeres!");
                        DialogResult result = fs.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            panelEtel.Visible = false;
                            fs.Hide();
                            feltoltComboboxEtelek();
                        }
                    }
                }
                
            }
            catch(ValidateMindenMezoKitoltveException vmmke)
            {
                errorProviderMindenMezo.SetError(buttonSaveUjEtel, vmmke.Message);
            }
            catch(ValidateEtelNevIsEmpty vme)
            {
                errorProviderEtelNev.SetError(textBoxEtelNev, vme.Message);
            }
            catch (ValidateEnevFirstLetterUpperCaseException vefluce)
            {
                errorProviderEnevFirstLetter.SetError(textBoxEtelNev, vefluce.Message);
            }
            catch (ValidateFeherjeIsNegative vmee)
            {
                errorProviderFeherje.SetError(Feherje, vmee.Message);
            }
            catch(ValidateMennyisegFirstLetterIsNumberException vefine)
            {
                errorProviderMennyiseg.SetError(textBoxMennyiseg, vefine.Message);
            }
            catch(ValidateMennyisegContainBetuException vmcbe)
            {
                errorProviderMennyiseg.SetError(textBoxMennyiseg, vmcbe.Message);
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
            FormSucces fs = new FormSucces("Sikeres étkezés hozzáadás");
            DialogResult resultt = fs.ShowDialog();
            if (resultt == DialogResult.OK)
            {
                fs.Hide();
            }
        }

        private void comboBoxEtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            beallitDataGridView();
            dataGridViewEtelek.Visible = true;
            buttonUjEtel.Visible = true;
            buttonUjEtkezes.Visible = true;
            label10.Visible = true;
            buttonDeleteEtel.Visible = true;
        }
        private void buttonDeleteEtel_Click(object sender, EventArgs e)
        {
            if (dataGridViewEtelek.Rows == null || dataGridViewEtelek.Rows.Count == 0)
            {
                FormError fe = new FormError("Ooops...hiba történt!");
                DialogResult dr = fe.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    fe.Hide();
                }
            }
            else
            {
                FormMessage fm = new FormMessage("Biztos törölni szeretnél?");
                DialogResult result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fm.Hide();
                    try
                    {
                        //Törlés adatbázisból
                        r.deleteEtelFromDataBase(Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[0].Value));
                        //Törlés listából
                        r.deleteEtelFromList(Convert.ToInt32(dataGridViewEtelek.SelectedRows[0].Cells[0].Value));
                    }
                    catch(RepositoryException ex)
                    {
                        Debug.WriteLine(ex.Message);
                        FormError fe = new FormError("Sikertelen törlés, az étel tagja egy étkezésnek!");
                        DialogResult dr = fe.ShowDialog();
                        if (dr == DialogResult.OK)
                            fe.Hide();
                    }
                    
                    //DataGridView frissítés
                    feltoltComboboxEtelek();
                    beallitDataGridView();
                }
                else
                {
                    fm.Hide();
                }
            }
        }

        private void Feherje_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Feherje.Text, "[^0-9]"))
            {
                FormError fe = new FormError("Oopss... Betűt nem írhatsz!");
                DialogResult dr = fe.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    fe.Hide();
                    Feherje.Text = Feherje.Text.Remove(Feherje.Text.Length - 1);
                }
                
            }
        }

        private void textBoxCh_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCh.Text, "[^0-9]"))
            {
                FormError fe = new FormError("Oopss... Betűt nem írhatsz!");
                DialogResult dr = fe.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    fe.Hide();
                    textBoxCh.Text = textBoxCh.Text.Remove(textBoxCh.Text.Length - 1);
                }

            }
        }

        private void textBoxZsir_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxZsir.Text, "[^0-9]"))
            {
                FormError fe = new FormError("Oopss... Betűt nem írhatsz!");
                DialogResult dr = fe.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    fe.Hide();
                    textBoxZsir.Text = textBoxZsir.Text.Remove(textBoxZsir.Text.Length - 1);
                }

            }
        }

        private void textBoxKaloria_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxKaloria.Text, "[^0-9]"))
            {
                FormError fe = new FormError("Oopss... Betűt nem írhatsz!");
                DialogResult dr = fe.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    fe.Hide();
                    textBoxKaloria.Text = textBoxKaloria.Text.Remove(textBoxKaloria.Text.Length - 1);
                }

            }
        }
    }
}
