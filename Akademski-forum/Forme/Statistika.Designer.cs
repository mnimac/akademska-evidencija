
namespace Akademski_forum.Forme
{
    partial class Statistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUnos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSpremi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzmjena = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOsvjezi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorOsvjezi = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIspis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorIspis = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorUpute = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZatvori = new System.Windows.Forms.ToolStripButton();
            this.af_ReportPredmetStudentTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.af_ReportPredmetStudentTableAdapter();
            this.dataSetAkademskiForum1 = new Akademski_forum.DataSetAkademskiForum();
            this.studentiTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.StudentiTableAdapter();
            this.af_ReportPredmetStudenti2TableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.af_ReportPredmetStudenti2TableAdapter();
            this.af_SelectStudentiPredIdTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.af_SelectStudentiPredIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUnos,
            this.toolStripButtonSpremi,
            this.toolStripButtonIzmjena,
            this.toolStripButtonBrisi,
            this.toolStripSeparatorEdit,
            this.toolStripButtonOsvjezi,
            this.toolStripSeparatorOsvjezi,
            this.toolStripButtonIspis,
            this.toolStripSeparatorIspis,
            this.toolStripButtonUpute,
            this.toolStripSeparatorUpute,
            this.toolStripButtonZatvori});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(800, 54);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // toolStripButtonUnos
            // 
            this.toolStripButtonUnos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnos.Image")));
            this.toolStripButtonUnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnos.Name = "toolStripButtonUnos";
            this.toolStripButtonUnos.Size = new System.Drawing.Size(57, 51);
            this.toolStripButtonUnos.Text = "Upis (F4)";
            this.toolStripButtonUnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonSpremi
            // 
            this.toolStripButtonSpremi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSpremi.Image")));
            this.toolStripButtonSpremi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSpremi.Name = "toolStripButtonSpremi";
            this.toolStripButtonSpremi.Size = new System.Drawing.Size(65, 51);
            this.toolStripButtonSpremi.Text = "Zapiši (F5)";
            this.toolStripButtonSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonIzmjena
            // 
            this.toolStripButtonIzmjena.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzmjena.Image")));
            this.toolStripButtonIzmjena.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonIzmjena.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzmjena.Name = "toolStripButtonIzmjena";
            this.toolStripButtonIzmjena.Size = new System.Drawing.Size(75, 51);
            this.toolStripButtonIzmjena.Text = "Izmjena (F3)";
            this.toolStripButtonIzmjena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonBrisi
            // 
            this.toolStripButtonBrisi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrisi.Image")));
            this.toolStripButtonBrisi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrisi.Name = "toolStripButtonBrisi";
            this.toolStripButtonBrisi.Size = new System.Drawing.Size(80, 51);
            this.toolStripButtonBrisi.Text = "Brisanje (Del)";
            this.toolStripButtonBrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparatorEdit
            // 
            this.toolStripSeparatorEdit.Name = "toolStripSeparatorEdit";
            this.toolStripSeparatorEdit.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButtonOsvjezi
            // 
            this.toolStripButtonOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOsvjezi.Image")));
            this.toolStripButtonOsvjezi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOsvjezi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOsvjezi.Name = "toolStripButtonOsvjezi";
            this.toolStripButtonOsvjezi.Size = new System.Drawing.Size(102, 51);
            this.toolStripButtonOsvjezi.Text = "Osvježavanje (F2)";
            this.toolStripButtonOsvjezi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparatorOsvjezi
            // 
            this.toolStripSeparatorOsvjezi.Name = "toolStripSeparatorOsvjezi";
            this.toolStripSeparatorOsvjezi.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButtonIspis
            // 
            this.toolStripButtonIspis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIspis.Image")));
            this.toolStripButtonIspis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonIspis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIspis.Name = "toolStripButtonIspis";
            this.toolStripButtonIspis.Size = new System.Drawing.Size(63, 51);
            this.toolStripButtonIspis.Text = "Ispis (F10)";
            this.toolStripButtonIspis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIspis.Click += new System.EventHandler(this.toolStripButtonIspis_Click);
            // 
            // toolStripSeparatorIspis
            // 
            this.toolStripSeparatorIspis.Name = "toolStripSeparatorIspis";
            this.toolStripSeparatorIspis.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButtonUpute
            // 
            this.toolStripButtonUpute.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpute.Image")));
            this.toolStripButtonUpute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUpute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpute.Name = "toolStripButtonUpute";
            this.toolStripButtonUpute.Size = new System.Drawing.Size(72, 51);
            this.toolStripButtonUpute.Text = "Pomoć (F1)";
            this.toolStripButtonUpute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparatorUpute
            // 
            this.toolStripSeparatorUpute.Name = "toolStripSeparatorUpute";
            this.toolStripSeparatorUpute.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButtonZatvori
            // 
            this.toolStripButtonZatvori.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZatvori.Image")));
            this.toolStripButtonZatvori.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZatvori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZatvori.Name = "toolStripButtonZatvori";
            this.toolStripButtonZatvori.Size = new System.Drawing.Size(76, 51);
            this.toolStripButtonZatvori.Text = "Zatvori (Esc)";
            this.toolStripButtonZatvori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // af_ReportPredmetStudentTableAdapter1
            // 
            this.af_ReportPredmetStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetAkademskiForum1
            // 
            this.dataSetAkademskiForum1.DataSetName = "DataSetAkademskiForum";
            this.dataSetAkademskiForum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiTableAdapter1
            // 
            this.studentiTableAdapter1.ClearBeforeFill = true;
            // 
            // af_ReportPredmetStudenti2TableAdapter1
            // 
            this.af_ReportPredmetStudenti2TableAdapter1.ClearBeforeFill = true;
            // 
            // af_SelectStudentiPredIdTableAdapter1
            // 
            this.af_SelectStudentiPredIdTableAdapter1.ClearBeforeFill = true;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetAkademskiForum dataSetAkademskiForum1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnos;
        private System.Windows.Forms.ToolStripButton toolStripButtonSpremi;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzmjena;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrisi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonOsvjezi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOsvjezi;
        private System.Windows.Forms.ToolStripButton toolStripButtonIspis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorIspis;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorUpute;
        private System.Windows.Forms.ToolStripButton toolStripButtonZatvori;
        private DataSetAkademskiForumTableAdapters.af_ReportPredmetStudentTableAdapter af_ReportPredmetStudentTableAdapter1;
        private DataSetAkademskiForumTableAdapters.StudentiTableAdapter studentiTableAdapter1;
        private DataSetAkademskiForumTableAdapters.af_ReportPredmetStudenti2TableAdapter af_ReportPredmetStudenti2TableAdapter1;
        private DataSetAkademskiForumTableAdapters.af_SelectStudentiPredIdTableAdapter af_SelectStudentiPredIdTableAdapter1;
    }
}