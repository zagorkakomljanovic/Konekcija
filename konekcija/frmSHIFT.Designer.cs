namespace konekcija
{
    partial class frmSHIFT
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
            this.cboxBREAKTIME = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWORKINGHOURS = new System.Windows.Forms.TextBox();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSAVECHANGE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.cboxSHIFTNAME = new System.Windows.Forms.ComboBox();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chkSUNDAY = new System.Windows.Forms.CheckBox();
            this.chkSATURDAY = new System.Windows.Forms.CheckBox();
            this.chkFRIDAY = new System.Windows.Forms.CheckBox();
            this.chkTHUERSDAY = new System.Windows.Forms.CheckBox();
            this.chkWEDNESDAY = new System.Windows.Forms.CheckBox();
            this.chkTUESDAY = new System.Windows.Forms.CheckBox();
            this.chkMODAY = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.btnADDW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSHIFTNAMEW = new System.Windows.Forms.ComboBox();
            this.workershiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workershiftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxBREAKTIME);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtWORKINGHOURS);
            this.groupBox1.Controls.Add(this.btnDELETE);
            this.groupBox1.Controls.Add(this.btnSAVECHANGE);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.cboxSHIFTNAME);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkSUNDAY);
            this.groupBox1.Controls.Add(this.chkSATURDAY);
            this.groupBox1.Controls.Add(this.chkFRIDAY);
            this.groupBox1.Controls.Add(this.chkTHUERSDAY);
            this.groupBox1.Controls.Add(this.chkWEDNESDAY);
            this.groupBox1.Controls.Add(this.chkTUESDAY);
            this.groupBox1.Controls.Add(this.chkMODAY);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift";
            // 
            // cboxBREAKTIME
            // 
            this.cboxBREAKTIME.FormattingEnabled = true;
            this.cboxBREAKTIME.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1"});
            this.cboxBREAKTIME.Location = new System.Drawing.Point(272, 97);
            this.cboxBREAKTIME.Name = "cboxBREAKTIME";
            this.cboxBREAKTIME.Size = new System.Drawing.Size(75, 21);
            this.cboxBREAKTIME.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Working hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Break time (h):";
            // 
            // txtWORKINGHOURS
            // 
            this.txtWORKINGHOURS.Location = new System.Drawing.Point(97, 98);
            this.txtWORKINGHOURS.Name = "txtWORKINGHOURS";
            this.txtWORKINGHOURS.Size = new System.Drawing.Size(51, 20);
            this.txtWORKINGHOURS.TabIndex = 13;
            this.txtWORKINGHOURS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(328, 140);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 12;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnSAVECHANGE
            // 
            this.btnSAVECHANGE.Location = new System.Drawing.Point(225, 140);
            this.btnSAVECHANGE.Name = "btnSAVECHANGE";
            this.btnSAVECHANGE.Size = new System.Drawing.Size(98, 23);
            this.btnSAVECHANGE.TabIndex = 11;
            this.btnSAVECHANGE.Text = "Save changes";
            this.btnSAVECHANGE.UseVisualStyleBackColor = true;
            this.btnSAVECHANGE.Click += new System.EventHandler(this.btnSAVECHANGE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(144, 140);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 10;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // cboxSHIFTNAME
            // 
            this.cboxSHIFTNAME.DataSource = this.shiftBindingSource;
            this.cboxSHIFTNAME.DisplayMember = "ShiftName";
            this.cboxSHIFTNAME.FormattingEnabled = true;
            this.cboxSHIFTNAME.Location = new System.Drawing.Point(97, 22);
            this.cboxSHIFTNAME.Name = "cboxSHIFTNAME";
            this.cboxSHIFTNAME.Size = new System.Drawing.Size(161, 21);
            this.cboxSHIFTNAME.TabIndex = 9;
            this.cboxSHIFTNAME.SelectedIndexChanged += new System.EventHandler(this.cboxSHIFTNAME_SelectedIndexChanged);
            this.cboxSHIFTNAME.TextChanged += new System.EventHandler(this.cboxSHIFTNAME_TextChanged);
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(konekcija.Shift);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shift name:";
            // 
            // chkSUNDAY
            // 
            this.chkSUNDAY.AutoSize = true;
            this.chkSUNDAY.Location = new System.Drawing.Point(475, 59);
            this.chkSUNDAY.Name = "chkSUNDAY";
            this.chkSUNDAY.Size = new System.Drawing.Size(62, 17);
            this.chkSUNDAY.TabIndex = 6;
            this.chkSUNDAY.Text = "Sunday";
            this.chkSUNDAY.UseVisualStyleBackColor = true;
            // 
            // chkSATURDAY
            // 
            this.chkSATURDAY.AutoSize = true;
            this.chkSATURDAY.Location = new System.Drawing.Point(401, 59);
            this.chkSATURDAY.Name = "chkSATURDAY";
            this.chkSATURDAY.Size = new System.Drawing.Size(68, 17);
            this.chkSATURDAY.TabIndex = 5;
            this.chkSATURDAY.Text = "Saturday";
            this.chkSATURDAY.UseVisualStyleBackColor = true;
            // 
            // chkFRIDAY
            // 
            this.chkFRIDAY.AutoSize = true;
            this.chkFRIDAY.Location = new System.Drawing.Point(341, 59);
            this.chkFRIDAY.Name = "chkFRIDAY";
            this.chkFRIDAY.Size = new System.Drawing.Size(54, 17);
            this.chkFRIDAY.TabIndex = 4;
            this.chkFRIDAY.Text = "Friday";
            this.chkFRIDAY.UseVisualStyleBackColor = true;
            // 
            // chkTHUERSDAY
            // 
            this.chkTHUERSDAY.AutoSize = true;
            this.chkTHUERSDAY.Location = new System.Drawing.Point(262, 59);
            this.chkTHUERSDAY.Name = "chkTHUERSDAY";
            this.chkTHUERSDAY.Size = new System.Drawing.Size(73, 17);
            this.chkTHUERSDAY.TabIndex = 3;
            this.chkTHUERSDAY.Text = "Thurstday";
            this.chkTHUERSDAY.UseVisualStyleBackColor = true;
            // 
            // chkWEDNESDAY
            // 
            this.chkWEDNESDAY.AutoSize = true;
            this.chkWEDNESDAY.Location = new System.Drawing.Point(173, 59);
            this.chkWEDNESDAY.Name = "chkWEDNESDAY";
            this.chkWEDNESDAY.Size = new System.Drawing.Size(83, 17);
            this.chkWEDNESDAY.TabIndex = 2;
            this.chkWEDNESDAY.Text = "Wednesday";
            this.chkWEDNESDAY.UseVisualStyleBackColor = true;
            // 
            // chkTUESDAY
            // 
            this.chkTUESDAY.AutoSize = true;
            this.chkTUESDAY.Location = new System.Drawing.Point(100, 59);
            this.chkTUESDAY.Name = "chkTUESDAY";
            this.chkTUESDAY.Size = new System.Drawing.Size(67, 17);
            this.chkTUESDAY.TabIndex = 1;
            this.chkTUESDAY.Text = "Tuesday";
            this.chkTUESDAY.UseVisualStyleBackColor = true;
            // 
            // chkMODAY
            // 
            this.chkMODAY.AutoSize = true;
            this.chkMODAY.Location = new System.Drawing.Point(30, 59);
            this.chkMODAY.Name = "chkMODAY";
            this.chkMODAY.Size = new System.Drawing.Size(64, 17);
            this.chkMODAY.TabIndex = 0;
            this.chkMODAY.Text = "Monday";
            this.chkMODAY.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnREMOVE);
            this.groupBox2.Controls.Add(this.btnADDW);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxSHIFTNAMEW);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboxCARDHOLDER);
            this.groupBox2.Location = new System.Drawing.Point(21, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Worker - Shift";
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.Location = new System.Drawing.Point(285, 84);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(75, 23);
            this.btnREMOVE.TabIndex = 5;
            this.btnREMOVE.Text = "Remove";
            this.btnREMOVE.UseVisualStyleBackColor = true;
            this.btnREMOVE.Click += new System.EventHandler(this.btnREMOVE_Click);
            // 
            // btnADDW
            // 
            this.btnADDW.Location = new System.Drawing.Point(191, 84);
            this.btnADDW.Name = "btnADDW";
            this.btnADDW.Size = new System.Drawing.Size(75, 23);
            this.btnADDW.TabIndex = 4;
            this.btnADDW.Text = "Add";
            this.btnADDW.UseVisualStyleBackColor = true;
            this.btnADDW.Click += new System.EventHandler(this.btnASSIGN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shift:";
            // 
            // cboxSHIFTNAMEW
            // 
            this.cboxSHIFTNAMEW.DataSource = this.workershiftBindingSource;
            this.cboxSHIFTNAMEW.DisplayMember = "ShiftName";
            this.cboxSHIFTNAMEW.FormattingEnabled = true;
            this.cboxSHIFTNAMEW.Location = new System.Drawing.Point(350, 41);
            this.cboxSHIFTNAMEW.Name = "cboxSHIFTNAMEW";
            this.cboxSHIFTNAMEW.Size = new System.Drawing.Size(154, 21);
            this.cboxSHIFTNAMEW.TabIndex = 2;
            this.cboxSHIFTNAMEW.SelectedIndexChanged += new System.EventHandler(this.cboxSHIFTNAMEW_SelectedIndexChanged);
            this.cboxSHIFTNAMEW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combo1_KeyPress);
            // 
            // workershiftBindingSource
            // 
            this.workershiftBindingSource.DataSource = typeof(konekcija.Shift);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worker:";
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "Name";
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(73, 41);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(185, 21);
            this.cboxCARDHOLDER.TabIndex = 0;
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            this.cboxCARDHOLDER.TextChanged += new System.EventHandler(this.cboxCARDHOLDER_TextChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // frmSHIFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSHIFT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.frmSHIFT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workershiftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSUNDAY;
        private System.Windows.Forms.CheckBox chkSATURDAY;
        private System.Windows.Forms.CheckBox chkFRIDAY;
        private System.Windows.Forms.CheckBox chkTHUERSDAY;
        private System.Windows.Forms.CheckBox chkWEDNESDAY;
        private System.Windows.Forms.CheckBox chkTUESDAY;
        private System.Windows.Forms.CheckBox chkMODAY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSHIFTNAMEW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxSHIFTNAME;
        private System.Windows.Forms.ComboBox cboxBREAKTIME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWORKINGHOURS;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnSAVECHANGE;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnADDW;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.BindingSource workershiftBindingSource;
    }
}