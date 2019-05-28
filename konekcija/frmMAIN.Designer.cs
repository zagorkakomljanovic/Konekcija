namespace konekcija
{
    partial class frmMAIN
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimeReport = new System.Windows.Forms.Button();
            this.btnLEAVEREQUEST = new System.Windows.Forms.Button();
            this.btnSHIFT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(117, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Worker presence";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTimeReport
            // 
            this.btnTimeReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeReport.Location = new System.Drawing.Point(117, 169);
            this.btnTimeReport.Name = "btnTimeReport";
            this.btnTimeReport.Size = new System.Drawing.Size(103, 41);
            this.btnTimeReport.TabIndex = 4;
            this.btnTimeReport.Text = "Exceptions";
            this.btnTimeReport.UseVisualStyleBackColor = false;
            this.btnTimeReport.Click += new System.EventHandler(this.btnTimeReport_Click);
            // 
            // btnLEAVEREQUEST
            // 
            this.btnLEAVEREQUEST.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLEAVEREQUEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLEAVEREQUEST.Location = new System.Drawing.Point(254, 91);
            this.btnLEAVEREQUEST.Name = "btnLEAVEREQUEST";
            this.btnLEAVEREQUEST.Size = new System.Drawing.Size(108, 41);
            this.btnLEAVEREQUEST.TabIndex = 5;
            this.btnLEAVEREQUEST.Text = "Leave request";
            this.btnLEAVEREQUEST.UseVisualStyleBackColor = false;
            this.btnLEAVEREQUEST.Click += new System.EventHandler(this.btnLEAVEREQUEST_Click);
            // 
            // btnSHIFT
            // 
            this.btnSHIFT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHIFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHIFT.Location = new System.Drawing.Point(254, 169);
            this.btnSHIFT.Name = "btnSHIFT";
            this.btnSHIFT.Size = new System.Drawing.Size(108, 41);
            this.btnSHIFT.TabIndex = 6;
            this.btnSHIFT.Text = "Shift";
            this.btnSHIFT.UseVisualStyleBackColor = false;
            this.btnSHIFT.Click += new System.EventHandler(this.btnSHIFT_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(470, 320);
            this.Controls.Add(this.btnSHIFT);
            this.Controls.Add(this.btnLEAVEREQUEST);
            this.Controls.Add(this.btnTimeReport);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimeReport;
        private System.Windows.Forms.Button btnLEAVEREQUEST;
        private System.Windows.Forms.Button btnSHIFT;
    }
}

