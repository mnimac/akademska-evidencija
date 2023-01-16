namespace Akademski_forum
{
    partial class Ocjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocjene));
            this.dataSetAkademskiForum1 = new Akademski_forum.DataSetAkademskiForum();
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
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPolaganjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ocjeneTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.OcjeneTableAdapter();
            this.af_ReportOcjenaTableAdapter1 = new Akademski_forum.DataSetAkademskiForumTableAdapters.af_ReportOcjenaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetAkademskiForum1
            // 
            this.dataSetAkademskiForum1.DataSetName = "DataSetAkademskiForum";
            this.dataSetAkademskiForum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolStripMenu.Size = new System.Drawing.Size(807, 54);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
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
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 415);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabelarni prikaz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.predmetNameDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.datumPolaganjaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // predmetNameDataGridViewTextBoxColumn
            // 
            this.predmetNameDataGridViewTextBoxColumn.DataPropertyName = "PredmetName";
            this.predmetNameDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetNameDataGridViewTextBoxColumn.Name = "predmetNameDataGridViewTextBoxColumn";
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            // 
            // datumPolaganjaDataGridViewTextBoxColumn
            // 
            this.datumPolaganjaDataGridViewTextBoxColumn.DataPropertyName = "datumPolaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.HeaderText = "Datum polaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.Name = "datumPolaganjaDataGridViewTextBoxColumn";
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
            // predmetStudentBindingSource
            // 
            this.predmetStudentBindingSource.DataMember = "Ocjene";
            this.predmetStudentBindingSource.DataSource = this.dataSetAkademskiForum1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.predmetStudentBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 475);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(807, 25);
            this.bindingNavigator1.TabIndex = 6;
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripLabel,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 54);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(807, 25);
            this.fillToolStrip.TabIndex = 7;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentToolStripLabel
            // 
            this.studentToolStripLabel.Name = "studentToolStripLabel";
            this.studentToolStripLabel.Size = new System.Drawing.Size(51, 22);
            this.studentToolStripLabel.Text = "Student:";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // ocjeneTableAdapter1
            // 
            this.ocjeneTableAdapter1.ClearBeforeFill = true;
            // 
            // af_ReportOcjenaTableAdapter1
            // 
            this.af_ReportOcjenaTableAdapter1.ClearBeforeFill = true;
            // 
            // Ocjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 500);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ocjene";
            this.Text = "Ocjene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ocjene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAkademskiForum1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource predmetStudentBindingSource;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPolaganjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetIDDataGridViewTextBoxColumn;
        private DataSetAkademskiForumTableAdapters.OcjeneTableAdapter ocjeneTableAdapter1;
        private DataSetAkademskiForumTableAdapters.af_ReportOcjenaTableAdapter af_ReportOcjenaTableAdapter1;
    }
}