namespace konekcija
{
    partial class frmLOGEXCEPTION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIN_OUT = new System.Windows.Forms.CheckBox();
            this.chkWORKTIME = new System.Windows.Forms.CheckBox();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRadnik = new System.Windows.Forms.Label();
            this.accessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDO = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgLOGEXCEPTION = new System.Windows.Forms.DataGridView();
            this.gvCARDHOLDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worktimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logExceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLOGEXCEPTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logExceptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIN_OUT);
            this.groupBox1.Controls.Add(this.chkWORKTIME);
            this.groupBox1.Location = new System.Drawing.Point(30, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(180, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exceptions";
            // 
            // chkIN_OUT
            // 
            this.chkIN_OUT.AutoSize = true;
            this.chkIN_OUT.Location = new System.Drawing.Point(28, 57);
            this.chkIN_OUT.Name = "chkIN_OUT";
            this.chkIN_OUT.Size = new System.Drawing.Size(124, 17);
            this.chkIN_OUT.TabIndex = 1;
            this.chkIN_OUT.Text = "Check IN_OUT error";
            this.chkIN_OUT.UseVisualStyleBackColor = true;
            // 
            // chkWORKTIME
            // 
            this.chkWORKTIME.AutoSize = true;
            this.chkWORKTIME.Location = new System.Drawing.Point(28, 25);
            this.chkWORKTIME.Name = "chkWORKTIME";
            this.chkWORKTIME.Size = new System.Drawing.Size(98, 17);
            this.chkWORKTIME.TabIndex = 0;
            this.chkWORKTIME.Text = "Work time error";
            this.chkWORKTIME.UseVisualStyleBackColor = true;
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "Name";
            this.cboxCARDHOLDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(88, 36);
            this.cboxCARDHOLDER.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(185, 21);
            this.cboxCARDHOLDER.TabIndex = 2;
            this.cboxCARDHOLDER.ValueMember = "Name";
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(41, 39);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(45, 13);
            this.lblRadnik.TabIndex = 3;
            this.lblRadnik.Text = "Worker:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDO);
            this.groupBox2.Controls.Add(this.lblOD);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(228, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // lblDO
            // 
            this.lblDO.AutoSize = true;
            this.lblDO.Location = new System.Drawing.Point(25, 58);
            this.lblDO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(20, 13);
            this.lblDO.TabIndex = 3;
            this.lblDO.Text = "To";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(15, 23);
            this.lblOD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(30, 13);
            this.lblOD.TabIndex = 2;
            this.lblOD.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(64, 53);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.CreateQuery);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.CreateQuery);
            // 
            // dgLOGEXCEPTION
            // 
            this.dgLOGEXCEPTION.AllowUserToAddRows = false;
            this.dgLOGEXCEPTION.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgLOGEXCEPTION.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLOGEXCEPTION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLOGEXCEPTION.AutoGenerateColumns = false;
            this.dgLOGEXCEPTION.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLOGEXCEPTION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLOGEXCEPTION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvCARDHOLDER,
            this.dateDataGridViewTextBoxColumn,
            this.worktimeDataGridViewTextBoxColumn});
            this.dgLOGEXCEPTION.DataSource = this.logExceptionBindingSource;
            this.dgLOGEXCEPTION.Location = new System.Drawing.Point(30, 199);
            this.dgLOGEXCEPTION.Margin = new System.Windows.Forms.Padding(2);
            this.dgLOGEXCEPTION.Name = "dgLOGEXCEPTION";
            this.dgLOGEXCEPTION.ReadOnly = true;
            this.dgLOGEXCEPTION.RowTemplate.Height = 24;
            this.dgLOGEXCEPTION.Size = new System.Drawing.Size(435, 209);
            this.dgLOGEXCEPTION.TabIndex = 8;
            this.dgLOGEXCEPTION.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLOGEXCEPTION_DataBindingComplete);
            // 
            // gvCARDHOLDER
            // 
            this.gvCARDHOLDER.HeaderText = "Cardholder";
            this.gvCARDHOLDER.Name = "gvCARDHOLDER";
            this.gvCARDHOLDER.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worktimeDataGridViewTextBoxColumn
            // 
            this.worktimeDataGridViewTextBoxColumn.DataPropertyName = "Worktime";
            this.worktimeDataGridViewTextBoxColumn.HeaderText = "Worktime";
            this.worktimeDataGridViewTextBoxColumn.Name = "worktimeDataGridViewTextBoxColumn";
            this.worktimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logExceptionBindingSource
            // 
            this.logExceptionBindingSource.DataSource = typeof(konekcija.LogException);
            // 
            // frmLOGEXCEPTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgLOGEXCEPTION);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboxCARDHOLDER);
            this.Controls.Add(this.lblRadnik);
            this.Name = "frmLOGEXCEPTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception";
            this.Load += new System.EventHandler(this.frmEXCEPTION_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLOGEXCEPTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logExceptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDO;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource accessLogBindingSource;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.DataGridView dgLOGEXCEPTION;
        private System.Windows.Forms.CheckBox chkIN_OUT;
        private System.Windows.Forms.CheckBox chkWORKTIME;
        private System.Windows.Forms.BindingSource logExceptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCARDHOLDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktimeDataGridViewTextBoxColumn;
    }
}