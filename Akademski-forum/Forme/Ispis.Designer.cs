﻿namespace Akademski_forum
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
            this.StudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAkademskiForum = new Akademski_forum.DataSetAkademskiForum();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentiTableAdapter = new Akademski_forum.DataSetAkademskiForumTableAdapters.StudentiTableAdapter();
            this.af_SelectStudentiPredIdTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.af_SelectStudentiPredIdTableAdapter();
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
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(669, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentiTableAdapter
            // 
            this.StudentiTableAdapter.ClearBeforeFill = true;
            // 
            // af_SelectStudentiPredIdTableAdapter1
            // 
            this.af_SelectStudentiPredIdTableAdapter1.ClearBeforeFill = true;
            // 
            // Ispis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 521);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ispis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.Ispis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAkademskiForum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource StudentiBindingSource;
        private DataSetAkademskiForum DataSetAkademskiForum;
        private DataSetAkademskiForumTableAdapters.StudentiTableAdapter StudentiTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetAkademskiForumTableAdapters.af_SelectStudentiPredIdTableAdapter af_SelectStudentiPredIdTableAdapter1;
    }
}