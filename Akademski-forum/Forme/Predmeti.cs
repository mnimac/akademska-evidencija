using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace Akademski_forum
{
    public partial class Predmeti : Form
    {     
        public Predmeti()
        {        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.predmetiTableAdapter1.Fill(this.dataSetAkademskiForum.Predmeti);
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.ReadOnly = true;
        }

        //KEY BINDINGS
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
                    toolStripButton1.PerformClick();
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

        //EXIT
        private void toolStripButtonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonIzmjena_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void toolStripButtonUpute_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"file://C:\Users\Korisnik\Documents\HelpNDoc\Output\chm\Info.chm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void predmetIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.af_ReportPredmetTableAdapter1.Fill(this.dataSetAkademskiForum.af_ReportPredmet);
            Ispis rds = new Ispis(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\ReportPredmet.rdlc", "DataSet1", dataSetAkademskiForum.af_ReportPredmet);
            rds.Show();
        }

        //REFRESH-----------------------------------------------------------------------------------------
        private void toolStripButtonOsvjezi_Click(object sender, EventArgs e)
        {
            this.predmetiTableAdapter1.ClearBeforeFill = true;
            this.predmetiTableAdapter1.Fill(this.dataSetAkademskiForum.Predmeti);

            tabControl1.SelectTab(tabPage1);
        }

        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void toolStripButtonUnos_Click(object sender, EventArgs e)
        {
            //onClick dodaj novi red u tabeli
            this.predmetiBindingSource.AddNew();

            //prebaci se na edit tab
            tabControl1.SelectTab(tabPage2);       
        }

        private void toolStripButtonSpremi_Click(object sender, EventArgs e)
        {
            //if (allowSaving == false)
            //{
            //    MessageBox.Show("Ponovno provjerite unesene podatke.", "Error");
            //    return;
            //}

            predmetiBindingSource.EndEdit();
            this.profesoriTableAdapter1.Update(this.dataSetAkademskiForum.Profesori);

            this.profesoriTableAdapter1.ClearBeforeFill = true;
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum.Profesori);
            MessageBox.Show("Spremanje uspješno!", "Bravo");

            tabControl1.SelectTab(tabPage1);
        }
    }
}
