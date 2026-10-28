namespace check_validation
{
    partial class Form1
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
            this.txthourlypayrate = new System.Windows.Forms.TextBox();
            this.txtHoursworked = new System.Windows.Forms.TextBox();
            this.grosspay = new System.Windows.Forms.Label();
            this.HourlypayRate = new System.Windows.Forms.Label();
            this.hoursworked = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblcrosspay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthourlypayrate
            // 
            this.txthourlypayrate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txthourlypayrate.Location = new System.Drawing.Point(200, 118);
            this.txthourlypayrate.Multiline = true;
            this.txthourlypayrate.Name = "txthourlypayrate";
            this.txthourlypayrate.Size = new System.Drawing.Size(320, 37);
            this.txthourlypayrate.TabIndex = 15;
            // 
            // txtHoursworked
            // 
            this.txtHoursworked.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHoursworked.Location = new System.Drawing.Point(200, 75);
            this.txtHoursworked.Multiline = true;
            this.txtHoursworked.Name = "txtHoursworked";
            this.txtHoursworked.Size = new System.Drawing.Size(320, 37);
            this.txtHoursworked.TabIndex = 16;
            // 
            // grosspay
            // 
            this.grosspay.AutoSize = true;
            this.grosspay.Enabled = false;
            this.grosspay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosspay.Location = new System.Drawing.Point(88, 172);
            this.grosspay.Name = "grosspay";
            this.grosspay.Size = new System.Drawing.Size(106, 25);
            this.grosspay.TabIndex = 11;
            this.grosspay.Text = "gross pay";
            // 
            // HourlypayRate
            // 
            this.HourlypayRate.AutoSize = true;
            this.HourlypayRate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourlypayRate.Location = new System.Drawing.Point(24, 130);
            this.HourlypayRate.Name = "HourlypayRate";
            this.HourlypayRate.Size = new System.Drawing.Size(170, 25);
            this.HourlypayRate.TabIndex = 12;
            this.HourlypayRate.Text = "Hourly pay rate";
            // 
            // hoursworked
            // 
            this.hoursworked.AutoSize = true;
            this.hoursworked.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursworked.Location = new System.Drawing.Point(35, 86);
            this.hoursworked.Name = "hoursworked";
            this.hoursworked.Size = new System.Drawing.Size(159, 25);
            this.hoursworked.TabIndex = 13;
            this.hoursworked.Text = "Hours Worked";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(413, 268);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 95);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(240, 268);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 95);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(75, 257);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncalculate.Size = new System.Drawing.Size(141, 95);
            this.btncalculate.TabIndex = 23;
            this.btncalculate.Text = "Calculate Gross pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblcrosspay
            // 
            this.lblcrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcrosspay.Location = new System.Drawing.Point(200, 172);
            this.lblcrosspay.Name = "lblcrosspay";
            this.lblcrosspay.Size = new System.Drawing.Size(320, 38);
            this.lblcrosspay.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.lblcrosspay);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txthourlypayrate);
            this.Controls.Add(this.txtHoursworked);
            this.Controls.Add(this.grosspay);
            this.Controls.Add(this.HourlypayRate);
            this.Controls.Add(this.hoursworked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txthourlypayrate;
        private System.Windows.Forms.TextBox txtHoursworked;
        private System.Windows.Forms.Label grosspay;
        private System.Windows.Forms.Label HourlypayRate;
        private System.Windows.Forms.Label hoursworked;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblcrosspay;
    }
}

