namespace konekcija
{
    partial class frmCARDHOLDER
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRadnik = new System.Windows.Forms.Label();
            this.dgCHECKLIST = new System.Windows.Forms.DataGridView();
            this.direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWorktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWORKTIME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDO = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.btnPRINT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.CreateQuery);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(40, 53);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.CreateQuery);
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "Name";
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(77, 20);
            this.cboxCARDHOLDER.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(191, 21);
            this.cboxCARDHOLDER.TabIndex = 2;
            this.cboxCARDHOLDER.ValueMember = "Name";
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(10, 23);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(45, 13);
            this.lblRadnik.TabIndex = 3;
            this.lblRadnik.Text = "Worker:";
            // 
            // dgCHECKLIST
            // 
            this.dgCHECKLIST.AllowUserToAddRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgCHECKLIST.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCHECKLIST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCHECKLIST.AutoGenerateColumns = false;
            this.dgCHECKLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCHECKLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.direction,
            this.localTime,
            this.TotalWorktime});
            this.dgCHECKLIST.DataSource = this.accessLogBindingSource;
            this.dgCHECKLIST.Location = new System.Drawing.Point(29, 243);
            this.dgCHECKLIST.Margin = new System.Windows.Forms.Padding(2);
            this.dgCHECKLIST.Name = "dgCHECKLIST";
            this.dgCHECKLIST.ReadOnly = true;
            this.dgCHECKLIST.RowTemplate.Height = 24;
            this.dgCHECKLIST.Size = new System.Drawing.Size(415, 372);
            this.dgCHECKLIST.TabIndex = 4;
            this.dgCHECKLIST.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCHECKLIST_CellFormatting);
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
            this.localTime.DataPropertyName = "LocalTime";
            this.localTime.HeaderText = "LocalTime";
            this.localTime.Name = "localTime";
            this.localTime.ReadOnly = true;
            this.localTime.Width = 150;
            // 
            // TotalWorktime
            // 
            this.TotalWorktime.HeaderText = "Worktime";
            this.TotalWorktime.Name = "TotalWorktime";
            this.TotalWorktime.ReadOnly = true;
            // 
            // accessLogBindingSource
            // 
            this.accessLogBindingSource.DataSource = typeof(konekcija.AccessLog);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWORKTIME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxCARDHOLDER);
            this.groupBox1.Controls.Add(this.lblRadnik);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtWORKTIME
            // 
            this.txtWORKTIME.Location = new System.Drawing.Point(77, 53);
            this.txtWORKTIME.Name = "txtWORKTIME";
            this.txtWORKTIME.Size = new System.Drawing.Size(100, 20);
            this.txtWORKTIME.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDO);
            this.groupBox2.Controls.Add(this.lblOD);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(29, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(287, 87);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblDO
            // 
            this.lblDO.AutoSize = true;
            this.lblDO.Location = new System.Drawing.Point(15, 56);
            this.lblDO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(21, 13);
            this.lblDO.TabIndex = 3;
            this.lblDO.Text = "Do";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(15, 23);
            this.lblOD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(21, 13);
            this.lblOD.TabIndex = 2;
            this.lblOD.Text = "Od";
            // 
            // btnPRINT
            // 
            this.btnPRINT.Location = new System.Drawing.Point(349, 44);
            this.btnPRINT.Name = "btnPRINT";
            this.btnPRINT.Size = new System.Drawing.Size(95, 36);
            this.btnPRINT.TabIndex = 7;
            this.btnPRINT.Text = "Print";
            this.btnPRINT.UseVisualStyleBackColor = true;
            this.btnPRINT.Click += new System.EventHandler(this.btnPRINT_Click);
            // 
            // frmCARDHOLDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 626);
            this.Controls.Add(this.btnPRINT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCHECKLIST);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmCARDHOLDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardholder";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.DataGridView dgCHECKLIST;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDO;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.TextBox txtWORKTIME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accessLogBindingSource;
        private System.Windows.Forms.Button btnPRINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWorktime;
    }
}