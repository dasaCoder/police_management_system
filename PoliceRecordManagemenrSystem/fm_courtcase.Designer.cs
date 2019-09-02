namespace PoliceRecordManagemenrSystem
{
    partial class fm_courtcase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_courtcase));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_viewwitness = new System.Windows.Forms.Button();
            this.btn_addcourtcase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_entrygrid_court = new System.Windows.Forms.Panel();
            this.gb_courtcasedataupdate = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_next = new System.Windows.Forms.DateTimePicker();
            this.dt_last = new System.Windows.Forms.DateTimePicker();
            this.btn_addcc = new System.Windows.Forms.Button();
            this.tb_entryidupdate = new System.Windows.Forms.TextBox();
            this.entryrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeDataDataSet = new PoliceRecordManagemenrSystem.PoliceDataDataSet();
            this.lbl_entryidupdate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvictim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_viewcourtcase = new System.Windows.Forms.Panel();
            this.gb_viewcourtcase = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_entryid = new System.Windows.Forms.TextBox();
            this.lbl_entryid = new System.Windows.Forms.Label();
            this.table_courtcaseview = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_newcourtcase = new System.Windows.Forms.Panel();
            this.btn_savecomplain = new System.Windows.Forms.Button();
            this.btn_cancelcourtcase = new System.Windows.Forms.Button();
            this.gb_courtcase = new System.Windows.Forms.GroupBox();
            this.dtp_nextcourtdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_lastcourtdate = new System.Windows.Forms.DateTimePicker();
            this.tb_ccentryid = new System.Windows.Forms.TextBox();
            this.lbl_ccentryid = new System.Windows.Forms.Label();
            this.lbl_lastcourtdate = new System.Windows.Forms.Label();
            this.lbl_nextcourtdate = new System.Windows.Forms.Label();
            this.entryrecordsTableAdapter = new PoliceRecordManagemenrSystem.PoliceDataDataSetTableAdapters.entryrecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_entrygrid_court.SuspendLayout();
            this.gb_courtcasedataupdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_viewcourtcase.SuspendLayout();
            this.gb_viewcourtcase.SuspendLayout();
            this.pnl_newcourtcase.SuspendLayout();
            this.gb_courtcase.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btn_home);
            this.splitContainer1.Panel1.Controls.Add(this.btn_viewwitness);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addcourtcase);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pnl_entrygrid_court);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_viewcourtcase);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_newcourtcase);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(6, 449);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(233, 35);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // btn_viewwitness
            // 
            this.btn_viewwitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewwitness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewwitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewwitness.Location = new System.Drawing.Point(6, 319);
            this.btn_viewwitness.Name = "btn_viewwitness";
            this.btn_viewwitness.Size = new System.Drawing.Size(233, 35);
            this.btn_viewwitness.TabIndex = 4;
            this.btn_viewwitness.Text = "View Court Case";
            this.btn_viewwitness.UseVisualStyleBackColor = false;
            this.btn_viewwitness.Click += new System.EventHandler(this.Btn_viewwitness_Click);
            // 
            // btn_addcourtcase
            // 
            this.btn_addcourtcase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addcourtcase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addcourtcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcourtcase.Location = new System.Drawing.Point(6, 256);
            this.btn_addcourtcase.Name = "btn_addcourtcase";
            this.btn_addcourtcase.Size = new System.Drawing.Size(233, 35);
            this.btn_addcourtcase.TabIndex = 3;
            this.btn_addcourtcase.Text = "New Court Case";
            this.btn_addcourtcase.UseVisualStyleBackColor = false;
            this.btn_addcourtcase.Click += new System.EventHandler(this.Btn_addcourtcase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_entrygrid_court
            // 
            this.pnl_entrygrid_court.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_entrygrid_court.Controls.Add(this.gb_courtcasedataupdate);
            this.pnl_entrygrid_court.Location = new System.Drawing.Point(0, 0);
            this.pnl_entrygrid_court.Name = "pnl_entrygrid_court";
            this.pnl_entrygrid_court.Size = new System.Drawing.Size(802, 539);
            this.pnl_entrygrid_court.TabIndex = 12;
            this.pnl_entrygrid_court.Visible = false;
            // 
            // gb_courtcasedataupdate
            // 
            this.gb_courtcasedataupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_courtcasedataupdate.Controls.Add(this.groupBox1);
            this.gb_courtcasedataupdate.Controls.Add(this.dataGridView1);
            this.gb_courtcasedataupdate.Location = new System.Drawing.Point(22, 14);
            this.gb_courtcasedataupdate.Name = "gb_courtcasedataupdate";
            this.gb_courtcasedataupdate.Size = new System.Drawing.Size(756, 487);
            this.gb_courtcasedataupdate.TabIndex = 0;
            this.gb_courtcasedataupdate.TabStop = false;
            this.gb_courtcasedataupdate.Text = "Court CaseData";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_next);
            this.groupBox1.Controls.Add(this.dt_last);
            this.groupBox1.Controls.Add(this.btn_addcc);
            this.groupBox1.Controls.Add(this.tb_entryidupdate);
            this.groupBox1.Controls.Add(this.lbl_entryidupdate);
            this.groupBox1.Location = new System.Drawing.Point(25, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Court Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Court Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Next Court Date";
            // 
            // dt_next
            // 
            this.dt_next.Location = new System.Drawing.Point(463, 112);
            this.dt_next.Name = "dt_next";
            this.dt_next.Size = new System.Drawing.Size(200, 22);
            this.dt_next.TabIndex = 4;
            // 
            // dt_last
            // 
            this.dt_last.Location = new System.Drawing.Point(132, 113);
            this.dt_last.Name = "dt_last";
            this.dt_last.Size = new System.Drawing.Size(200, 22);
            this.dt_last.TabIndex = 3;
            // 
            // btn_addcc
            // 
            this.btn_addcc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addcc.Location = new System.Drawing.Point(528, 150);
            this.btn_addcc.Name = "btn_addcc";
            this.btn_addcc.Size = new System.Drawing.Size(135, 29);
            this.btn_addcc.TabIndex = 2;
            this.btn_addcc.Text = "Add Court case";
            this.btn_addcc.UseVisualStyleBackColor = false;
            this.btn_addcc.Click += new System.EventHandler(this.Btn_addcc_Click);
            // 
            // tb_entryidupdate
            // 
            this.tb_entryidupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryrecordsBindingSource, "identry", true));
            this.tb_entryidupdate.Location = new System.Drawing.Point(97, 55);
            this.tb_entryidupdate.Name = "tb_entryidupdate";
            this.tb_entryidupdate.Size = new System.Drawing.Size(79, 22);
            this.tb_entryidupdate.TabIndex = 1;
            // 
            // entryrecordsBindingSource
            // 
            this.entryrecordsBindingSource.DataMember = "entryrecords";
            this.entryrecordsBindingSource.DataSource = this.policeDataDataSet;
            // 
            // policeDataDataSet
            // 
            this.policeDataDataSet.DataSetName = "PoliceDataDataSet";
            this.policeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_entryidupdate
            // 
            this.lbl_entryidupdate.AutoSize = true;
            this.lbl_entryidupdate.Location = new System.Drawing.Point(21, 58);
            this.lbl_entryidupdate.Name = "lbl_entryidupdate";
            this.lbl_entryidupdate.Size = new System.Drawing.Size(54, 16);
            this.lbl_entryidupdate.TabIndex = 0;
            this.lbl_entryidupdate.Text = "Entry ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identryDataGridViewTextBoxColumn,
            this.idvictim,
            this.division,
            this.entrytypeDataGridViewTextBoxColumn,
            this.entrydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryrecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // identryDataGridViewTextBoxColumn
            // 
            this.identryDataGridViewTextBoxColumn.DataPropertyName = "identry";
            this.identryDataGridViewTextBoxColumn.HeaderText = "identry";
            this.identryDataGridViewTextBoxColumn.Name = "identryDataGridViewTextBoxColumn";
            this.identryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvictim
            // 
            this.idvictim.DataPropertyName = "idvictim";
            this.idvictim.HeaderText = "idvictim";
            this.idvictim.Name = "idvictim";
            // 
            // division
            // 
            this.division.DataPropertyName = "division";
            this.division.HeaderText = "division";
            this.division.Name = "division";
            // 
            // entrytypeDataGridViewTextBoxColumn
            // 
            this.entrytypeDataGridViewTextBoxColumn.DataPropertyName = "entry_type";
            this.entrytypeDataGridViewTextBoxColumn.HeaderText = "entry_type";
            this.entrytypeDataGridViewTextBoxColumn.Name = "entrytypeDataGridViewTextBoxColumn";
            // 
            // entrydateDataGridViewTextBoxColumn
            // 
            this.entrydateDataGridViewTextBoxColumn.DataPropertyName = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.HeaderText = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.Name = "entrydateDataGridViewTextBoxColumn";
            // 
            // pnl_viewcourtcase
            // 
            this.pnl_viewcourtcase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_viewcourtcase.Controls.Add(this.gb_viewcourtcase);
            this.pnl_viewcourtcase.Controls.Add(this.table_courtcaseview);
            this.pnl_viewcourtcase.Location = new System.Drawing.Point(0, 0);
            this.pnl_viewcourtcase.Name = "pnl_viewcourtcase";
            this.pnl_viewcourtcase.Size = new System.Drawing.Size(802, 525);
            this.pnl_viewcourtcase.TabIndex = 12;
            this.pnl_viewcourtcase.Visible = false;
            // 
            // gb_viewcourtcase
            // 
            this.gb_viewcourtcase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_viewcourtcase.Controls.Add(this.btn_search);
            this.gb_viewcourtcase.Controls.Add(this.tb_entryid);
            this.gb_viewcourtcase.Controls.Add(this.lbl_entryid);
            this.gb_viewcourtcase.Location = new System.Drawing.Point(14, 43);
            this.gb_viewcourtcase.Name = "gb_viewcourtcase";
            this.gb_viewcourtcase.Size = new System.Drawing.Size(771, 83);
            this.gb_viewcourtcase.TabIndex = 0;
            this.gb_viewcourtcase.TabStop = false;
            this.gb_viewcourtcase.Text = "Court Case Data";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(418, 35);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(135, 29);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search ";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // tb_entryid
            // 
            this.tb_entryid.Location = new System.Drawing.Point(140, 38);
            this.tb_entryid.Name = "tb_entryid";
            this.tb_entryid.Size = new System.Drawing.Size(237, 22);
            this.tb_entryid.TabIndex = 1;
            // 
            // lbl_entryid
            // 
            this.lbl_entryid.AutoSize = true;
            this.lbl_entryid.Location = new System.Drawing.Point(52, 41);
            this.lbl_entryid.Name = "lbl_entryid";
            this.lbl_entryid.Size = new System.Drawing.Size(54, 16);
            this.lbl_entryid.TabIndex = 0;
            this.lbl_entryid.Text = "Entry ID";
            // 
            // table_courtcaseview
            // 
            this.table_courtcaseview.ColumnCount = 10;
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_courtcaseview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.table_courtcaseview.Location = new System.Drawing.Point(10, 177);
            this.table_courtcaseview.Name = "table_courtcaseview";
            this.table_courtcaseview.RowCount = 2;
            this.table_courtcaseview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.table_courtcaseview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.table_courtcaseview.Size = new System.Drawing.Size(771, 182);
            this.table_courtcaseview.TabIndex = 1;
            // 
            // pnl_newcourtcase
            // 
            this.pnl_newcourtcase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_newcourtcase.Controls.Add(this.btn_savecomplain);
            this.pnl_newcourtcase.Controls.Add(this.btn_cancelcourtcase);
            this.pnl_newcourtcase.Controls.Add(this.gb_courtcase);
            this.pnl_newcourtcase.Location = new System.Drawing.Point(13, 12);
            this.pnl_newcourtcase.Name = "pnl_newcourtcase";
            this.pnl_newcourtcase.Size = new System.Drawing.Size(792, 530);
            this.pnl_newcourtcase.TabIndex = 0;
            // 
            // btn_savecomplain
            // 
            this.btn_savecomplain.Location = new System.Drawing.Point(404, 263);
            this.btn_savecomplain.Name = "btn_savecomplain";
            this.btn_savecomplain.Size = new System.Drawing.Size(87, 29);
            this.btn_savecomplain.TabIndex = 5;
            this.btn_savecomplain.Text = "Save";
            this.btn_savecomplain.UseVisualStyleBackColor = true;
            // 
            // btn_cancelcourtcase
            // 
            this.btn_cancelcourtcase.Location = new System.Drawing.Point(263, 263);
            this.btn_cancelcourtcase.Name = "btn_cancelcourtcase";
            this.btn_cancelcourtcase.Size = new System.Drawing.Size(89, 29);
            this.btn_cancelcourtcase.TabIndex = 4;
            this.btn_cancelcourtcase.Text = "Cancel";
            this.btn_cancelcourtcase.UseVisualStyleBackColor = true;
            // 
            // gb_courtcase
            // 
            this.gb_courtcase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_courtcase.Controls.Add(this.dtp_nextcourtdate);
            this.gb_courtcase.Controls.Add(this.dtp_lastcourtdate);
            this.gb_courtcase.Controls.Add(this.tb_ccentryid);
            this.gb_courtcase.Controls.Add(this.lbl_ccentryid);
            this.gb_courtcase.Controls.Add(this.lbl_lastcourtdate);
            this.gb_courtcase.Controls.Add(this.lbl_nextcourtdate);
            this.gb_courtcase.Location = new System.Drawing.Point(44, 29);
            this.gb_courtcase.Name = "gb_courtcase";
            this.gb_courtcase.Size = new System.Drawing.Size(691, 195);
            this.gb_courtcase.TabIndex = 3;
            this.gb_courtcase.TabStop = false;
            this.gb_courtcase.Text = "Court Caste Data";
            // 
            // dtp_nextcourtdate
            // 
            this.dtp_nextcourtdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_nextcourtdate.Location = new System.Drawing.Point(176, 135);
            this.dtp_nextcourtdate.Name = "dtp_nextcourtdate";
            this.dtp_nextcourtdate.Size = new System.Drawing.Size(236, 22);
            this.dtp_nextcourtdate.TabIndex = 5;
            // 
            // dtp_lastcourtdate
            // 
            this.dtp_lastcourtdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_lastcourtdate.Location = new System.Drawing.Point(176, 86);
            this.dtp_lastcourtdate.Name = "dtp_lastcourtdate";
            this.dtp_lastcourtdate.Size = new System.Drawing.Size(236, 22);
            this.dtp_lastcourtdate.TabIndex = 4;
            // 
            // tb_ccentryid
            // 
            this.tb_ccentryid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ccentryid.Location = new System.Drawing.Point(176, 45);
            this.tb_ccentryid.Name = "tb_ccentryid";
            this.tb_ccentryid.Size = new System.Drawing.Size(236, 22);
            this.tb_ccentryid.TabIndex = 3;
            // 
            // lbl_ccentryid
            // 
            this.lbl_ccentryid.AutoSize = true;
            this.lbl_ccentryid.Location = new System.Drawing.Point(42, 48);
            this.lbl_ccentryid.Name = "lbl_ccentryid";
            this.lbl_ccentryid.Size = new System.Drawing.Size(54, 16);
            this.lbl_ccentryid.TabIndex = 0;
            this.lbl_ccentryid.Text = "Entry ID";
            // 
            // lbl_lastcourtdate
            // 
            this.lbl_lastcourtdate.AutoSize = true;
            this.lbl_lastcourtdate.Location = new System.Drawing.Point(41, 91);
            this.lbl_lastcourtdate.Name = "lbl_lastcourtdate";
            this.lbl_lastcourtdate.Size = new System.Drawing.Size(99, 16);
            this.lbl_lastcourtdate.TabIndex = 1;
            this.lbl_lastcourtdate.Text = "Last Court Date";
            // 
            // lbl_nextcourtdate
            // 
            this.lbl_nextcourtdate.AutoSize = true;
            this.lbl_nextcourtdate.Location = new System.Drawing.Point(41, 139);
            this.lbl_nextcourtdate.Name = "lbl_nextcourtdate";
            this.lbl_nextcourtdate.Size = new System.Drawing.Size(101, 16);
            this.lbl_nextcourtdate.TabIndex = 2;
            this.lbl_nextcourtdate.Text = "Next Court Date";
            // 
            // entryrecordsTableAdapter
            // 
            this.entryrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // fm_courtcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_courtcase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Court Cases";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_courtcase_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_entrygrid_court.ResumeLayout(false);
            this.gb_courtcasedataupdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_viewcourtcase.ResumeLayout(false);
            this.gb_viewcourtcase.ResumeLayout(false);
            this.gb_viewcourtcase.PerformLayout();
            this.pnl_newcourtcase.ResumeLayout(false);
            this.gb_courtcase.ResumeLayout(false);
            this.gb_courtcase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_viewwitness;
        private System.Windows.Forms.Button btn_addcourtcase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_newcourtcase;
        private System.Windows.Forms.Label lbl_nextcourtdate;
        private System.Windows.Forms.Label lbl_lastcourtdate;
        private System.Windows.Forms.Label lbl_ccentryid;
        private System.Windows.Forms.Panel pnl_viewcourtcase;
        private System.Windows.Forms.GroupBox gb_viewcourtcase;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_entryid;
        private System.Windows.Forms.Label lbl_entryid;
        private System.Windows.Forms.TableLayoutPanel table_courtcaseview;
        private System.Windows.Forms.Panel pnl_entrygrid_court;
        private System.Windows.Forms.GroupBox gb_courtcasedataupdate;
        private System.Windows.Forms.Button btn_addcc;
        private System.Windows.Forms.TextBox tb_entryidupdate;
        private System.Windows.Forms.Label lbl_entryidupdate;
        private System.Windows.Forms.GroupBox gb_courtcase;
        private System.Windows.Forms.Button btn_savecomplain;
        private System.Windows.Forms.Button btn_cancelcourtcase;
        private System.Windows.Forms.DateTimePicker dtp_nextcourtdate;
        private System.Windows.Forms.DateTimePicker dtp_lastcourtdate;
        private System.Windows.Forms.TextBox tb_ccentryid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceDataDataSet policeDataDataSet;
        private System.Windows.Forms.BindingSource entryrecordsBindingSource;
        private PoliceDataDataSetTableAdapters.entryrecordsTableAdapter entryrecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvictim;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_next;
        private System.Windows.Forms.DateTimePicker dt_last;
    }
}