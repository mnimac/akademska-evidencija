namespace Akademski_forum
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mticniPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mticniPodaciToolStripMenuItem,
            this.ocjeneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mticniPodaciToolStripMenuItem
            // 
            this.mticniPodaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmetiToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.profesoriToolStripMenuItem});
            this.mticniPodaciToolStripMenuItem.Name = "mticniPodaciToolStripMenuItem";
            this.mticniPodaciToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mticniPodaciToolStripMenuItem.Text = "Matični podaci ";
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // profesoriToolStripMenuItem
            // 
            this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
            this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profesoriToolStripMenuItem.Text = "Profesori";
            this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.profesoriToolStripMenuItem_Click);
            // 
            // ocjeneToolStripMenuItem
            // 
            this.ocjeneToolStripMenuItem.Name = "ocjeneToolStripMenuItem";
            this.ocjeneToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ocjeneToolStripMenuItem.Text = "Ocjene";
            this.ocjeneToolStripMenuItem.Click += new System.EventHandler(this.ocjeneToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(567, 389);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Akademska evidencija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mticniPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
    }
}