namespace konekcija
{
    partial class frmHOLIDAY
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFREEDAYS = new System.Windows.Forms.Button();
            this.btnACCEPT = new System.Windows.Forms.Button();
            this.cmbCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblCARDHOLDER = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtTOTALLEFT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTOTAL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFREEDAYS);
            this.groupBox1.Controls.Add(this.btnACCEPT);
            this.groupBox1.Controls.Add(this.cmbCARDHOLDER);
            this.groupBox1.Controls.Add(this.lblTOTAL);
            this.groupBox1.Controls.Add(this.lblCARDHOLDER);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtTOTALLEFT);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 289);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave request form";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(100, 185);
            this.txtTOTAL.MaxLength = 2;
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(51, 20);
            this.txtTOTAL.TabIndex = 11;
            this.txtTOTAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total:";
            // 
            // btnFREEDAYS
            // 
            this.btnFREEDAYS.Location = new System.Drawing.Point(323, 39);
            this.btnFREEDAYS.Name = "btnFREEDAYS";
            this.btnFREEDAYS.Size = new System.Drawing.Size(65, 23);
            this.btnFREEDAYS.TabIndex = 9;
            this.btnFREEDAYS.Text = "Free days";
            this.btnFREEDAYS.UseVisualStyleBackColor = true;
            this.btnFREEDAYS.Click += new System.EventHandler(this.btnFREEDAYS_Click);
            // 
            // btnACCEPT
            // 
            this.btnACCEPT.Location = new System.Drawing.Point(114, 234);
            this.btnACCEPT.Name = "btnACCEPT";
            this.btnACCEPT.Size = new System.Drawing.Size(123, 29);
            this.btnACCEPT.TabIndex = 8;
            this.btnACCEPT.Text = "Accept";
            this.btnACCEPT.UseVisualStyleBackColor = true;
            this.btnACCEPT.Click += new System.EventHandler(this.btnACCEPT_Click);
            // 
            // cmbCARDHOLDER
            // 
            this.cmbCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cmbCARDHOLDER.DisplayMember = "Name";
            this.cmbCARDHOLDER.FormattingEnabled = true;
            this.cmbCARDHOLDER.Location = new System.Drawing.Point(100, 41);
            this.cmbCARDHOLDER.Name = "cmbCARDHOLDER";
            this.cmbCARDHOLDER.Size = new System.Drawing.Size(200, 21);
            this.cmbCARDHOLDER.TabIndex = 1;
            this.cmbCARDHOLDER.ValueMember = "Name";
            this.cmbCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cmbCARDHOLDER_SelectedIndexChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Location = new System.Drawing.Point(252, 191);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(51, 13);
            this.lblTOTAL.TabIndex = 7;
            this.lblTOTAL.Text = "Total left:";
            // 
            // lblCARDHOLDER
            // 
            this.lblCARDHOLDER.AutoSize = true;
            this.lblCARDHOLDER.Location = new System.Drawing.Point(35, 44);
            this.lblCARDHOLDER.Name = "lblCARDHOLDER";
            this.lblCARDHOLDER.Size = new System.Drawing.Size(45, 13);
            this.lblCARDHOLDER.TabIndex = 0;
            this.lblCARDHOLDER.Text = "Worker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leave:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtTOTALLEFT
            // 
            this.txtTOTALLEFT.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTOTALLEFT.Location = new System.Drawing.Point(323, 188);
            this.txtTOTALLEFT.Name = "txtTOTALLEFT";
            this.txtTOTALLEFT.ReadOnly = true;
            this.txtTOTALLEFT.Size = new System.Drawing.Size(55, 20);
            this.txtTOTALLEFT.TabIndex = 4;
            // 
            // frmHOLIDAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 329);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmHOLIDAY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday";
            this.Load += new System.EventHandler(this.frmHOLIDAY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnACCEPT;
        private System.Windows.Forms.ComboBox cmbCARDHOLDER;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblCARDHOLDER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtTOTALLEFT;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.Button btnFREEDAYS;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label4;
    }
}