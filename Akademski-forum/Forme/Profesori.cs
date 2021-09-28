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
    public partial class Profesori : Form
    {
        public bool allowSaving = true;


        public Profesori()
        {
            InitializeComponent();
        }

        private void Profesori_Load(object sender, EventArgs e)
        {
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);
        }

        private void toolStripButtonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profesorIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void profesorIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oIBLabel_Click(object sender, EventArgs e)
        {

        }

        private void oIBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void predmetNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void predmetNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOsvjezi_Click(object sender, EventArgs e)
        {
            this.profesoriTableAdapter1.ClearBeforeFill = true;
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);

            tabControl1.SelectTab(tabPage1);
        }

        private void toolStripButtonUpute_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"file://C:\Users\Korisnik\Documents\HelpNDoc\Output\chm\Info.chm");
        }

        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void toolStripButtonIzmjena_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void toolStripButtonSpremi_Click(object sender, EventArgs e)
        {
            if (allowSaving == false)
            {
                MessageBox.Show("Ponovno provjerite unesene podatke.", "Error");
                return;
            }

            profesoriBindingSource.EndEdit();
            this.profesoriTableAdapter1.Update(this.dataSetAkademskiForum1.Profesori);

            this.profesoriTableAdapter1.ClearBeforeFill = true;
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);
            MessageBox.Show("Spremanje uspješno!", "Bravo");

            tabControl1.SelectTab(tabPage1);
        }

        private void toolStripButtonUnos_Click(object sender, EventArgs e)
        {
            //onClick dodaj novi red u tabeli
            this.profesoriBindingSource.AddNew();

            //prebaci se na edit tab
            tabControl1.SelectTab(tabPage2);        
        }

        private void oIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            //  --ne prihvaca se--  / null / empty /
            if (string.IsNullOrEmpty(oIBTextBox.Text))
            {
                errorProvider1.SetError(oIBTextBox, "Molimo unesite vrijednost!");
                allowSaving = false;
            }
            else
            {
                errorProvider1.SetError(oIBTextBox, null);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Ispis rds = new Ispis();            
            //rds.Show();
        }

    }
}