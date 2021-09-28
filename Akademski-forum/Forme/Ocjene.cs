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
    public partial class Ocjene : Form
    {
        public Ocjene()
        {
            InitializeComponent();
        }

        private void Ocjene_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
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

        //toolstrip 
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.predmetStudentTableAdapter1.Fill(this.dataSetAkademskiForum1.PredmetStudent, studentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //zatvori
        private void toolStripButtonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void toolStripButtonUpute_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"file://C:\Users\Korisnik\Documents\HelpNDoc\Output\chm\Info.chm");
        }

        private void toolStripButtonIspis_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOsvjezi_Click(object sender, EventArgs e)
        {
            this.predmetStudentTableAdapter1.ClearBeforeFill = true;
            this.predmetStudentTableAdapter1.Fill(this.dataSetAkademskiForum1.PredmetStudent, studentToolStripTextBox.Text);
        }

        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void toolStripButtonIzmjena_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void toolStripButtonSpremi_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonUnos_Click(object sender, EventArgs e)
        {
            //onClick dodaj novi red u tabeli
            this.predmetStudentBindingSource.AddNew();
        }
    }
}
