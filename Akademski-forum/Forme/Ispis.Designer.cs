namespace Akademski_forum
{
    partial class Ispis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAkademskiForum = new Akademski_forum.DataSetAkademskiForum();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentiTableAdapter = new Akademski_forum.DataSetAkademskiForumTableAdapters.StudentiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAkademskiForum)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentiBindingSource
            // 
            this.StudentiBindingSource.DataMember = "Studenti";
            this.StudentiBindingSource.DataSource = this.DataSetAkademskiForum;
            // 
            // DataSetAkademskiForum
            // 
            this.DataSetAkademskiForum.DataSetName = "DataSetAkademskiForum";
            this.DataSetAkademskiForum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Akademski_forum.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentiTableAdapter
            // 
            this.StudentiTableAdapter.ClearBeforeFill = true;
            // 
            // Ispis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 501);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ispis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.Ispis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAkademskiForum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentiBindingSource;
        private DataSetAkademskiForum DataSetAkademskiForum;
        private DataSetAkademskiForumTableAdapters.StudentiTableAdapter StudentiTableAdapter;
    }
}