using Microsoft.Reporting.WinForms;
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

namespace Akademski_forum
{
    public partial class Ispis : Form
    {
        string _reportEmbededResource;
        string _reportDataSourceName;
        DataTable _reportDataTable;
        List<ReportDefinition> _subreportDefinitions;

        //public List<ReportDefinition> SubreportDefinitions { get; set; }

        public Ispis(string reportEmbededResource, string reportDataSourceName, DataTable reportDataTable, List<ReportDefinition> subreportDefinitions)
        {
            InitializeComponent();     

            _reportEmbededResource = reportEmbededResource;
            _reportDataSourceName = reportDataSourceName;
            _reportDataTable = reportDataTable;
            _subreportDefinitions = subreportDefinitions;

            this.WindowState = FormWindowState.Maximized;
        }

        private void Ispis_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = _reportEmbededResource;
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = _reportEmbededResource;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(_reportDataSourceName, _reportDataTable));

            this.reportViewer1.LocalReport.SubreportProcessing += SubreportEventHandler;

            this.reportViewer1.ZoomMode = (ZoomMode)Microsoft.Reporting.WebForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }

        private void SubreportEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            var subreportDefinition = _subreportDefinitions.FirstOrDefault(sd => e.ReportPath == "Subreport22");

            var x = e.Parameters["predID"];


            e.DataSources.Add(new ReportDataSource(subreportDefinition.ReportDataSourceName, subreportDefinition.ReportDataTable));
        }
    }   
}
