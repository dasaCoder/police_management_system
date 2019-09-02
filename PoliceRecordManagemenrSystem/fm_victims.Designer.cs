namespace PoliceRecordManagemenrSystem
{
    partial class fm_victims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_victims));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.policeDataDataSet = new PoliceRecordManagemenrSystem.PoliceDataDataSet();
            this.victimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.victimTableAdapter = new PoliceRecordManagemenrSystem.PoliceDataDataSetTableAdapters.victimTableAdapter();
            this.pnl_addnewvict = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSelectedVic = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvictimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permenentaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.RichTextBox();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtoccupa = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.cgender = new System.Windows.Forms.ComboBox();
            this.cnationality = new System.Windows.Forms.ComboBox();
            this.creligion = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.policeDataDataSet1 = new PoliceRecordManagemenrSystem.PoliceDataDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victimBindingSource)).BeginInit();
            this.pnl_addnewvict.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // policeDataDataSet
            // 
            this.policeDataDataSet.DataSetName = "PoliceDataDataSet";
            this.policeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // victimBindingSource
            // 
            this.victimBindingSource.DataMember = "victim";
            this.victimBindingSource.DataSource = this.policeDataDataSet;
            // 
            // victimTableAdapter
            // 
            this.victimTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_addnewvict
            // 
            this.pnl_addnewvict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_addnewvict.Controls.Add(this.button6);
            this.pnl_addnewvict.Controls.Add(this.txtSelectedVic);
            this.pnl_addnewvict.Controls.Add(this.groupBox1);
            this.pnl_addnewvict.Controls.Add(this.button5);
            this.pnl_addnewvict.Location = new System.Drawing.Point(14, 13);
            this.pnl_addnewvict.Name = "pnl_addnewvict";
            this.pnl_addnewvict.Size = new System.Drawing.Size(826, 648);
            this.pnl_addnewvict.TabIndex = 3;
            this.pnl_addnewvict.Visible = false;
            this.pnl_addnewvict.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_addnewvict_Paint);
            this.pnl_addnewvict.Enter += new System.EventHandler(this.addvictivepnl_load);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(606, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Proceed";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtSelectedVic
            // 
            this.txtSelectedVic.Location = new System.Drawing.Point(402, 23);
            this.txtSelectedVic.Name = "txtSelectedVic";
            this.txtSelectedVic.Size = new System.Drawing.Size(198, 22);
            this.txtSelectedVic.TabIndex = 3;
            this.txtSelectedVic.TextChanged += new System.EventHandler(this.TxtSelectedVic_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 526);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Victims";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvictimDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.permenentaddressDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.mobilenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.religonDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.victimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 446);
            this.dataGridView1.TabIndex = 1;
            // 
            // idvictimDataGridViewTextBoxColumn
            // 
            this.idvictimDataGridViewTextBoxColumn.DataPropertyName = "idvictim";
            this.idvictimDataGridViewTextBoxColumn.HeaderText = "idvictim";
            this.idvictimDataGridViewTextBoxColumn.Name = "idvictimDataGridViewTextBoxColumn";
            this.idvictimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "bday";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // permenentaddressDataGridViewTextBoxColumn
            // 
            this.permenentaddressDataGridViewTextBoxColumn.DataPropertyName = "permenent_address";
            this.permenentaddressDataGridViewTextBoxColumn.HeaderText = "permenent_address";
            this.permenentaddressDataGridViewTextBoxColumn.Name = "permenentaddressDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            this.occupationDataGridViewTextBoxColumn.Visible = false;
            // 
            // mobilenumberDataGridViewTextBoxColumn
            // 
            this.mobilenumberDataGridViewTextBoxColumn.DataPropertyName = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.HeaderText = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.Name = "mobilenumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // religonDataGridViewTextBoxColumn
            // 
            this.religonDataGridViewTextBoxColumn.DataPropertyName = "religon";
            this.religonDataGridViewTextBoxColumn.HeaderText = "religon";
            this.religonDataGridViewTextBoxColumn.Name = "religonDataGridViewTextBoxColumn";
            this.religonDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(719, 619);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtlname);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtcontact);
            this.groupBox2.Controls.Add(this.txtaddr);
            this.groupBox2.Controls.Add(this.dtdob);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtoccupa);
            this.groupBox2.Controls.Add(this.txtnic);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.cgender);
            this.groupBox2.Controls.Add(this.cnationality);
            this.groupBox2.Controls.Add(this.creligion);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Location = new System.Drawing.Point(4, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 642);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Victim Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txtlname
            // 
            this.txtlname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "lname", true));
            this.txtlname.Location = new System.Drawing.Point(132, 74);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(232, 22);
            this.txtlname.TabIndex = 20;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(19, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "Last Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 595);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "mobile_number", true));
            this.txtcontact.Location = new System.Drawing.Point(132, 523);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(233, 22);
            this.txtcontact.TabIndex = 25;
            // 
            // txtaddr
            // 
            this.txtaddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "permenent_address", true));
            this.txtaddr.Location = new System.Drawing.Point(133, 190);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(232, 69);
            this.txtaddr.TabIndex = 24;
            this.txtaddr.Text = "";
            // 
            // dtdob
            // 
            this.dtdob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "bday", true));
            this.dtdob.Location = new System.Drawing.Point(134, 153);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(231, 22);
            this.dtdob.TabIndex = 23;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "email", true));
            this.txtemail.Location = new System.Drawing.Point(133, 326);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(232, 22);
            this.txtemail.TabIndex = 22;
            // 
            // txtoccupa
            // 
            this.txtoccupa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "occupation", true));
            this.txtoccupa.Location = new System.Drawing.Point(133, 279);
            this.txtoccupa.Name = "txtoccupa";
            this.txtoccupa.Size = new System.Drawing.Size(232, 22);
            this.txtoccupa.TabIndex = 21;
            // 
            // txtnic
            // 
            this.txtnic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "nic", true));
            this.txtnic.Location = new System.Drawing.Point(133, 113);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(232, 22);
            this.txtnic.TabIndex = 19;
            // 
            // txtfname
            // 
            this.txtfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "fname", true));
            this.txtfname.Location = new System.Drawing.Point(133, 34);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(232, 22);
            this.txtfname.TabIndex = 18;
            // 
            // cgender
            // 
            this.cgender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "gender", true));
            this.cgender.FormattingEnabled = true;
            this.cgender.Items.AddRange(new object[] {
            "Married",
            "UnMarried"});
            this.cgender.Location = new System.Drawing.Point(133, 483);
            this.cgender.Name = "cgender";
            this.cgender.Size = new System.Drawing.Size(232, 24);
            this.cgender.TabIndex = 15;
            // 
            // cnationality
            // 
            this.cnationality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "nationality", true));
            this.cnationality.FormattingEnabled = true;
            this.cnationality.Items.AddRange(new object[] {
            "Sinhala",
            "Tamil"});
            this.cnationality.Location = new System.Drawing.Point(133, 429);
            this.cnationality.Name = "cnationality";
            this.cnationality.Size = new System.Drawing.Size(232, 24);
            this.cnationality.TabIndex = 14;
            // 
            // creligion
            // 
            this.creligion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.victimBindingSource, "religon", true));
            this.creligion.FormattingEnabled = true;
            this.creligion.Items.AddRange(new object[] {
            "Buddhist",
            "Hindu"});
            this.creligion.Location = new System.Drawing.Point(133, 374);
            this.creligion.Name = "creligion";
            this.creligion.Size = new System.Drawing.Size(232, 24);
            this.creligion.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 276);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 16);
            this.label26.TabIndex = 12;
            this.label26.Text = "Occupation";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 203);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 16);
            this.label27.TabIndex = 11;
            this.label27.Text = "Permenant Address";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 156);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 16);
            this.label28.TabIndex = 10;
            this.label28.Text = "Date of Birth";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 40);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 16);
            this.label29.TabIndex = 9;
            this.label29.Text = "First Name";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 369);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 16);
            this.label30.TabIndex = 7;
            this.label30.Text = "Religon";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 423);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 16);
            this.label31.TabIndex = 6;
            this.label31.Text = "Nationality";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(22, 526);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 16);
            this.label32.TabIndex = 5;
            this.label32.Text = "Contact No";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 322);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 16);
            this.label33.TabIndex = 4;
            this.label33.Text = "email address";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 483);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 16);
            this.label34.TabIndex = 3;
            this.label34.Text = "Gender";
            this.label34.Click += new System.EventHandler(this.Label34_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 116);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 16);
            this.label37.TabIndex = 0;
            this.label37.Text = "Victim NIC";
            // 
            // policeDataDataSet1
            // 
            this.policeDataDataSet1.DataSetName = "PoliceDataDataSet";
            this.policeDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl_addnewvict);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 670);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 26;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fm_victims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 672);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_victims";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victims";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_victims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victimBindingSource)).EndInit();
            this.pnl_addnewvict.ResumeLayout(false);
            this.pnl_addnewvict.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeDataDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private PoliceDataDataSet policeDataDataSet;
        private System.Windows.Forms.BindingSource victimBindingSource;
        private PoliceDataDataSetTableAdapters.victimTableAdapter victimTableAdapter;
        private System.Windows.Forms.Panel pnl_addnewvict;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.RichTextBox txtaddr;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtoccupa;
        private System.Windows.Forms.TextBox txtlname;
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
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private PoliceDataDataSet policeDataDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvictimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permenentaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSelectedVic;
        private System.Windows.Forms.ImageList imageList1;
    }
}