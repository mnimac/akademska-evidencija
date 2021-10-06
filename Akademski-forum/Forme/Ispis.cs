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

        public Ispis(string reportEmbededResource, string reportDataSourceName, DataTable reportDataTable)
        {
            _reportEmbededResource = reportEmbededResource;
            _reportDataSourceName = reportDataSourceName;
            _reportDataTable = reportDataTable;

            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Ispis_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = _reportEmbededResource;
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = _reportEmbededResource;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(_reportDataSourceName, _reportDataTable));

            this.reportViewer1.ZoomMode = (ZoomMode)Microsoft.Reporting.WebForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
    }   
}
