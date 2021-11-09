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
            this.af_SelectStudentiPredIdTableAdapter1.Fill(this.dataSetAkademskiForum1.af_SelectStudentiPredId, 1);

            var subreportDefinitions = new List<ReportDefinition>
            {
                new ReportDefinition(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\Subreport22.rdlc", "DataSet1", dataSetAkademskiForum1.af_SelectStudentiPredId)
            };

            Ispis rds = new Ispis(@"C:\Users\Korisnik\source\repos\Akademski-forum\Akademski-forum\Reports\Report22.rdlc", "DataSet1", dataSetAkademskiForum1.af_ReportPredmetStudenti2, subreportDefinitions);

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
