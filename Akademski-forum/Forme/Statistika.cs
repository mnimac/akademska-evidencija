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

namespace Akademski_forum.Forme
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void toolStripButtonIspis_Click(object sender, EventArgs e)
        {
            this.af_ReportPredmetStudenti2TableAdapter1.Fill(this.dataSetAkademskiForum1.af_ReportPredmetStudenti2);        

            Ispis rds = new Ispis(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\Report22.rdlc", "DataSet1", dataSetAkademskiForum1.af_ReportPredmetStudenti2);

            rds.Show();
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {

        }
    }
}
