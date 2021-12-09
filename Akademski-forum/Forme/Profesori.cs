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
            // TODO: This line of code loads data into the 'dataSetAkademskiForum1.af_SelectStatus' table. You can move, or remove it, as needed.
            this.af_SelectStatusTableAdapter.Fill(this.dataSetAkademskiForum1.af_SelectStatus);
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.ReadOnly = true;

            SetValidatingEventHandler(tabPage2);
            //predmetIDTextBox.Validating += ValidatingNumericTextBox;   
        }

        #region key bindings

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

        #endregion

        //EXIT
        private void toolStripButtonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //REFRESH -------------------------------
        private void toolStripButtonOsvjezi_Click(object sender, EventArgs e)
        {
            this.profesoriTableAdapter1.ClearBeforeFill = true;
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);

            tabControl1.SelectTab(tabPage1);
        }

        //INFO 
        private void toolStripButtonUpute_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"file://C:\Users\Korisnik\Documents\HelpNDoc\Output\chm\Info.chm");
        }

        //DELETE
        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Jeste li sigurni da želite obrisati zapis?", @"Brisanje trenutnog zapisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        //EDIT------------------------------
        private void toolStripButtonIzmjena_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        //SAVE
        private void toolStripButtonSpremi_Click(object sender, EventArgs e)
        {
            if (allowSaving == false)
            {
                MessageBox.Show("Ponovno provjerite unesene podatke.", "Error");
                return;
            }

            this.profesoriBindingSource1.EndEdit();
            this.profesoriTableAdapter1.Update(this.dataSetAkademskiForum1.Profesori);

            tabControl1.SelectTab(tabPage1);

            this.profesoriTableAdapter1.ClearBeforeFill = true;
            this.profesoriTableAdapter1.Fill(this.dataSetAkademskiForum1.Profesori);
            MessageBox.Show("Spremanje uspješno!", "Bravo");
        }

        //INPUT--------------------------------------------------------------------------------------------------
        private void toolStripButtonUnos_Click(object sender, EventArgs e)
        {
            //onClick dodaj novi red u tabeli
            this.profesoriBindingSource1.AddNew();

            //prebaci se na edit tab
            tabControl1.SelectTab(tabPage2);
        }

        private void oIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            //  --ne prihvaca se--  / null / empty  /
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

        //REPORT----------------------------
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.profesoriTableAdapter1.Fill(dataSetAkademskiForum1.Profesori);

            Ispis rpt = new Ispis(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\ReportProfesori.rdlc", "DataSetProfesori", dataSetAkademskiForum1.Profesori);
            rpt.Show();
        }

        //double click event pogledaj applications 
        private void detailsButton_Click(object sender, EventArgs e)
        {
            Predmeti pred = new Predmeti();
         

                //pred.Size = new Size(500, 300);
                //pred.StartPosition = FormStartPosition.CenterScreen;
                //pred.WindowState = FormWindowState.Normal;

            pred.ShowDialog();
          
            if (pred.DialogResult == DialogResult.OK)
            {
                predmetIDTextBox.Text = pred.selectedRow.PredmetID.ToString();
                predmetNameTextBox1.Text = pred.selectedRow.PredmetName.ToString();
            }
        }
      
        private void predmetIDTextBox_TextChanged(object sender, EventArgs e)
        {
            DataSetAkademskiForumTableAdapters.PredmetiTableAdapter _predmetiTableAdapter = new DataSetAkademskiForumTableAdapters.PredmetiTableAdapter();    

            bool success = Int32.TryParse(predmetIDTextBox.Text, out int x);

            if (success) 
            {
                x = Convert.ToInt32(predmetIDTextBox.Text);

                if(_predmetiTableAdapter.af_SelectPredmetById(x).FirstOrDefault() != null)
                {
                    string zed = _predmetiTableAdapter.af_SelectPredmetById(x).First().PredmetName;
                    predmetNameTextBox1.Text = zed;
                }
                else{
                    predmetNameTextBox1.Text = "";
                }
            }
            else
            {
                predmetNameTextBox1.Text = "";
            }
        }

        //Validating za samo predmetIDTextBox

        //public DataSetAkademskiForum.ProfesoriRow selectedRow { get; set; }
        //private void predmetIDTextBox_Validating(object sender, CancelEventArgs e)
        //{
        //if (String.IsNullOrWhiteSpace(predmetIDTextBox.Text))
        //{
        //    DataRowView dataRowView = (DataRowView)profesoriBindingSource1.Current;
        //    selectedRow = (DataSetAkademskiForum.ProfesoriRow)dataRowView.Row;

        //    selectedRow.SetPredmetIDNull();
        //    selectedRow.SetPredmetNameNull();
        //}          
        //}


        //Validating za sve textboxeve
        protected virtual void SetValidatingEventHandler(TabPage tabPage)
        {
            tabPage.Controls.OfType<TextBox>().ToList().ForEach(x => x.Validating += ValidatingNumericTextBox);
        }

        private void ValidatingNumericTextBox(object sender, CancelEventArgs e)
        {
            if (sender.GetType() != typeof(TextBox)) return;
            TextBox textBox = (TextBox)sender;
            
            if (textBox.DataBindings.Count > 0)
            {
                Binding binding = textBox.DataBindings[0];
                BindingSource bindingSource = (BindingSource)binding.DataSource;
                DataColumn column = dataSetAkademskiForum1.Tables[bindingSource.DataMember].Columns[binding.BindingMemberInfo.BindingField];

                if (String.IsNullOrEmpty(textBox.Text) && column.DataType == typeof(int))
                {
                    DataRow current = ((DataRowView)bindingSource.Current).Row;
                    current.SetField(column, DBNull.Value);
                }
            }
        }
    } 
}