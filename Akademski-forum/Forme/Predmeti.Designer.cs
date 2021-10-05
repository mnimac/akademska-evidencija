namespace Akademski_forum
{
    partial class Predmeti
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
            System.Windows.Forms.Label predmetIDLabel;
            System.Windows.Forms.Label predmetNameLabel;
            System.Windows.Forms.Label profesorIDLabel;
            System.Windows.Forms.Label profNameLabel;
            System.Windows.Forms.Label profSurnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Predmeti));
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
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAkademskiForum = new Akademski_forum.DataSetAkademskiForum();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.predmetIDTextBox = new System.Windows.Forms.TextBox();
            this.predmetNameTextBox = new System.Windows.Forms.TextBox();
            this.profesorIDTextBox = new System.Windows.Forms.TextBox();
            this.profNameTextBox = new System.Windows.Forms.TextBox();
            this.profSurnameTextBox = new System.Windows.Forms.TextBox();
            this.dataSetAkademskiForumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetiTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.PredmetiTableAdapter();
            this.profesoriTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.ProfesoriTableAdapter();
            this.studentiTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.StudentiTableAdapter();
            this.predmetStudentTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.OcjeneTableAdapter();
            this.tableAdapterManager = new Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager();
            this.predmetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            predmetIDLabel = new System.Windows.Forms.Label();
            predmetNameLabel = new System.Windows.Forms.Label();
            profesorIDLabel = new System.Windows.Forms.Label();
            profNameLabel = new System.Windows.Forms.Label();
            profSurnameLabel = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // predmetIDLabel
            // 
            predmetIDLabel.AutoSize = true;
            predmetIDLabel.Location = new System.Drawing.Point(48, 52);
            predmetIDLabel.Name = "predmetIDLabel";
            predmetIDLabel.Size = new System.Drawing.Size(93, 16);
            predmetIDLabel.TabIndex = 0;
            predmetIDLabel.Text = "Broj predmeta:";
            predmetIDLabel.Click += new System.EventHandler(this.predmetIDLabel_Click);
            // 
            // predmetNameLabel
            // 
            predmetNameLabel.AutoSize = true;
            predmetNameLabel.Location = new System.Drawing.Point(48, 80);
            predmetNameLabel.Name = "predmetNameLabel";
            predmetNameLabel.Size = new System.Drawing.Size(91, 16);
            predmetNameLabel.TabIndex = 2;
            predmetNameLabel.Text = "Ime predmeta:";
            // 
            // profesorIDLabel
            // 
            profesorIDLabel.AutoSize = true;
            profesorIDLabel.Location = new System.Drawing.Point(48, 108);
            profesorIDLabel.Name = "profesorIDLabel";
            profesorIDLabel.Size = new System.Drawing.Size(85, 16);
            profesorIDLabel.TabIndex = 4;
            profesorIDLabel.Text = "Profesor broj:";
            // 
            // profNameLabel
            // 
            profNameLabel.AutoSize = true;
            profNameLabel.Location = new System.Drawing.Point(48, 136);
            profNameLabel.Name = "profNameLabel";
            profNameLabel.Size = new System.Drawing.Size(90, 16);
            profNameLabel.TabIndex = 6;
            profNameLabel.Text = "Ime profesora:";
            // 
            // profSurnameLabel
            // 
            profSurnameLabel.AutoSize = true;
            profSurnameLabel.Location = new System.Drawing.Point(48, 164);
            profSurnameLabel.Name = "profSurnameLabel";
            profSurnameLabel.Size = new System.Drawing.Size(117, 16);
            profSurnameLabel.TabIndex = 8;
            profSurnameLabel.Text = "Prezime profesora:";
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
            this.toolStripMenu.Size = new System.Drawing.Size(926, 54);
            this.toolStripMenu.TabIndex = 1;
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
            this.tabControl1.Size = new System.Drawing.Size(926, 391);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 365);
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
            this.predmetIDDataGridViewTextBoxColumn,
            this.predmetNameDataGridViewTextBoxColumn,
            this.profesorIDDataGridViewTextBoxColumn,
            this.profNameDataGridViewTextBoxColumn,
            this.profSurnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(912, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.dataSetAkademskiForum;
            // 
            // dataSetAkademskiForum
            // 
            this.dataSetAkademskiForum.DataSetName = "DataSetAkademskiForum";
            this.dataSetAkademskiForum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pojedinačni prikaz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(predmetIDLabel);
            this.groupBox1.Controls.Add(this.predmetIDTextBox);
            this.groupBox1.Controls.Add(predmetNameLabel);
            this.groupBox1.Controls.Add(this.predmetNameTextBox);
            this.groupBox1.Controls.Add(profesorIDLabel);
            this.groupBox1.Controls.Add(this.profesorIDTextBox);
            this.groupBox1.Controls.Add(profNameLabel);
            this.groupBox1.Controls.Add(this.profNameTextBox);
            this.groupBox1.Controls.Add(profSurnameLabel);
            this.groupBox1.Controls.Add(this.profSurnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // predmetIDTextBox
            // 
            this.predmetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predmetiBindingSource, "PredmetID", true));
            this.predmetIDTextBox.Location = new System.Drawing.Point(177, 49);
            this.predmetIDTextBox.Name = "predmetIDTextBox";
            this.predmetIDTextBox.Size = new System.Drawing.Size(178, 22);
            this.predmetIDTextBox.TabIndex = 1;
            // 
            // predmetNameTextBox
            // 
            this.predmetNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predmetiBindingSource, "PredmetName", true));
            this.predmetNameTextBox.Location = new System.Drawing.Point(177, 77);
            this.predmetNameTextBox.Name = "predmetNameTextBox";
            this.predmetNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.predmetNameTextBox.TabIndex = 3;
            // 
            // profesorIDTextBox
            // 
            this.profesorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predmetiBindingSource, "ProfesorID", true));
            this.profesorIDTextBox.Location = new System.Drawing.Point(177, 105);
            this.profesorIDTextBox.Name = "profesorIDTextBox";
            this.profesorIDTextBox.Size = new System.Drawing.Size(178, 22);
            this.profesorIDTextBox.TabIndex = 5;
            // 
            // profNameTextBox
            // 
            this.profNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predmetiBindingSource, "profName", true));
            this.profNameTextBox.Location = new System.Drawing.Point(177, 133);
            this.profNameTextBox.Name = "profNameTextBox";
            this.profNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.profNameTextBox.TabIndex = 7;
            // 
            // profSurnameTextBox
            // 
            this.profSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predmetiBindingSource, "profSurname", true));
            this.profSurnameTextBox.Location = new System.Drawing.Point(177, 161);
            this.profSurnameTextBox.Name = "profSurnameTextBox";
            this.profSurnameTextBox.Size = new System.Drawing.Size(178, 22);
            this.profSurnameTextBox.TabIndex = 9;
            // 
            // dataSetAkademskiForumBindingSource
            // 
            this.dataSetAkademskiForumBindingSource.DataSource = this.dataSetAkademskiForum;
            this.dataSetAkademskiForumBindingSource.Position = 0;
            // 
            // predmetiTableAdapter1
            // 
            this.predmetiTableAdapter1.ClearBeforeFill = true;
            // 
            // profesoriTableAdapter1
            // 
            this.profesoriTableAdapter1.ClearBeforeFill = true;
            // 
            // studentiTableAdapter1
            // 
            this.studentiTableAdapter1.ClearBeforeFill = true;
            // 
            // predmetStudentTableAdapter1
            // 
            this.predmetStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PredmetiTableAdapter = this.predmetiTableAdapter1;
            this.tableAdapterManager.OcjeneTableAdapter = this.predmetStudentTableAdapter1;
            this.tableAdapterManager.ProfesoriTableAdapter = this.profesoriTableAdapter1;
            this.tableAdapterManager.StudentiTableAdapter = this.studentiTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // predmetIDDataGridViewTextBoxColumn
            // 
            this.predmetIDDataGridViewTextBoxColumn.DataPropertyName = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.HeaderText = "PredmetID";
            this.predmetIDDataGridViewTextBoxColumn.Name = "predmetIDDataGridViewTextBoxColumn";
            this.predmetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetNameDataGridViewTextBoxColumn
            // 
            this.predmetNameDataGridViewTextBoxColumn.DataPropertyName = "PredmetName";
            this.predmetNameDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetNameDataGridViewTextBoxColumn.Name = "predmetNameDataGridViewTextBoxColumn";
            this.predmetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorIDDataGridViewTextBoxColumn
            // 
            this.profesorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfesorID";
            this.profesorIDDataGridViewTextBoxColumn.HeaderText = "ProfesorID";
            this.profesorIDDataGridViewTextBoxColumn.Name = "profesorIDDataGridViewTextBoxColumn";
            this.profesorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profNameDataGridViewTextBoxColumn
            // 
            this.profNameDataGridViewTextBoxColumn.DataPropertyName = "profName";
            this.profNameDataGridViewTextBoxColumn.HeaderText = "Ime profesora";
            this.profNameDataGridViewTextBoxColumn.Name = "profNameDataGridViewTextBoxColumn";
            this.profNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profSurnameDataGridViewTextBoxColumn
            // 
            this.profSurnameDataGridViewTextBoxColumn.DataPropertyName = "profSurname";
            this.profSurnameDataGridViewTextBoxColumn.HeaderText = "Prezime profesora";
            this.profSurnameDataGridViewTextBoxColumn.Name = "profSurnameDataGridViewTextBoxColumn";
            this.profSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(926, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Predmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Podaci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForumBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource dataSetAkademskiForumBindingSource;
        private DataSetAkademskiForum dataSetAkademskiForum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetAkademskiForumTableAdapters.PredmetiTableAdapter predmetiTableAdapter1;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private DataSetAkademskiForumTableAdapters.ProfesoriTableAdapter profesoriTableAdapter1;
        private DataSetAkademskiForumTableAdapters.StudentiTableAdapter studentiTableAdapter1;
        private DataSetAkademskiForumTableAdapters.OcjeneTableAdapter predmetStudentTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox predmetIDTextBox;
        private System.Windows.Forms.TextBox predmetNameTextBox;
        private System.Windows.Forms.TextBox profesorIDTextBox;
        private System.Windows.Forms.TextBox profNameTextBox;
        private System.Windows.Forms.TextBox profSurnameTextBox;
        private DataSetAkademskiForumTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profSurnameDataGridViewTextBoxColumn;
    }
}

