namespace PoliceRecordManagemenrSystem
{
    partial class fm_witness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_witness));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_updatewitness = new System.Windows.Forms.Button();
            this.btn_viewwitness = new System.Windows.Forms.Button();
            this.btn_addwitness = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_updatewitness = new System.Windows.Forms.Panel();
            this.table_witnessupdate = new System.Windows.Forms.TableLayoutPanel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancelupdate = new System.Windows.Forms.Button();
            this.gb_witnessdataupdate = new System.Windows.Forms.GroupBox();
            this.btn_searchwitness = new System.Windows.Forms.Button();
            this.tb_witnessnic = new System.Windows.Forms.TextBox();
            this.lbl_witnessnicupdate = new System.Windows.Forms.Label();
            this.pnl_newwitness = new System.Windows.Forms.Panel();
            this.gb_suspectdata = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_witnesscontact = new System.Windows.Forms.TextBox();
            this.rtb_witnessaddress = new System.Windows.Forms.RichTextBox();
            this.dtp_witnessbday = new System.Windows.Forms.DateTimePicker();
            this.tb_witnessemail = new System.Windows.Forms.TextBox();
            this.tb_witnessoccupation = new System.Windows.Forms.TextBox();
            this.tb_witnesslname = new System.Windows.Forms.TextBox();
            this.tb_nicwitness = new System.Windows.Forms.TextBox();
            this.tb_witnessfname = new System.Windows.Forms.TextBox();
            this.rb_witnessfemale = new System.Windows.Forms.RadioButton();
            this.rb_witnessmale = new System.Windows.Forms.RadioButton();
            this.cb_witnessstatus = new System.Windows.Forms.ComboBox();
            this.cb_witnessnationality = new System.Windows.Forms.ComboBox();
            this.cb_witnessreligon = new System.Windows.Forms.ComboBox();
            this.lbl_occupation = new System.Windows.Forms.Label();
            this.lbl_susaddress = new System.Windows.Forms.Label();
            this.lbl_susbday = new System.Windows.Forms.Label();
            this.lbl_susfname = new System.Windows.Forms.Label();
            this.lbl_religon = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_suscontact = new System.Windows.Forms.Label();
            this.lbl_susemail = new System.Windows.Forms.Label();
            this.lbl_susstatus = new System.Windows.Forms.Label();
            this.lbl_susgender = new System.Windows.Forms.Label();
            this.lbl_suslname = new System.Windows.Forms.Label();
            this.lbl_witnessnic = new System.Windows.Forms.Label();
            this.pnl_viewwitness = new System.Windows.Forms.Panel();
            this.gb_viewwitness = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_viewwitnessnic = new System.Windows.Forms.TextBox();
            this.lbl_witnessviewnic = new System.Windows.Forms.Label();
            this.table_witnessview = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_updatewitness.SuspendLayout();
            this.gb_witnessdataupdate.SuspendLayout();
            this.pnl_newwitness.SuspendLayout();
            this.gb_suspectdata.SuspendLayout();
            this.pnl_viewwitness.SuspendLayout();
            this.gb_viewwitness.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_updatewitness);
            this.splitContainer1.Panel1.Controls.Add(this.btn_viewwitness);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addwitness);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pnl_updatewitness);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_newwitness);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_viewwitness);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 554);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(6, 450);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(249, 35);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // btn_updatewitness
            // 
            this.btn_updatewitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updatewitness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updatewitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatewitness.Location = new System.Drawing.Point(6, 384);
            this.btn_updatewitness.Name = "btn_updatewitness";
            this.btn_updatewitness.Size = new System.Drawing.Size(249, 35);
            this.btn_updatewitness.TabIndex = 5;
            this.btn_updatewitness.Text = "Update Record";
            this.btn_updatewitness.UseVisualStyleBackColor = false;
            this.btn_updatewitness.Click += new System.EventHandler(this.Btn_updatewitness_Click);
            // 
            // btn_viewwitness
            // 
            this.btn_viewwitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewwitness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewwitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewwitness.Location = new System.Drawing.Point(6, 317);
            this.btn_viewwitness.Name = "btn_viewwitness";
            this.btn_viewwitness.Size = new System.Drawing.Size(249, 35);
            this.btn_viewwitness.TabIndex = 4;
            this.btn_viewwitness.Text = "View Witness";
            this.btn_viewwitness.UseVisualStyleBackColor = false;
            this.btn_viewwitness.Click += new System.EventHandler(this.Btn_viewwitness_Click);
            // 
            // btn_addwitness
            // 
            this.btn_addwitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addwitness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addwitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addwitness.Location = new System.Drawing.Point(6, 256);
            this.btn_addwitness.Name = "btn_addwitness";
            this.btn_addwitness.Size = new System.Drawing.Size(249, 35);
            this.btn_addwitness.TabIndex = 3;
            this.btn_addwitness.Text = "New Witness";
            this.btn_addwitness.UseVisualStyleBackColor = false;
            this.btn_addwitness.Click += new System.EventHandler(this.Btn_addwitness_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(231, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_updatewitness
            // 
            this.pnl_updatewitness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_updatewitness.Controls.Add(this.table_witnessupdate);
            this.pnl_updatewitness.Controls.Add(this.btn_update);
            this.pnl_updatewitness.Controls.Add(this.btn_cancelupdate);
            this.pnl_updatewitness.Controls.Add(this.gb_witnessdataupdate);
            this.pnl_updatewitness.Location = new System.Drawing.Point(8, 3);
            this.pnl_updatewitness.Name = "pnl_updatewitness";
            this.pnl_updatewitness.Size = new System.Drawing.Size(859, 539);
            this.pnl_updatewitness.TabIndex = 11;
            this.pnl_updatewitness.Visible = false;
            // 
            // table_witnessupdate
            // 
            this.table_witnessupdate.ColumnCount = 10;
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_witnessupdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.table_witnessupdate.Location = new System.Drawing.Point(46, 187);
            this.table_witnessupdate.Name = "table_witnessupdate";
            this.table_witnessupdate.RowCount = 2;
            this.table_witnessupdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.table_witnessupdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.table_witnessupdate.Size = new System.Drawing.Size(751, 242);
            this.table_witnessupdate.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(642, 142);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 29);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_cancelupdate
            // 
            this.btn_cancelupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelupdate.Location = new System.Drawing.Point(762, 142);
            this.btn_cancelupdate.Name = "btn_cancelupdate";
            this.btn_cancelupdate.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelupdate.TabIndex = 3;
            this.btn_cancelupdate.Text = "Cancel";
            this.btn_cancelupdate.UseVisualStyleBackColor = false;
            // 
            // gb_witnessdataupdate
            // 
            this.gb_witnessdataupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_witnessdataupdate.Controls.Add(this.btn_searchwitness);
            this.gb_witnessdataupdate.Controls.Add(this.tb_witnessnic);
            this.gb_witnessdataupdate.Controls.Add(this.lbl_witnessnicupdate);
            this.gb_witnessdataupdate.Location = new System.Drawing.Point(22, 14);
            this.gb_witnessdataupdate.Name = "gb_witnessdataupdate";
            this.gb_witnessdataupdate.Size = new System.Drawing.Size(813, 85);
            this.gb_witnessdataupdate.TabIndex = 0;
            this.gb_witnessdataupdate.TabStop = false;
            this.gb_witnessdataupdate.Text = "Witness Data";
            // 
            // btn_searchwitness
            // 
            this.btn_searchwitness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_searchwitness.Location = new System.Drawing.Point(418, 35);
            this.btn_searchwitness.Name = "btn_searchwitness";
            this.btn_searchwitness.Size = new System.Drawing.Size(135, 29);
            this.btn_searchwitness.TabIndex = 2;
            this.btn_searchwitness.Text = "Search";
            this.btn_searchwitness.UseVisualStyleBackColor = false;
            // 
            // tb_witnessnic
            // 
            this.tb_witnessnic.Location = new System.Drawing.Point(140, 38);
            this.tb_witnessnic.Name = "tb_witnessnic";
            this.tb_witnessnic.Size = new System.Drawing.Size(237, 22);
            this.tb_witnessnic.TabIndex = 1;
            // 
            // lbl_witnessnicupdate
            // 
            this.lbl_witnessnicupdate.AutoSize = true;
            this.lbl_witnessnicupdate.Location = new System.Drawing.Point(52, 41);
            this.lbl_witnessnicupdate.Name = "lbl_witnessnicupdate";
            this.lbl_witnessnicupdate.Size = new System.Drawing.Size(82, 16);
            this.lbl_witnessnicupdate.TabIndex = 0;
            this.lbl_witnessnicupdate.Text = "Suspect NIC";
            // 
            // pnl_newwitness
            // 
            this.pnl_newwitness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_newwitness.Controls.Add(this.gb_suspectdata);
            this.pnl_newwitness.Location = new System.Drawing.Point(3, 6);
            this.pnl_newwitness.Name = "pnl_newwitness";
            this.pnl_newwitness.Size = new System.Drawing.Size(864, 520);
            this.pnl_newwitness.TabIndex = 0;
            this.pnl_newwitness.Visible = false;
            // 
            // gb_suspectdata
            // 
            this.gb_suspectdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_suspectdata.Controls.Add(this.btn_cancel);
            this.gb_suspectdata.Controls.Add(this.btn_save);
            this.gb_suspectdata.Controls.Add(this.tb_witnesscontact);
            this.gb_suspectdata.Controls.Add(this.rtb_witnessaddress);
            this.gb_suspectdata.Controls.Add(this.dtp_witnessbday);
            this.gb_suspectdata.Controls.Add(this.tb_witnessemail);
            this.gb_suspectdata.Controls.Add(this.tb_witnessoccupation);
            this.gb_suspectdata.Controls.Add(this.tb_witnesslname);
            this.gb_suspectdata.Controls.Add(this.tb_nicwitness);
            this.gb_suspectdata.Controls.Add(this.tb_witnessfname);
            this.gb_suspectdata.Controls.Add(this.rb_witnessfemale);
            this.gb_suspectdata.Controls.Add(this.rb_witnessmale);
            this.gb_suspectdata.Controls.Add(this.cb_witnessstatus);
            this.gb_suspectdata.Controls.Add(this.cb_witnessnationality);
            this.gb_suspectdata.Controls.Add(this.cb_witnessreligon);
            this.gb_suspectdata.Controls.Add(this.lbl_occupation);
            this.gb_suspectdata.Controls.Add(this.lbl_susaddress);
            this.gb_suspectdata.Controls.Add(this.lbl_susbday);
            this.gb_suspectdata.Controls.Add(this.lbl_susfname);
            this.gb_suspectdata.Controls.Add(this.lbl_religon);
            this.gb_suspectdata.Controls.Add(this.lbl_nationality);
            this.gb_suspectdata.Controls.Add(this.lbl_suscontact);
            this.gb_suspectdata.Controls.Add(this.lbl_susemail);
            this.gb_suspectdata.Controls.Add(this.lbl_susstatus);
            this.gb_suspectdata.Controls.Add(this.lbl_susgender);
            this.gb_suspectdata.Controls.Add(this.lbl_suslname);
            this.gb_suspectdata.Controls.Add(this.lbl_witnessnic);
            this.gb_suspectdata.Location = new System.Drawing.Point(12, 17);
            this.gb_suspectdata.Name = "gb_suspectdata";
            this.gb_suspectdata.Size = new System.Drawing.Size(837, 479);
            this.gb_suspectdata.TabIndex = 0;
            this.gb_suspectdata.TabStop = false;
            this.gb_suspectdata.Text = "Suspect Data";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(739, 85);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 29);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(739, 40);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 29);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // tb_witnesscontact
            // 
            this.tb_witnesscontact.Location = new System.Drawing.Point(524, 115);
            this.tb_witnesscontact.Name = "tb_witnesscontact";
            this.tb_witnesscontact.Size = new System.Drawing.Size(159, 22);
            this.tb_witnesscontact.TabIndex = 25;
            // 
            // rtb_witnessaddress
            // 
            this.rtb_witnessaddress.Location = new System.Drawing.Point(178, 150);
            this.rtb_witnessaddress.Name = "rtb_witnessaddress";
            this.rtb_witnessaddress.Size = new System.Drawing.Size(232, 69);
            this.rtb_witnessaddress.TabIndex = 24;
            this.rtb_witnessaddress.Text = "";
            // 
            // dtp_witnessbday
            // 
            this.dtp_witnessbday.Location = new System.Drawing.Point(179, 113);
            this.dtp_witnessbday.Name = "dtp_witnessbday";
            this.dtp_witnessbday.Size = new System.Drawing.Size(231, 22);
            this.dtp_witnessbday.TabIndex = 23;
            // 
            // tb_witnessemail
            // 
            this.tb_witnessemail.Location = new System.Drawing.Point(178, 286);
            this.tb_witnessemail.Name = "tb_witnessemail";
            this.tb_witnessemail.Size = new System.Drawing.Size(232, 22);
            this.tb_witnessemail.TabIndex = 22;
            // 
            // tb_witnessoccupation
            // 
            this.tb_witnessoccupation.Location = new System.Drawing.Point(178, 239);
            this.tb_witnessoccupation.Name = "tb_witnessoccupation";
            this.tb_witnessoccupation.Size = new System.Drawing.Size(232, 22);
            this.tb_witnessoccupation.TabIndex = 21;
            // 
            // tb_witnesslname
            // 
            this.tb_witnesslname.Location = new System.Drawing.Point(525, 37);
            this.tb_witnesslname.Name = "tb_witnesslname";
            this.tb_witnesslname.Size = new System.Drawing.Size(159, 22);
            this.tb_witnesslname.TabIndex = 20;
            // 
            // tb_nicwitness
            // 
            this.tb_nicwitness.Location = new System.Drawing.Point(178, 73);
            this.tb_nicwitness.Name = "tb_nicwitness";
            this.tb_nicwitness.Size = new System.Drawing.Size(232, 22);
            this.tb_nicwitness.TabIndex = 19;
            // 
            // tb_witnessfname
            // 
            this.tb_witnessfname.Location = new System.Drawing.Point(178, 34);
            this.tb_witnessfname.Name = "tb_witnessfname";
            this.tb_witnessfname.Size = new System.Drawing.Size(232, 22);
            this.tb_witnessfname.TabIndex = 18;
            // 
            // rb_witnessfemale
            // 
            this.rb_witnessfemale.AutoSize = true;
            this.rb_witnessfemale.Location = new System.Drawing.Point(588, 77);
            this.rb_witnessfemale.Name = "rb_witnessfemale";
            this.rb_witnessfemale.Size = new System.Drawing.Size(72, 20);
            this.rb_witnessfemale.TabIndex = 17;
            this.rb_witnessfemale.TabStop = true;
            this.rb_witnessfemale.Text = "Female";
            this.rb_witnessfemale.UseVisualStyleBackColor = true;
            // 
            // rb_witnessmale
            // 
            this.rb_witnessmale.AutoSize = true;
            this.rb_witnessmale.Location = new System.Drawing.Point(524, 77);
            this.rb_witnessmale.Name = "rb_witnessmale";
            this.rb_witnessmale.Size = new System.Drawing.Size(56, 20);
            this.rb_witnessmale.TabIndex = 16;
            this.rb_witnessmale.TabStop = true;
            this.rb_witnessmale.Text = "Male";
            this.rb_witnessmale.UseVisualStyleBackColor = true;
            this.rb_witnessmale.CheckedChanged += new System.EventHandler(this.Rb_susmale_CheckedChanged);
            // 
            // cb_witnessstatus
            // 
            this.cb_witnessstatus.FormattingEnabled = true;
            this.cb_witnessstatus.Location = new System.Drawing.Point(178, 443);
            this.cb_witnessstatus.Name = "cb_witnessstatus";
            this.cb_witnessstatus.Size = new System.Drawing.Size(232, 24);
            this.cb_witnessstatus.TabIndex = 15;
            // 
            // cb_witnessnationality
            // 
            this.cb_witnessnationality.FormattingEnabled = true;
            this.cb_witnessnationality.Location = new System.Drawing.Point(178, 389);
            this.cb_witnessnationality.Name = "cb_witnessnationality";
            this.cb_witnessnationality.Size = new System.Drawing.Size(232, 24);
            this.cb_witnessnationality.TabIndex = 14;
            // 
            // cb_witnessreligon
            // 
            this.cb_witnessreligon.FormattingEnabled = true;
            this.cb_witnessreligon.Location = new System.Drawing.Point(178, 334);
            this.cb_witnessreligon.Name = "cb_witnessreligon";
            this.cb_witnessreligon.Size = new System.Drawing.Size(232, 24);
            this.cb_witnessreligon.TabIndex = 13;
            // 
            // lbl_occupation
            // 
            this.lbl_occupation.AutoSize = true;
            this.lbl_occupation.Location = new System.Drawing.Point(29, 236);
            this.lbl_occupation.Name = "lbl_occupation";
            this.lbl_occupation.Size = new System.Drawing.Size(76, 16);
            this.lbl_occupation.TabIndex = 12;
            this.lbl_occupation.Text = "Occupation";
            // 
            // lbl_susaddress
            // 
            this.lbl_susaddress.AutoSize = true;
            this.lbl_susaddress.Location = new System.Drawing.Point(29, 163);
            this.lbl_susaddress.Name = "lbl_susaddress";
            this.lbl_susaddress.Size = new System.Drawing.Size(127, 16);
            this.lbl_susaddress.TabIndex = 11;
            this.lbl_susaddress.Text = "Permenant Address";
            // 
            // lbl_susbday
            // 
            this.lbl_susbday.AutoSize = true;
            this.lbl_susbday.Location = new System.Drawing.Point(29, 116);
            this.lbl_susbday.Name = "lbl_susbday";
            this.lbl_susbday.Size = new System.Drawing.Size(80, 16);
            this.lbl_susbday.TabIndex = 10;
            this.lbl_susbday.Text = "Date of Birth";
            // 
            // lbl_susfname
            // 
            this.lbl_susfname.AutoSize = true;
            this.lbl_susfname.Location = new System.Drawing.Point(29, 40);
            this.lbl_susfname.Name = "lbl_susfname";
            this.lbl_susfname.Size = new System.Drawing.Size(73, 16);
            this.lbl_susfname.TabIndex = 9;
            this.lbl_susfname.Text = "First Name";
            // 
            // lbl_religon
            // 
            this.lbl_religon.AutoSize = true;
            this.lbl_religon.Location = new System.Drawing.Point(29, 329);
            this.lbl_religon.Name = "lbl_religon";
            this.lbl_religon.Size = new System.Drawing.Size(55, 16);
            this.lbl_religon.TabIndex = 7;
            this.lbl_religon.Text = "Religon";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(29, 383);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(71, 16);
            this.lbl_nationality.TabIndex = 6;
            this.lbl_nationality.Text = "Nationality";
            // 
            // lbl_suscontact
            // 
            this.lbl_suscontact.AutoSize = true;
            this.lbl_suscontact.Location = new System.Drawing.Point(440, 118);
            this.lbl_suscontact.Name = "lbl_suscontact";
            this.lbl_suscontact.Size = new System.Drawing.Size(74, 16);
            this.lbl_suscontact.TabIndex = 5;
            this.lbl_suscontact.Text = "Contact No";
            // 
            // lbl_susemail
            // 
            this.lbl_susemail.AutoSize = true;
            this.lbl_susemail.Location = new System.Drawing.Point(29, 282);
            this.lbl_susemail.Name = "lbl_susemail";
            this.lbl_susemail.Size = new System.Drawing.Size(94, 16);
            this.lbl_susemail.TabIndex = 4;
            this.lbl_susemail.Text = "email address";
            // 
            // lbl_susstatus
            // 
            this.lbl_susstatus.AutoSize = true;
            this.lbl_susstatus.Location = new System.Drawing.Point(29, 443);
            this.lbl_susstatus.Name = "lbl_susstatus";
            this.lbl_susstatus.Size = new System.Drawing.Size(45, 16);
            this.lbl_susstatus.TabIndex = 3;
            this.lbl_susstatus.Text = "Status";
            // 
            // lbl_susgender
            // 
            this.lbl_susgender.AutoSize = true;
            this.lbl_susgender.Location = new System.Drawing.Point(440, 79);
            this.lbl_susgender.Name = "lbl_susgender";
            this.lbl_susgender.Size = new System.Drawing.Size(53, 16);
            this.lbl_susgender.TabIndex = 2;
            this.lbl_susgender.Text = "Gender";
            // 
            // lbl_suslname
            // 
            this.lbl_suslname.AutoSize = true;
            this.lbl_suslname.Location = new System.Drawing.Point(438, 37);
            this.lbl_suslname.Name = "lbl_suslname";
            this.lbl_suslname.Size = new System.Drawing.Size(73, 16);
            this.lbl_suslname.TabIndex = 1;
            this.lbl_suslname.Text = "Last Name";
            // 
            // lbl_witnessnic
            // 
            this.lbl_witnessnic.AutoSize = true;
            this.lbl_witnessnic.Location = new System.Drawing.Point(29, 76);
            this.lbl_witnessnic.Name = "lbl_witnessnic";
            this.lbl_witnessnic.Size = new System.Drawing.Size(81, 16);
            this.lbl_witnessnic.TabIndex = 0;
            this.lbl_witnessnic.Text = "Witness NIC";
            // 
            // pnl_viewwitness
            // 
            this.pnl_viewwitness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_viewwitness.Controls.Add(this.gb_viewwitness);
            this.pnl_viewwitness.Controls.Add(this.table_witnessview);
            this.pnl_viewwitness.Location = new System.Drawing.Point(11, 12);
            this.pnl_viewwitness.Name = "pnl_viewwitness";
            this.pnl_viewwitness.Size = new System.Drawing.Size(847, 517);
            this.pnl_viewwitness.TabIndex = 11;
            this.pnl_viewwitness.Visible = false;
            // 
            // gb_viewwitness
            // 
            this.gb_viewwitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_viewwitness.Controls.Add(this.btn_search);
            this.gb_viewwitness.Controls.Add(this.tb_viewwitnessnic);
            this.gb_viewwitness.Controls.Add(this.lbl_witnessviewnic);
            this.gb_viewwitness.Location = new System.Drawing.Point(18, 14);
            this.gb_viewwitness.Name = "gb_viewwitness";
            this.gb_viewwitness.Size = new System.Drawing.Size(816, 83);
            this.gb_viewwitness.TabIndex = 0;
            this.gb_viewwitness.TabStop = false;
            this.gb_viewwitness.Text = "Witness Data";
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
            // tb_viewwitnessnic
            // 
            this.tb_viewwitnessnic.Location = new System.Drawing.Point(140, 38);
            this.tb_viewwitnessnic.Name = "tb_viewwitnessnic";
            this.tb_viewwitnessnic.Size = new System.Drawing.Size(237, 22);
            this.tb_viewwitnessnic.TabIndex = 1;
            // 
            // lbl_witnessviewnic
            // 
            this.lbl_witnessviewnic.AutoSize = true;
            this.lbl_witnessviewnic.Location = new System.Drawing.Point(52, 41);
            this.lbl_witnessviewnic.Name = "lbl_witnessviewnic";
            this.lbl_witnessviewnic.Size = new System.Drawing.Size(81, 16);
            this.lbl_witnessviewnic.TabIndex = 0;
            this.lbl_witnessviewnic.Text = "Witness NIC";
            // 
            // table_witnessview
            // 
            this.table_witnessview.ColumnCount = 10;
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_witnessview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.table_witnessview.Location = new System.Drawing.Point(10, 124);
            this.table_witnessview.Name = "table_witnessview";
            this.table_witnessview.RowCount = 2;
            this.table_witnessview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.table_witnessview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5F));
            this.table_witnessview.Size = new System.Drawing.Size(771, 182);
            this.table_witnessview.TabIndex = 1;
            // 
            // fm_witness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_witness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witness";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_updatewitness.ResumeLayout(false);
            this.gb_witnessdataupdate.ResumeLayout(false);
            this.gb_witnessdataupdate.PerformLayout();
            this.pnl_newwitness.ResumeLayout(false);
            this.gb_suspectdata.ResumeLayout(false);
            this.gb_suspectdata.PerformLayout();
            this.pnl_viewwitness.ResumeLayout(false);
            this.gb_viewwitness.ResumeLayout(false);
            this.gb_viewwitness.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_updatewitness;
        private System.Windows.Forms.Button btn_viewwitness;
        private System.Windows.Forms.Button btn_addwitness;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_updatewitness;
        private System.Windows.Forms.TableLayoutPanel table_witnessupdate;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancelupdate;
        private System.Windows.Forms.GroupBox gb_witnessdataupdate;
        private System.Windows.Forms.Button btn_searchwitness;
        private System.Windows.Forms.TextBox tb_witnessnic;
        private System.Windows.Forms.Label lbl_witnessnicupdate;
        private System.Windows.Forms.Panel pnl_newwitness;
        private System.Windows.Forms.GroupBox gb_suspectdata;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_witnesscontact;
        private System.Windows.Forms.RichTextBox rtb_witnessaddress;
        private System.Windows.Forms.DateTimePicker dtp_witnessbday;
        private System.Windows.Forms.TextBox tb_witnessemail;
        private System.Windows.Forms.TextBox tb_witnessoccupation;
        private System.Windows.Forms.TextBox tb_witnesslname;
        private System.Windows.Forms.TextBox tb_nicwitness;
        private System.Windows.Forms.TextBox tb_witnessfname;
        private System.Windows.Forms.RadioButton rb_witnessfemale;
        private System.Windows.Forms.RadioButton rb_witnessmale;
        private System.Windows.Forms.ComboBox cb_witnessstatus;
        private System.Windows.Forms.ComboBox cb_witnessnationality;
        private System.Windows.Forms.ComboBox cb_witnessreligon;
        private System.Windows.Forms.Label lbl_occupation;
        private System.Windows.Forms.Label lbl_susaddress;
        private System.Windows.Forms.Label lbl_susbday;
        private System.Windows.Forms.Label lbl_susfname;
        private System.Windows.Forms.Label lbl_religon;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_suscontact;
        private System.Windows.Forms.Label lbl_susemail;
        private System.Windows.Forms.Label lbl_susstatus;
        private System.Windows.Forms.Label lbl_susgender;
        private System.Windows.Forms.Label lbl_suslname;
        private System.Windows.Forms.Label lbl_witnessnic;
        private System.Windows.Forms.Panel pnl_viewwitness;
        private System.Windows.Forms.GroupBox gb_viewwitness;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_viewwitnessnic;
        private System.Windows.Forms.Label lbl_witnessviewnic;
        private System.Windows.Forms.TableLayoutPanel table_witnessview;
    }
}