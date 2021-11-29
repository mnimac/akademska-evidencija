namespace Akademski_forum
{
    partial class Profesori
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label predmetIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesori));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUnos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSpremi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzmjena = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOsvjezi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorOsvjezi = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorIspis = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorUpute = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZatvori = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detailsButton = new System.Windows.Forms.Button();
            this.predmetNameTextBox1 = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.predmetIDTextBox = new System.Windows.Forms.TextBox();
            this.profesorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAkademskiForum1 = new Akademski_forum.DataSetAkademskiForum();
            this.profesoriTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.ProfesoriTableAdapter();
            this.tableAdapterManager = new Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            predmetIDLabel = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(79, 71);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(77, 16);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Prof. Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(80, 112);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(95, 16);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Prof. Surname:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(79, 153);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(34, 16);
            oIBLabel.TabIndex = 6;
            oIBLabel.Text = "OIB:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(78, 196);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 16);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // predmetIDLabel
            // 
            predmetIDLabel.AutoSize = true;
            predmetIDLabel.Location = new System.Drawing.Point(78, 240);
            predmetIDLabel.Name = "predmetIDLabel";
            predmetIDLabel.Size = new System.Drawing.Size(65, 16);
            predmetIDLabel.TabIndex = 10;
            predmetIDLabel.Text = "Predmet :";
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
            this.toolStripButton1,
            this.toolStripSeparatorIspis,
            this.toolStripButtonUpute,
            this.toolStripSeparatorUpute,
            this.toolStripButtonZatvori});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(990, 54);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonUnos
            // 
            this.toolStripButtonUnos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnos.Image")));
            this.toolStripButtonUnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnos.Name = "toolStripButtonUnos";
            this.toolStripButtonUnos.Size = new System.Drawing.Size(57, 51);
            this.toolStripButtonUnos.Text = "Upis (F5)";
            this.toolStripButtonUnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUnos.Click += new System.EventHandler(this.toolStripButtonUnos_Click);
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
            this.toolStripButtonSpremi.Click += new System.EventHandler(this.toolStripButtonSpremi_Click);
            // 
            // toolStripButtonIzmjena
            // 
            this.toolStripButtonIzmjena.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzmjena.Image")));
            this.toolStripButtonIzmjena.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonIzmjena.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzmjena.Name = "toolStripButtonIzmjena";
            this.toolStripButtonIzmjena.Size = new System.Drawing.Size(80, 51);
            this.toolStripButtonIzmjena.Text = "Izmjena (Ent)";
            this.toolStripButtonIzmjena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzmjena.Click += new System.EventHandler(this.toolStripButtonIzmjena_Click);
            // 
            // toolStripButtonBrisi
            // 
            this.toolStripButtonBrisi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrisi.Image")));
            this.toolStripButtonBrisi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrisi.Name = "toolStripButtonBrisi";
            this.toolStripButtonBrisi.Size = new System.Drawing.Size(75, 51);
            this.toolStripButtonBrisi.Text = "Brisanje (F9)";
            this.toolStripButtonBrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBrisi.Click += new System.EventHandler(this.toolStripButtonBrisi_Click);
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
            this.toolStripButtonOsvjezi.Click += new System.EventHandler(this.toolStripButtonOsvjezi_Click);
            // 
            // toolStripSeparatorOsvjezi
            // 
            this.toolStripSeparatorOsvjezi.Name = "toolStripSeparatorOsvjezi";
            this.toolStripSeparatorOsvjezi.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 51);
            this.toolStripButton1.Text = "Ispis (F10)";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.toolStripButtonUpute.Click += new System.EventHandler(this.toolStripButtonUpute_Click);
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
            this.toolStripButtonZatvori.Click += new System.EventHandler(this.toolStripButtonZatvori_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 417);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabelarni prikaz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profesorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.predmetNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesoriBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(969, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.predmetIDTextBox);
            this.tabPage2.Controls.Add(this.detailsButton);
            this.tabPage2.Controls.Add(this.predmetNameTextBox1);
            this.tabPage2.Controls.Add(predmetIDLabel);
            this.tabPage2.Controls.Add(cityLabel);
            this.tabPage2.Controls.Add(this.cityTextBox);
            this.tabPage2.Controls.Add(oIBLabel);
            this.tabPage2.Controls.Add(this.oIBTextBox);
            this.tabPage2.Controls.Add(lastNameLabel);
            this.tabPage2.Controls.Add(this.lastNameTextBox);
            this.tabPage2.Controls.Add(firstNameLabel);
            this.tabPage2.Controls.Add(this.firstNameTextBox);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pojedinačni prikaz";
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(247, 236);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(34, 23);
            this.detailsButton.TabIndex = 14;
            this.detailsButton.Text = "...";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // predmetNameTextBox1
            // 
            this.predmetNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "PredmetName", true));
            this.predmetNameTextBox1.Location = new System.Drawing.Point(287, 237);
            this.predmetNameTextBox1.Name = "predmetNameTextBox1";
            this.predmetNameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.predmetNameTextBox1.TabIndex = 13;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(198, 193);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 9;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(198, 150);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(100, 22);
            this.oIBTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(198, 109);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(198, 68);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // predmetIDTextBox
            // 
            this.predmetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoriBindingSource1, "PredmetID", true));
            this.predmetIDTextBox.Location = new System.Drawing.Point(198, 237);
            this.predmetIDTextBox.Name = "predmetIDTextBox";
            this.predmetIDTextBox.Size = new System.Drawing.Size(43, 22);
            this.predmetIDTextBox.TabIndex = 15;
            // 
            // profesorIDDataGridViewTextBoxColumn
            // 
            this.profesorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfesorID";
            this.profesorIDDataGridViewTextBoxColumn.HeaderText = "ProfesorID";
            this.profesorIDDataGridViewTextBoxColumn.Name = "profesorIDDataGridViewTextBoxColumn";
            this.profesorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetNameDataGridViewTextBoxColumn
            // 
            this.predmetNameDataGridViewTextBoxColumn.DataPropertyName = "PredmetName";
            this.predmetNameDataGridViewTextBoxColumn.HeaderText = "Ime predmeta";
            this.predmetNameDataGridViewTextBoxColumn.Name = "predmetNameDataGridViewTextBoxColumn";
            this.predmetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesoriBindingSource1
            // 
            this.profesoriBindingSource1.DataMember = "Profesori";
            this.profesoriBindingSource1.DataSource = this.dataSetAkademskiForum1;
            // 
            // dataSetAkademskiForum1
            // 
            this.dataSetAkademskiForum1.DataSetName = "DataSetAkademskiForum";
            this.dataSetAkademskiForum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesoriTableAdapter1
            // 
            this.profesoriTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OcjeneTableAdapter = null;
            this.tableAdapterManager.PredmetiTableAdapter = null;
            this.tableAdapterManager.ProfesoriTableAdapter = this.profesoriTableAdapter1;
            this.tableAdapterManager.StudentiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Profesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Profesori";
            this.Text = "Profesori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profesori_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnos;
        private System.Windows.Forms.ToolStripButton toolStripButtonSpremi;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzmjena;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrisi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonOsvjezi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOsvjezi;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorIspis;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorUpute;
        private System.Windows.Forms.ToolStripButton toolStripButtonZatvori;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetAkademskiForumTableAdapters.ProfesoriTableAdapter profesoriTableAdapter1;
        private DataSetAkademskiForum dataSetAkademskiForum1;
        private System.Windows.Forms.BindingSource profesoriBindingSource1;
        private DataSetAkademskiForumTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.TextBox predmetNameTextBox1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox predmetIDTextBox;
    }
}