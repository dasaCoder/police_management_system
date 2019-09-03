namespace PoliceRecordManagemenrSystem
{
    partial class fm_suspects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_suspects));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_suspect = new System.Windows.Forms.Button();
            this.btn_viewsuspect = new System.Windows.Forms.Button();
            this.btn_addsuspect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_updatesuspect = new System.Windows.Forms.Panel();
            this.gb_entrydataupdate = new System.Windows.Forms.GroupBox();
            this.btn_searchsuspect = new System.Windows.Forms.Button();
            this.tb_suspectnic = new System.Windows.Forms.TextBox();
            this.lbl_entryidupdate = new System.Windows.Forms.Label();
            this.pnl_newsuspect = new System.Windows.Forms.Panel();
            this.gb_suspectdata = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_viewsuspect = new System.Windows.Forms.Panel();
            this.gb_viewsuspect = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_entryidview = new System.Windows.Forms.TextBox();
            this.lbl_suspectview = new System.Windows.Forms.Label();
            this.table_suspectupdate = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEntryforsuspect = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.policeDataDataSet = new PoliceRecordManagemenrSystem.PoliceDataDataSet();
            this.entryrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryrecordsTableAdapter = new PoliceRecordManagemenrSystem.PoliceDataDataSetTableAdapters.entryrecordsTableAdapter();
            this.identryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvictimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSentryid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.RichTextBox();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.txtoccupa = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.cgender = new System.Windows.Forms.ComboBox();
            this.creligion = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cnationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_updatesuspect.SuspendLayout();
            this.gb_entrydataupdate.SuspendLayout();
            this.pnl_newsuspect.SuspendLayout();
            this.gb_suspectdata.SuspendLayout();
            this.pnl_viewsuspect.SuspendLayout();
            this.gb_viewsuspect.SuspendLayout();
            this.pnlEntryforsuspect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryrecordsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_home);
            this.splitContainer1.Panel1.Controls.Add(this.btn_suspect);
            this.splitContainer1.Panel1.Controls.Add(this.btn_viewsuspect);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addsuspect);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pnl_newsuspect);
            this.splitContainer1.Panel2.Controls.Add(this.pnlEntryforsuspect);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_updatesuspect);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_viewsuspect);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1208, 584);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(6, 450);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(266, 35);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // btn_suspect
            // 
            this.btn_suspect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_suspect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_suspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspect.Location = new System.Drawing.Point(6, 384);
            this.btn_suspect.Name = "btn_suspect";
            this.btn_suspect.Size = new System.Drawing.Size(266, 35);
            this.btn_suspect.TabIndex = 5;
            this.btn_suspect.Text = "Update Record";
            this.btn_suspect.UseVisualStyleBackColor = false;
            this.btn_suspect.Click += new System.EventHandler(this.Btn_suspect_Click);
            // 
            // btn_viewsuspect
            // 
            this.btn_viewsuspect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewsuspect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewsuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewsuspect.Location = new System.Drawing.Point(6, 317);
            this.btn_viewsuspect.Name = "btn_viewsuspect";
            this.btn_viewsuspect.Size = new System.Drawing.Size(266, 35);
            this.btn_viewsuspect.TabIndex = 4;
            this.btn_viewsuspect.Text = "View Suspect";
            this.btn_viewsuspect.UseVisualStyleBackColor = false;
            this.btn_viewsuspect.Click += new System.EventHandler(this.Btn_viewsuspect_Click);
            // 
            // btn_addsuspect
            // 
            this.btn_addsuspect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addsuspect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addsuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsuspect.Location = new System.Drawing.Point(6, 256);
            this.btn_addsuspect.Name = "btn_addsuspect";
            this.btn_addsuspect.Size = new System.Drawing.Size(266, 35);
            this.btn_addsuspect.TabIndex = 3;
            this.btn_addsuspect.Text = "New Suspect";
            this.btn_addsuspect.UseVisualStyleBackColor = false;
            this.btn_addsuspect.Click += new System.EventHandler(this.Btn_addsuspect_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(248, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_updatesuspect
            // 
            this.pnl_updatesuspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_updatesuspect.Controls.Add(this.gb_entrydataupdate);
            this.pnl_updatesuspect.Location = new System.Drawing.Point(8, 3);
            this.pnl_updatesuspect.Name = "pnl_updatesuspect";
            this.pnl_updatesuspect.Size = new System.Drawing.Size(914, 567);
            this.pnl_updatesuspect.TabIndex = 11;
            this.pnl_updatesuspect.Visible = false;
            // 
            // gb_entrydataupdate
            // 
            this.gb_entrydataupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_entrydataupdate.Controls.Add(this.btn_searchsuspect);
            this.gb_entrydataupdate.Controls.Add(this.tb_suspectnic);
            this.gb_entrydataupdate.Controls.Add(this.lbl_entryidupdate);
            this.gb_entrydataupdate.Location = new System.Drawing.Point(22, 14);
            this.gb_entrydataupdate.Name = "gb_entrydataupdate";
            this.gb_entrydataupdate.Size = new System.Drawing.Size(868, 85);
            this.gb_entrydataupdate.TabIndex = 0;
            this.gb_entrydataupdate.TabStop = false;
            this.gb_entrydataupdate.Text = "Suspect Data";
            // 
            // btn_searchsuspect
            // 
            this.btn_searchsuspect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_searchsuspect.Location = new System.Drawing.Point(418, 35);
            this.btn_searchsuspect.Name = "btn_searchsuspect";
            this.btn_searchsuspect.Size = new System.Drawing.Size(135, 29);
            this.btn_searchsuspect.TabIndex = 2;
            this.btn_searchsuspect.Text = "Search";
            this.btn_searchsuspect.UseVisualStyleBackColor = false;
            // 
            // tb_suspectnic
            // 
            this.tb_suspectnic.Location = new System.Drawing.Point(140, 38);
            this.tb_suspectnic.Name = "tb_suspectnic";
            this.tb_suspectnic.Size = new System.Drawing.Size(237, 22);
            this.tb_suspectnic.TabIndex = 1;
            // 
            // lbl_entryidupdate
            // 
            this.lbl_entryidupdate.AutoSize = true;
            this.lbl_entryidupdate.Location = new System.Drawing.Point(52, 41);
            this.lbl_entryidupdate.Name = "lbl_entryidupdate";
            this.lbl_entryidupdate.Size = new System.Drawing.Size(82, 16);
            this.lbl_entryidupdate.TabIndex = 0;
            this.lbl_entryidupdate.Text = "Suspect NIC";
            // 
            // pnl_newsuspect
            // 
            this.pnl_newsuspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_newsuspect.Controls.Add(this.gb_suspectdata);
            this.pnl_newsuspect.Location = new System.Drawing.Point(0, 0);
            this.pnl_newsuspect.Name = "pnl_newsuspect";
            this.pnl_newsuspect.Size = new System.Drawing.Size(882, 531);
            this.pnl_newsuspect.TabIndex = 0;
            this.pnl_newsuspect.Visible = false;
            // 
            // gb_suspectdata
            // 
            this.gb_suspectdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_suspectdata.Controls.Add(this.txtlname);
            this.gb_suspectdata.Controls.Add(this.label36);
            this.gb_suspectdata.Controls.Add(this.txtcontact);
            this.gb_suspectdata.Controls.Add(this.txtaddr);
            this.gb_suspectdata.Controls.Add(this.dtdob);
            this.gb_suspectdata.Controls.Add(this.txtoccupa);
            this.gb_suspectdata.Controls.Add(this.txtnic);
            this.gb_suspectdata.Controls.Add(this.txtfname);
            this.gb_suspectdata.Controls.Add(this.cgender);
            this.gb_suspectdata.Controls.Add(this.cnationality);
            this.gb_suspectdata.Controls.Add(this.creligion);
            this.gb_suspectdata.Controls.Add(this.label26);
            this.gb_suspectdata.Controls.Add(this.label27);
            this.gb_suspectdata.Controls.Add(this.label28);
            this.gb_suspectdata.Controls.Add(this.label29);
            this.gb_suspectdata.Controls.Add(this.label30);
            this.gb_suspectdata.Controls.Add(this.label31);
            this.gb_suspectdata.Controls.Add(this.label32);
            this.gb_suspectdata.Controls.Add(this.label34);
            this.gb_suspectdata.Controls.Add(this.label37);
            this.gb_suspectdata.Controls.Add(this.btn_cancel);
            this.gb_suspectdata.Controls.Add(this.btn_save);
            this.gb_suspectdata.Location = new System.Drawing.Point(12, 17);
            this.gb_suspectdata.Name = "gb_suspectdata";
            this.gb_suspectdata.Size = new System.Drawing.Size(855, 511);
            this.gb_suspectdata.TabIndex = 0;
            this.gb_suspectdata.TabStop = false;
            this.gb_suspectdata.Text = "Suspect Data";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(678, 414);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 29);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(678, 369);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 29);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // pnl_viewsuspect
            // 
            this.pnl_viewsuspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_viewsuspect.Controls.Add(this.gb_viewsuspect);
            this.pnl_viewsuspect.Controls.Add(this.table_suspectupdate);
            this.pnl_viewsuspect.Location = new System.Drawing.Point(11, 12);
            this.pnl_viewsuspect.Name = "pnl_viewsuspect";
            this.pnl_viewsuspect.Size = new System.Drawing.Size(902, 541);
            this.pnl_viewsuspect.TabIndex = 11;
            this.pnl_viewsuspect.Visible = false;
            // 
            // gb_viewsuspect
            // 
            this.gb_viewsuspect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_viewsuspect.Controls.Add(this.btn_search);
            this.gb_viewsuspect.Controls.Add(this.tb_entryidview);
            this.gb_viewsuspect.Controls.Add(this.lbl_suspectview);
            this.gb_viewsuspect.Location = new System.Drawing.Point(18, 14);
            this.gb_viewsuspect.Name = "gb_viewsuspect";
            this.gb_viewsuspect.Size = new System.Drawing.Size(871, 83);
            this.gb_viewsuspect.TabIndex = 0;
            this.gb_viewsuspect.TabStop = false;
            this.gb_viewsuspect.Text = "Suspect Data";
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
            // tb_entryidview
            // 
            this.tb_entryidview.Location = new System.Drawing.Point(140, 38);
            this.tb_entryidview.Name = "tb_entryidview";
            this.tb_entryidview.Size = new System.Drawing.Size(237, 22);
            this.tb_entryidview.TabIndex = 1;
            // 
            // lbl_suspectview
            // 
            this.lbl_suspectview.AutoSize = true;
            this.lbl_suspectview.Location = new System.Drawing.Point(52, 41);
            this.lbl_suspectview.Name = "lbl_suspectview";
            this.lbl_suspectview.Size = new System.Drawing.Size(82, 16);
            this.lbl_suspectview.TabIndex = 0;
            this.lbl_suspectview.Text = "Suspect NIC";
            // 
            // table_suspectupdate
            // 
            this.table_suspectupdate.ColumnCount = 10;
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_suspectupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.table_suspectupdate.Location = new System.Drawing.Point(18, 128);
            this.table_suspectupdate.Name = "table_suspectupdate";
            this.table_suspectupdate.RowCount = 2;
            this.table_suspectupdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.table_suspectupdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.table_suspectupdate.Size = new System.Drawing.Size(856, 180);
            this.table_suspectupdate.TabIndex = 1;
            // 
            // pnlEntryforsuspect
            // 
            this.pnlEntryforsuspect.Controls.Add(this.groupBox2);
            this.pnlEntryforsuspect.Controls.Add(this.groupBox1);
            this.pnlEntryforsuspect.Location = new System.Drawing.Point(0, 0);
            this.pnlEntryforsuspect.Name = "pnlEntryforsuspect";
            this.pnlEntryforsuspect.Size = new System.Drawing.Size(910, 581);
            this.pnlEntryforsuspect.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identryDataGridViewTextBoxColumn,
            this.entrytypeDataGridViewTextBoxColumn,
            this.entrydateDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idvictimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryrecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(44, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // policeDataDataSet
            // 
            this.policeDataDataSet.DataSetName = "PoliceDataDataSet";
            this.policeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryrecordsBindingSource
            // 
            this.entryrecordsBindingSource.DataMember = "entryrecords";
            this.entryrecordsBindingSource.DataSource = this.policeDataDataSet;
            // 
            // entryrecordsTableAdapter
            // 
            this.entryrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // identryDataGridViewTextBoxColumn
            // 
            this.identryDataGridViewTextBoxColumn.DataPropertyName = "identry";
            this.identryDataGridViewTextBoxColumn.HeaderText = "identry";
            this.identryDataGridViewTextBoxColumn.Name = "identryDataGridViewTextBoxColumn";
            this.identryDataGridViewTextBoxColumn.ReadOnly = true;
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
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "iduser";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "iduser";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            // 
            // idvictimDataGridViewTextBoxColumn
            // 
            this.idvictimDataGridViewTextBoxColumn.DataPropertyName = "idvictim";
            this.idvictimDataGridViewTextBoxColumn.HeaderText = "idvictim";
            this.idvictimDataGridViewTextBoxColumn.Name = "idvictimDataGridViewTextBoxColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtSentryid);
            this.groupBox2.Location = new System.Drawing.Point(42, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtSentryid
            // 
            this.txtSentryid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryrecordsBindingSource, "identry", true));
            this.txtSentryid.Location = new System.Drawing.Point(428, 49);
            this.txtSentryid.Name = "txtSentryid";
            this.txtSentryid.Size = new System.Drawing.Size(188, 22);
            this.txtSentryid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(151, 78);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(232, 22);
            this.txtlname.TabIndex = 44;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(38, 78);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 16);
            this.label36.TabIndex = 29;
            this.label36.Text = "Last Name";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(525, 179);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(233, 22);
            this.txtcontact.TabIndex = 49;
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(37, 279);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(346, 68);
            this.txtaddr.TabIndex = 48;
            this.txtaddr.Text = "";
            this.txtaddr.TextChanged += new System.EventHandler(this.Txtaddr_TextChanged);
            // 
            // dtdob
            // 
            this.dtdob.Location = new System.Drawing.Point(153, 157);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(231, 22);
            this.dtdob.TabIndex = 47;
            // 
            // txtoccupa
            // 
            this.txtoccupa.Location = new System.Drawing.Point(153, 196);
            this.txtoccupa.Name = "txtoccupa";
            this.txtoccupa.Size = new System.Drawing.Size(232, 22);
            this.txtoccupa.TabIndex = 45;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(152, 117);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(232, 22);
            this.txtnic.TabIndex = 43;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(152, 38);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(232, 22);
            this.txtfname.TabIndex = 42;
            // 
            // cgender
            // 
            this.cgender.FormattingEnabled = true;
            this.cgender.Items.AddRange(new object[] {
            "Married",
            "UnMarried"});
            this.cgender.Location = new System.Drawing.Point(526, 133);
            this.cgender.Name = "cgender";
            this.cgender.Size = new System.Drawing.Size(232, 24);
            this.cgender.TabIndex = 41;
            // 
            // creligion
            // 
            this.creligion.FormattingEnabled = true;
            this.creligion.Items.AddRange(new object[] {
            "Buddhist",
            "Hindu"});
            this.creligion.Location = new System.Drawing.Point(526, 45);
            this.creligion.Name = "creligion";
            this.creligion.Size = new System.Drawing.Size(232, 24);
            this.creligion.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(36, 193);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 16);
            this.label26.TabIndex = 38;
            this.label26.Text = "Occupation";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 247);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 16);
            this.label27.TabIndex = 37;
            this.label27.Text = "Permenant Address";
            this.label27.Click += new System.EventHandler(this.Label27_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(35, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 16);
            this.label28.TabIndex = 36;
            this.label28.Text = "Date of Birth";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(35, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 16);
            this.label29.TabIndex = 35;
            this.label29.Text = "First Name";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(415, 53);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 16);
            this.label30.TabIndex = 34;
            this.label30.Text = "Religon";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(415, 181);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 16);
            this.label32.TabIndex = 32;
            this.label32.Text = "Contact No";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(415, 137);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 16);
            this.label34.TabIndex = 30;
            this.label34.Text = "Gender";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(35, 120);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 16);
            this.label37.TabIndex = 28;
            this.label37.Text = "Victim NIC";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(415, 97);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 16);
            this.label31.TabIndex = 33;
            this.label31.Text = "Nationality";
            // 
            // cnationality
            // 
            this.cnationality.FormattingEnabled = true;
            this.cnationality.Items.AddRange(new object[] {
            "Sinhala",
            "Tamil"});
            this.cnationality.Location = new System.Drawing.Point(526, 93);
            this.cnationality.Name = "cnationality";
            this.cnationality.Size = new System.Drawing.Size(232, 24);
            this.cnationality.TabIndex = 40;
            // 
            // fm_suspects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 584);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_suspects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suspects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_suspects_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_updatesuspect.ResumeLayout(false);
            this.gb_entrydataupdate.ResumeLayout(false);
            this.gb_entrydataupdate.PerformLayout();
            this.pnl_newsuspect.ResumeLayout(false);
            this.gb_suspectdata.ResumeLayout(false);
            this.gb_suspectdata.PerformLayout();
            this.pnl_viewsuspect.ResumeLayout(false);
            this.gb_viewsuspect.ResumeLayout(false);
            this.gb_viewsuspect.PerformLayout();
            this.pnlEntryforsuspect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryrecordsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addsuspect;
        private System.Windows.Forms.Button btn_viewsuspect;
        private System.Windows.Forms.Button btn_suspect;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_newsuspect;
        private System.Windows.Forms.GroupBox gb_suspectdata;
        private System.Windows.Forms.Panel pnl_updatesuspect;
        private System.Windows.Forms.TableLayoutPanel table_suspectupdate;
        private System.Windows.Forms.GroupBox gb_entrydataupdate;
        private System.Windows.Forms.Button btn_searchsuspect;
        private System.Windows.Forms.TextBox tb_suspectnic;
        private System.Windows.Forms.Label lbl_entryidupdate;
        private System.Windows.Forms.Panel pnl_viewsuspect;
        private System.Windows.Forms.GroupBox gb_viewsuspect;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_entryidview;
        private System.Windows.Forms.Label lbl_suspectview;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnlEntryforsuspect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceDataDataSet policeDataDataSet;
        private System.Windows.Forms.BindingSource entryrecordsBindingSource;
        private PoliceDataDataSetTableAdapters.entryrecordsTableAdapter entryrecordsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSentryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn identryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvictimDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.RichTextBox txtaddr;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.TextBox txtoccupa;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.ComboBox cgender;
        private System.Windows.Forms.ComboBox cnationality;
        private System.Windows.Forms.ComboBox creligion;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label37;
    }
}