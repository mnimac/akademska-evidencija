namespace Akademski_forum
{
    partial class Studenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studenti));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAkademskiForum1 = new Akademski_forum.DataSetAkademskiForum();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentiTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.StudentiTableAdapter();
            this.tableAdapterManager = new Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(48, 85);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(29, 16);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Ime";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(48, 113);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(56, 16);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Prezime";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(48, 141);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(34, 16);
            oIBLabel.TabIndex = 6;
            oIBLabel.Text = "OIB:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(48, 169);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 16);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
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
            this.toolStripMenu.Size = new System.Drawing.Size(954, 54);
            this.toolStripMenu.TabIndex = 2;
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
            this.toolStripButtonIzmjena.Size = new System.Drawing.Size(75, 51);
            this.toolStripButtonIzmjena.Text = "Izmjena (F3)";
            this.toolStripButtonIzmjena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzmjena.Click += new System.EventHandler(this.toolStripButtonIzmjena_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(954, 377);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabelarni prikaz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSetAkademskiForum1;
            // 
            // dataSetAkademskiForum1
            // 
            this.dataSetAkademskiForum1.DataSetName = "DataSetAkademskiForum";
            this.dataSetAkademskiForum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(firstNameLabel);
            this.tabPage2.Controls.Add(this.firstNameTextBox);
            this.tabPage2.Controls.Add(lastNameLabel);
            this.tabPage2.Controls.Add(this.lastNameTextBox);
            this.tabPage2.Controls.Add(oIBLabel);
            this.tabPage2.Controls.Add(this.oIBTextBox);
            this.tabPage2.Controls.Add(cityLabel);
            this.tabPage2.Controls.Add(this.cityTextBox);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pojedinačni prikaz";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(155, 82);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(155, 110);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(155, 138);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(197, 22);
            this.oIBTextBox.TabIndex = 7;
            this.oIBTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.oIBTextBox_Validating);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(155, 166);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 9;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.studentiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 452);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(954, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentiTableAdapter1
            // 
            this.studentiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OcjeneTableAdapter = null;
            this.tableAdapterManager.PredmetiTableAdapter = null;
            this.tableAdapterManager.ProfesoriTableAdapter = null;
            this.tableAdapterManager.StudentiTableAdapter = this.studentiTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Akademski_forum.DataSetAkademskiForumTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 477);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonIspis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorIspis;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorUpute;
        private System.Windows.Forms.ToolStripButton toolStripButtonZatvori;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSetAkademskiForum dataSetAkademskiForum1;
        private DataSetAkademskiForumTableAdapters.StudentiTableAdapter studentiTableAdapter1;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private DataSetAkademskiForumTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}