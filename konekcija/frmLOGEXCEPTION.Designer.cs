﻿namespace konekcija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIN_OUT = new System.Windows.Forms.CheckBox();
            this.chkWORKTIME = new System.Windows.Forms.CheckBox();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRadnik = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDO = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgLOGEXCEPTION = new System.Windows.Forms.DataGridView();
            this.logExceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnWorkerpresence = new System.Windows.Forms.Button();
            this.dgLogDetails = new System.Windows.Forms.DataGridView();
            this.direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gvCARDHOLDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcIN_OUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogExceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worktimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLOGEXCEPTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logExceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).BeginInit();
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
            this.chkIN_OUT.CheckedChanged += new System.EventHandler(this.chkIN_OUT_CheckedChanged);
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
            this.chkWORKTIME.CheckedChanged += new System.EventHandler(this.chkWORKTIME_CheckedChanged);
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
            dataGridViewCellStyle3.NullValue = null;
            this.dgLOGEXCEPTION.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLOGEXCEPTION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLOGEXCEPTION.AutoGenerateColumns = false;
            this.dgLOGEXCEPTION.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLOGEXCEPTION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLOGEXCEPTION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvCARDHOLDER,
            this.ExcIN_OUT,
            this.LogExceptionDate,
            this.worktimeDataGridViewTextBoxColumn});
            this.dgLOGEXCEPTION.DataSource = this.logExceptionBindingSource;
            this.dgLOGEXCEPTION.Location = new System.Drawing.Point(30, 199);
            this.dgLOGEXCEPTION.Margin = new System.Windows.Forms.Padding(2);
            this.dgLOGEXCEPTION.Name = "dgLOGEXCEPTION";
            this.dgLOGEXCEPTION.ReadOnly = true;
            this.dgLOGEXCEPTION.RowTemplate.Height = 24;
            this.dgLOGEXCEPTION.Size = new System.Drawing.Size(500, 300);
            this.dgLOGEXCEPTION.TabIndex = 8;
            this.dgLOGEXCEPTION.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLOGEXCEPTION_CellClick);
            this.dgLOGEXCEPTION.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLOGEXCEPTION_CellFormatting);
            this.dgLOGEXCEPTION.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLOGEXCEPTION_DataBindingComplete);
            // 
            // logExceptionBindingSource
            // 
            this.logExceptionBindingSource.DataSource = typeof(konekcija.LogException);
            // 
            // btnWorkerpresence
            // 
            this.btnWorkerpresence.Location = new System.Drawing.Point(322, 36);
            this.btnWorkerpresence.Name = "btnWorkerpresence";
            this.btnWorkerpresence.Size = new System.Drawing.Size(143, 23);
            this.btnWorkerpresence.TabIndex = 9;
            this.btnWorkerpresence.Text = "Worker presence";
            this.btnWorkerpresence.UseVisualStyleBackColor = true;
            this.btnWorkerpresence.Click += new System.EventHandler(this.btnWorkerpresence_Click);
            // 
            // dgLogDetails
            // 
            this.dgLogDetails.AllowUserToAddRows = false;
            this.dgLogDetails.AllowUserToDeleteRows = false;
            this.dgLogDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLogDetails.AutoGenerateColumns = false;
            this.dgLogDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLogDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.direction,
            this.localTime});
            this.dgLogDetails.DataSource = this.accessLogBindingSource;
            this.dgLogDetails.Location = new System.Drawing.Point(615, 199);
            this.dgLogDetails.Name = "dgLogDetails";
            this.dgLogDetails.ReadOnly = true;
            this.dgLogDetails.Size = new System.Drawing.Size(304, 209);
            this.dgLogDetails.TabIndex = 10;
            this.dgLogDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogDetails_CellContentClick);
            this.dgLogDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLogDetails_CellFormatting);
            // 
            // direction
            // 
            this.direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direction.DataPropertyName = "Direction";
            this.direction.HeaderText = "Direction";
            this.direction.Name = "direction";
            this.direction.ReadOnly = true;
            // 
            // localTime
            // 
            this.localTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.localTime.DataPropertyName = "LocalTime";
            this.localTime.HeaderText = "LocalTime";
            this.localTime.Name = "localTime";
            this.localTime.ReadOnly = true;
            // 
            // accessLogBindingSource
            // 
            this.accessLogBindingSource.DataSource = typeof(konekcija.AccessLog);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Check IN-OUT Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvCARDHOLDER
            // 
            this.gvCARDHOLDER.HeaderText = "Cardholder";
            this.gvCARDHOLDER.Name = "gvCARDHOLDER";
            this.gvCARDHOLDER.ReadOnly = true;
            // 
            // ExcIN_OUT
            // 
            this.ExcIN_OUT.DataPropertyName = "ExcIN_OUT";
            this.ExcIN_OUT.HeaderText = "ExcIN_OUT";
            this.ExcIN_OUT.Name = "ExcIN_OUT";
            this.ExcIN_OUT.ReadOnly = true;
            this.ExcIN_OUT.Visible = false;
            // 
            // LogExceptionDate
            // 
            this.LogExceptionDate.DataPropertyName = "LogExceptionDate";
            this.LogExceptionDate.HeaderText = "LogExceptionDate";
            this.LogExceptionDate.Name = "LogExceptionDate";
            this.LogExceptionDate.ReadOnly = true;
            // 
            // worktimeDataGridViewTextBoxColumn
            // 
            this.worktimeDataGridViewTextBoxColumn.DataPropertyName = "Worktime";
            this.worktimeDataGridViewTextBoxColumn.HeaderText = "Worktime";
            this.worktimeDataGridViewTextBoxColumn.Name = "worktimeDataGridViewTextBoxColumn";
            this.worktimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmLOGEXCEPTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLogDetails);
            this.Controls.Add(this.btnWorkerpresence);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLOGEXCEPTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logExceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.DataGridView dgLOGEXCEPTION;
        private System.Windows.Forms.CheckBox chkIN_OUT;
        private System.Windows.Forms.CheckBox chkWORKTIME;
        private System.Windows.Forms.BindingSource logExceptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnWorkerpresence;
        private System.Windows.Forms.DataGridView dgLogDetails;
        private System.Windows.Forms.BindingSource accessLogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCARDHOLDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcIN_OUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogExceptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktimeDataGridViewTextBoxColumn;
    }
}