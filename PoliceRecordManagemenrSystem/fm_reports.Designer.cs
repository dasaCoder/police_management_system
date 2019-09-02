namespace PoliceRecordManagemenrSystem
{
    partial class fm_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_reports));
            this.dt_startdate = new System.Windows.Forms.DateTimePicker();
            this.dt_enddate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridReport = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.court_case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cRtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_startdate
            // 
            this.dt_startdate.Location = new System.Drawing.Point(343, 29);
            this.dt_startdate.Name = "dt_startdate";
            this.dt_startdate.Size = new System.Drawing.Size(185, 22);
            this.dt_startdate.TabIndex = 0;
            this.dt_startdate.ValueChanged += new System.EventHandler(this.Dt_startdate_ValueChanged);
            // 
            // dt_enddate
            // 
            this.dt_enddate.Location = new System.Drawing.Point(685, 41);
            this.dt_enddate.Name = "dt_enddate";
            this.dt_enddate.Size = new System.Drawing.Size(200, 22);
            this.dt_enddate.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(934, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cRtype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_startdate);
            this.groupBox1.Location = new System.Drawing.Point(60, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridReport);
            this.groupBox2.Location = new System.Drawing.Point(60, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // datagridReport
            // 
            this.datagridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.data,
            this.description,
            this.court_case});
            this.datagridReport.Location = new System.Drawing.Point(31, 40);
            this.datagridReport.Name = "datagridReport";
            this.datagridReport.Size = new System.Drawing.Size(889, 270);
            this.datagridReport.TabIndex = 0;
            this.datagridReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridReport_CellContentClick);
            // 
            // type
            // 
            this.type.HeaderText = "Entry Type";
            this.type.Name = "type";
            // 
            // data
            // 
            this.data.FillWeight = 200F;
            this.data.HeaderText = "Date";
            this.data.Name = "data";
            this.data.Width = 200;
            // 
            // description
            // 
            this.description.FillWeight = 300F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 300;
            // 
            // court_case
            // 
            this.court_case.HeaderText = "Court case (yes/no)";
            this.court_case.Name = "court_case";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Export Pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // cRtype
            // 
            this.cRtype.FormattingEnabled = true;
            this.cRtype.Items.AddRange(new object[] {
            "*",
            "Domestic Violence",
            "Criminal Act",
            "Minor Offence",
            "Drug Abuse",
            "Miscellanous",
            "Traffic Rules Violation",
            "Theft",
            "Child Abuse"});
            this.cRtype.Location = new System.Drawing.Point(83, 27);
            this.cRtype.Name = "cRtype";
            this.cRtype.Size = new System.Drawing.Size(167, 24);
            this.cRtype.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // fm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dt_enddate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.load_report);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_startdate;
        private System.Windows.Forms.DateTimePicker dt_enddate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagridReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn court_case;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cRtype;
    }
}