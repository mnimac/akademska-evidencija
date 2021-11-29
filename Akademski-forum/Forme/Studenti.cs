using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akademski_forum
{
    public partial class Studenti : Form
    {
        public bool allowSaving = true;


        public Studenti()
        {
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            this.studentiTableAdapter1.Fill(this.dataSetAkademskiForum1.Studenti);
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.ReadOnly = true;
        }            


        //     kontrola tipkovnicom
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    toolStripButtonZatvori.PerformClick();
                    break;
                case Keys.F1:
                    toolStripButtonUpute.PerformClick();
                    break;
                case Keys.F2:
                    toolStripButtonOsvjezi.PerformClick();
                    break;
                case Keys.F3:
                    toolStripButtonIzmjena.PerformClick();
                    break;
                case Keys.F4:
                    toolStripButtonUnos.PerformClick();
                    break;
                case Keys.F5:
                    toolStripButtonSpremi.PerformClick();
                    break;
                case Keys.F10:
                    toolStripButtonIspis.PerformClick();
                    break;
                case Keys.Delete:
                    toolStripButtonBrisi.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //REFRESH 
        private void toolStripButtonOsvjezi_Click(object sender, EventArgs e)
        {
            
            this.studentiTableAdapter1.ClearBeforeFill = true;
            this.studentiTableAdapter1.Fill(this.dataSetAkademskiForum1.Studenti);

            tabControl1.SelectTab(tabPage1);
        }
            
        private void toolStripButtonUpute_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"file://C:\Users\Korisnik\Documents\HelpNDoc\Output\chm\Info.chm");
        }

        private void toolStripButtonZatvori_Click(object sender, EventArgs e)
        {           
            this.Close();         
        }

        // BRISANJE 
        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Jeste li sigurni da želite obrisati zapis?", @"Brisanje trenutnog zapisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        //
        private void toolStripButtonUnos_Click(object sender, EventArgs e)
        {
            //onClick dodaj novi red u tabeli
            this.studentiBindingSource.AddNew();              

            //prebaci se na edit tab
            tabControl1.SelectTab(tabPage2);           
        }


        // SPREMANJE 
        private void toolStripButtonSpremi_Click(object sender, EventArgs e)
        {
            if (allowSaving == false)
            {
                MessageBox.Show("Ponovno provjerite unesene podatke.", "Error");
                return;
            }
            
            studentiBindingSource.EndEdit();
            studentiTableAdapter1.Update(this.dataSetAkademskiForum1.Studenti);

            this.studentiTableAdapter1.ClearBeforeFill = true;
            this.studentiTableAdapter1.Fill(this.dataSetAkademskiForum1.Studenti);
            MessageBox.Show("Spremanje uspješno!","Bravo");

            tabControl1.SelectTab(tabPage1);
        }

        private void toolStripButtonIzmjena_Click(object sender, EventArgs e)
        {
            //izmjena
            tabControl1.SelectTab(tabPage2);
        }

        private void toolStripButtonIspis_Click(object sender, EventArgs e)
        {
            //ISPIS
            this.studentiTableAdapter1.Fill(this.dataSetAkademskiForum1.Studenti);

            Ispis rds = new Ispis(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\Report1.rdlc", "DataSet1", dataSetAkademskiForum1.Studenti);
            rds.Show();
        }

        private void oIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            // postoji li isti OIB kao uneseni?
            if ((int)studentiTableAdapter1.af_SelectStudentiByOib(oIBTextBox.Text) == 1)
            {
                errorProvider1.SetError(oIBTextBox, "Zadani OIB već se koristi.");
                MessageBox.Show("Uneseni OIB već postoji.", "Error");
                allowSaving = false;
            }
            
            //  --ne prihvaca se--  / null / empty /
            if (string.IsNullOrEmpty(oIBTextBox.Text))
            {
                errorProvider1.SetError(oIBTextBox, "Molimo unesite vrijednost!");
                allowSaving = false;
            }
            else
            {
                errorProvider1.SetError(oIBTextBox, null);
                allowSaving = true;
            }
        }
    }
}
