namespace konekcija
{
    partial class frmNONWORKINGDAYS
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker:";
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "NAME";
            this.cboxCARDHOLDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(91, 48);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(160, 21);
            this.cboxCARDHOLDER.TabIndex = 1;
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(91, 88);
            this.txtTOTAL.MaxLength = 2;
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(76, 20);
            this.txtTOTAL.TabIndex = 3;
            this.txtTOTAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTOTAL_KeyPress);
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(117, 124);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 4;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCARDHOLDER);
            this.groupBox1.Controls.Add(this.btnSAVE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTOTAL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of days";
            // 
            // frmNONWORKINGDAYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(356, 236);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmNONWORKINGDAYS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Non-working days";
            this.Load += new System.EventHandler(this.frmNONWORKINGDAYS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}