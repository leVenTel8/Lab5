namespace Lab2
{
    partial class Form1
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
            System.Windows.Forms.Label nUMLabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label sNAMELabel;
            System.Windows.Forms.Label bDAYLabel;
            System.Windows.Forms.Label pOSTLabel;
            System.Windows.Forms.Label aDRESLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label pAYLabel;
            System.Windows.Forms.Label mARITALLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new Lab2.DataSet1();
            this.pERSONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONALTableAdapter = new Lab2.DataSet1TableAdapters.PERSONALTableAdapter();
            this.tableAdapterManager = new Lab2.DataSet1TableAdapters.TableAdapterManager();
            this.tRAININGTableAdapter = new Lab2.DataSet1TableAdapters.TRAININGTableAdapter();
            this.pERSONALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pERSONALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pERSONALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUMTextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.sNAMETextBox = new System.Windows.Forms.TextBox();
            this.bDAYDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pOSTTextBox = new System.Windows.Forms.TextBox();
            this.aDRESTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.pAYTextBox = new System.Windows.Forms.TextBox();
            this.mARITALComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTTableAdapter = new Lab2.DataSet1TableAdapters.DEPARTMENTTableAdapter();
            this.COURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Lab2.DataSet1();
            this.cOURSETableAdapter = new Lab2.DataSet1TableAdapters.COURSETableAdapter();
            this.tRAININGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tRAININGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            nUMLabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            sNAMELabel = new System.Windows.Forms.Label();
            bDAYLabel = new System.Windows.Forms.Label();
            pOSTLabel = new System.Windows.Forms.Label();
            aDRESLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            pAYLabel = new System.Windows.Forms.Label();
            mARITALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingNavigator)).BeginInit();
            this.pERSONALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAININGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAININGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nUMLabel
            // 
            nUMLabel.AutoSize = true;
            nUMLabel.Location = new System.Drawing.Point(306, 88);
            nUMLabel.Name = "nUMLabel";
            nUMLabel.Size = new System.Drawing.Size(44, 13);
            nUMLabel.TabIndex = 3;
            nUMLabel.Text = "Номер:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(306, 114);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(59, 13);
            lNAMELabel.TabIndex = 5;
            lNAMELabel.Text = "Фамилия:";
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(306, 143);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(32, 13);
            fNAMELabel.TabIndex = 7;
            fNAMELabel.Text = "Имя:";
            // 
            // sNAMELabel
            // 
            sNAMELabel.AutoSize = true;
            sNAMELabel.Location = new System.Drawing.Point(306, 173);
            sNAMELabel.Name = "sNAMELabel";
            sNAMELabel.Size = new System.Drawing.Size(57, 13);
            sNAMELabel.TabIndex = 9;
            sNAMELabel.Text = "Отчество:";
            // 
            // bDAYLabel
            // 
            bDAYLabel.AutoSize = true;
            bDAYLabel.Location = new System.Drawing.Point(306, 198);
            bDAYLabel.Name = "bDAYLabel";
            bDAYLabel.Size = new System.Drawing.Size(89, 13);
            bDAYLabel.TabIndex = 11;
            bDAYLabel.Text = "Дата рождения:";
            // 
            // pOSTLabel
            // 
            pOSTLabel.AutoSize = true;
            pOSTLabel.Location = new System.Drawing.Point(306, 221);
            pOSTLabel.Name = "pOSTLabel";
            pOSTLabel.Size = new System.Drawing.Size(68, 13);
            pOSTLabel.TabIndex = 13;
            pOSTLabel.Text = "Должность:";
            // 
            // aDRESLabel
            // 
            aDRESLabel.AutoSize = true;
            aDRESLabel.Location = new System.Drawing.Point(306, 247);
            aDRESLabel.Name = "aDRESLabel";
            aDRESLabel.Size = new System.Drawing.Size(41, 13);
            aDRESLabel.TabIndex = 15;
            aDRESLabel.Text = "Адрес:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(698, 88);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(55, 13);
            pHONELabel.TabIndex = 17;
            pHONELabel.Text = "Телефон:";
            // 
            // pAYLabel
            // 
            pAYLabel.AutoSize = true;
            pAYLabel.Location = new System.Drawing.Point(699, 114);
            pAYLabel.Name = "pAYLabel";
            pAYLabel.Size = new System.Drawing.Size(42, 13);
            pAYLabel.TabIndex = 19;
            pAYLabel.Text = "Оклад:";
            // 
            // mARITALLabel
            // 
            mARITALLabel.AutoSize = true;
            mARITALLabel.Location = new System.Drawing.Point(698, 156);
            mARITALLabel.Name = "mARITALLabel";
            mARITALLabel.Size = new System.Drawing.Size(66, 13);
            mARITALLabel.TabIndex = 21;
            mARITALLabel.Text = "положение:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONALBindingSource
            // 
            this.pERSONALBindingSource.DataMember = "PERSONAL";
            this.pERSONALBindingSource.DataSource = this.dataSet1;
            // 
            // pERSONALTableAdapter
            // 
            this.pERSONALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = null;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.PERSONALTableAdapter = this.pERSONALTableAdapter;
            this.tableAdapterManager.TRAININGTableAdapter = this.tRAININGTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tRAININGTableAdapter
            // 
            this.tRAININGTableAdapter.ClearBeforeFill = true;
            // 
            // pERSONALBindingNavigator
            // 
            this.pERSONALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pERSONALBindingNavigator.BindingSource = this.pERSONALBindingSource;
            this.pERSONALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pERSONALBindingNavigator.CountItemFormat = "из {0}";
            this.pERSONALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pERSONALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.pERSONALBindingNavigatorSaveItem});
            this.pERSONALBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.pERSONALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pERSONALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pERSONALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pERSONALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pERSONALBindingNavigator.Name = "pERSONALBindingNavigator";
            this.pERSONALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pERSONALBindingNavigator.Size = new System.Drawing.Size(1023, 25);
            this.pERSONALBindingNavigator.TabIndex = 1;
            this.pERSONALBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Добавить новую запись";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
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
            this.bindingNavigatorDeleteItem.ToolTipText = "Удалить выбранную запись";
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
            // pERSONALBindingNavigatorSaveItem
            // 
            this.pERSONALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pERSONALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pERSONALBindingNavigatorSaveItem.Image")));
            this.pERSONALBindingNavigatorSaveItem.Name = "pERSONALBindingNavigatorSaveItem";
            this.pERSONALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pERSONALBindingNavigatorSaveItem.Text = "Save Data";
            this.pERSONALBindingNavigatorSaveItem.ToolTipText = "Сохранить изменения";
            this.pERSONALBindingNavigatorSaveItem.Click += new System.EventHandler(this.pERSONALBindingNavigatorSaveItem_Click);
            // 
            // pERSONALDataGridView
            // 
            this.pERSONALDataGridView.AllowUserToAddRows = false;
            this.pERSONALDataGridView.AllowUserToDeleteRows = false;
            this.pERSONALDataGridView.AutoGenerateColumns = false;
            this.pERSONALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pERSONALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FIO});
            this.pERSONALDataGridView.DataSource = this.pERSONALBindingSource;
            this.pERSONALDataGridView.Location = new System.Drawing.Point(12, 55);
            this.pERSONALDataGridView.MultiSelect = false;
            this.pERSONALDataGridView.Name = "pERSONALDataGridView";
            this.pERSONALDataGridView.ReadOnly = true;
            this.pERSONALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pERSONALDataGridView.Size = new System.Drawing.Size(246, 533);
            this.pERSONALDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "Сотрудник";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.образованиеToolStripMenuItem,
            this.курсыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // образованиеToolStripMenuItem
            // 
            this.образованиеToolStripMenuItem.Name = "образованиеToolStripMenuItem";
            this.образованиеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.образованиеToolStripMenuItem.Text = "Образование";
            // 
            // курсыToolStripMenuItem
            // 
            this.курсыToolStripMenuItem.Name = "курсыToolStripMenuItem";
            this.курсыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.курсыToolStripMenuItem.Text = "Курсы";
            this.курсыToolStripMenuItem.Click += new System.EventHandler(this.курсыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // nUMTextBox
            // 
            this.nUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "NUM", true));
            this.nUMTextBox.Location = new System.Drawing.Point(407, 88);
            this.nUMTextBox.Name = "nUMTextBox";
            this.nUMTextBox.Size = new System.Drawing.Size(200, 20);
            this.nUMTextBox.TabIndex = 4;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(407, 114);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.lNAMETextBox.TabIndex = 6;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(407, 140);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.fNAMETextBox.TabIndex = 8;
            // 
            // sNAMETextBox
            // 
            this.sNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "SNAME", true));
            this.sNAMETextBox.Location = new System.Drawing.Point(407, 166);
            this.sNAMETextBox.Name = "sNAMETextBox";
            this.sNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.sNAMETextBox.TabIndex = 10;
            // 
            // bDAYDateTimePicker
            // 
            this.bDAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pERSONALBindingSource, "BDAY", true));
            this.bDAYDateTimePicker.Location = new System.Drawing.Point(407, 192);
            this.bDAYDateTimePicker.Name = "bDAYDateTimePicker";
            this.bDAYDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.bDAYDateTimePicker.TabIndex = 12;
            // 
            // pOSTTextBox
            // 
            this.pOSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "POST", true));
            this.pOSTTextBox.Location = new System.Drawing.Point(407, 218);
            this.pOSTTextBox.Name = "pOSTTextBox";
            this.pOSTTextBox.Size = new System.Drawing.Size(200, 20);
            this.pOSTTextBox.TabIndex = 14;
            // 
            // aDRESTextBox
            // 
            this.aDRESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "ADRES", true));
            this.aDRESTextBox.Location = new System.Drawing.Point(407, 247);
            this.aDRESTextBox.Multiline = true;
            this.aDRESTextBox.Name = "aDRESTextBox";
            this.aDRESTextBox.Size = new System.Drawing.Size(200, 67);
            this.aDRESTextBox.TabIndex = 16;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(799, 85);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(200, 20);
            this.pHONETextBox.TabIndex = 18;
            // 
            // pAYTextBox
            // 
            this.pAYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PAY", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.pAYTextBox.Location = new System.Drawing.Point(799, 111);
            this.pAYTextBox.Name = "pAYTextBox";
            this.pAYTextBox.Size = new System.Drawing.Size(200, 20);
            this.pAYTextBox.TabIndex = 20;
            // 
            // mARITALComboBox
            // 
            this.mARITALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "MARITAL", true));
            this.mARITALComboBox.FormattingEnabled = true;
            this.mARITALComboBox.Items.AddRange(new object[] {
            "женат",
            "замужем",
            "не женат",
            "не замужем"});
            this.mARITALComboBox.Location = new System.Drawing.Point(799, 153);
            this.mARITALComboBox.Name = "mARITALComboBox";
            this.mARITALComboBox.Size = new System.Drawing.Size(121, 21);
            this.mARITALComboBox.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pERSONALBindingSource, "CHILD", true));
            this.checkBox1.Location = new System.Drawing.Point(799, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Есть дети:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Семейное";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pERSONALBindingSource, "DEP_CODE", true));
            this.comboBox1.DataSource = this.dEPARTMENTBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(799, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ID";
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.dataSet1;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // COURSEBindingSource
            // 
            this.COURSEBindingSource.DataMember = "COURSE";
            this.COURSEBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // tRAININGBindingSource
            // 
            this.tRAININGBindingSource.DataMember = "FK_TRAINING_1";
            this.tRAININGBindingSource.DataSource = this.pERSONALBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.tRAININGDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(264, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 285);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.tRAININGBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.CountItemFormat = "из {0}";
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(729, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            this.toolStripButton1.ToolTipText = "Добавить новую запись";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.ToolTipText = "Удалить выбранную запись";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Save Data";
            this.toolStripButton7.ToolTipText = "Сохранить изменения";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click_1);
            // 
            // tRAININGDataGridView
            // 
            this.tRAININGDataGridView.AutoGenerateColumns = false;
            this.tRAININGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRAININGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.DOCUMENT,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.tRAININGDataGridView.DataSource = this.tRAININGBindingSource;
            this.tRAININGDataGridView.Location = new System.Drawing.Point(22, 45);
            this.tRAININGDataGridView.Name = "tRAININGDataGridView";
            this.tRAININGDataGridView.Size = new System.Drawing.Size(707, 220);
            this.tRAININGDataGridView.TabIndex = 0;
            this.tRAININGDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tRAININGDataGridView_CellFormating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE_BEG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала курсов";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATE_END";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата окончания курсов";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DOCUMENT
            // 
            this.DOCUMENT.DataPropertyName = "DOCUMENT";
            this.DOCUMENT.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DOCUMENT.HeaderText = "документ";
            this.DOCUMENT.Items.AddRange(new object[] {
            "диплом",
            "Свидетельсто"});
            this.DOCUMENT.Name = "DOCUMENT";
            this.DOCUMENT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DOCUMENT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LENGHT_CRS";
            this.dataGridViewTextBoxColumn6.HeaderText = "Кол-во часов";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "COST";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FULLTIME";
            this.dataGridViewTextBoxColumn8.HeaderText = "Очные";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "COURSE_CODE";
            this.dataGridViewTextBoxColumn10.DataSource = this.COURSEBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "NAME";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn10.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(mARITALLabel);
            this.Controls.Add(this.mARITALComboBox);
            this.Controls.Add(nUMLabel);
            this.Controls.Add(this.nUMTextBox);
            this.Controls.Add(lNAMELabel);
            this.Controls.Add(this.lNAMETextBox);
            this.Controls.Add(fNAMELabel);
            this.Controls.Add(this.fNAMETextBox);
            this.Controls.Add(sNAMELabel);
            this.Controls.Add(this.sNAMETextBox);
            this.Controls.Add(bDAYLabel);
            this.Controls.Add(this.bDAYDateTimePicker);
            this.Controls.Add(pOSTLabel);
            this.Controls.Add(this.pOSTTextBox);
            this.Controls.Add(aDRESLabel);
            this.Controls.Add(this.aDRESTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(pAYLabel);
            this.Controls.Add(this.pAYTextBox);
            this.Controls.Add(this.pERSONALDataGridView);
            this.Controls.Add(this.pERSONALBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FromClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingNavigator)).EndInit();
            this.pERSONALBindingNavigator.ResumeLayout(false);
            this.pERSONALBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAININGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRAININGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pERSONALBindingSource;
        private DataSet1TableAdapters.PERSONALTableAdapter pERSONALTableAdapter;
        private System.Windows.Forms.BindingNavigator pERSONALBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pERSONALBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pERSONALDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox nUMTextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox sNAMETextBox;
        private System.Windows.Forms.DateTimePicker bDAYDateTimePicker;
        private System.Windows.Forms.TextBox pOSTTextBox;
        private System.Windows.Forms.TextBox aDRESTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox pAYTextBox;
        private System.Windows.Forms.ComboBox mARITALComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private DataSet1TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem курсыToolStripMenuItem;
        private System.Windows.Forms.BindingSource COURSEBindingSource;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource tRAININGBindingSource;
        private DataSet1TableAdapters.TRAININGTableAdapter tRAININGTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridView tRAININGDataGridView;
        public DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn DOCUMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
    }
}

