namespace logical_operator
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
            this.btnclears = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtrangedecision = new System.Windows.Forms.Label();
            this.rangedecision = new System.Windows.Forms.Label();
            this.namber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnclears
            // 
            this.btnclears.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclears.Location = new System.Drawing.Point(356, 324);
            this.btnclears.Name = "btnclears";
            this.btnclears.Size = new System.Drawing.Size(146, 56);
            this.btnclears.TabIndex = 27;
            this.btnclears.Text = "clear";
            this.btnclears.UseVisualStyleBackColor = true;
            this.btnclears.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(356, 392);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 56);
            this.btnexit.TabIndex = 28;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(153, 324);
            this.btncheck.Name = "btncheck";
            this.btncheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncheck.Size = new System.Drawing.Size(141, 142);
            this.btncheck.TabIndex = 26;
            this.btncheck.Text = "calculate check qualification\r\n\r\n";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtrangedecision
            // 
            this.txtrangedecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrangedecision.Location = new System.Drawing.Point(127, 237);
            this.txtrangedecision.Name = "txtrangedecision";
            this.txtrangedecision.Size = new System.Drawing.Size(424, 54);
            this.txtrangedecision.TabIndex = 29;
            // 
            // rangedecision
            // 
            this.rangedecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangedecision.Location = new System.Drawing.Point(159, 179);
            this.rangedecision.Name = "rangedecision";
            this.rangedecision.Size = new System.Drawing.Size(354, 39);
            this.rangedecision.TabIndex = 30;
            this.rangedecision.Text = "Range Decision";
            this.rangedecision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namber
            // 
            this.namber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namber.Location = new System.Drawing.Point(61, 75);
            this.namber.Name = "namber";
            this.namber.Size = new System.Drawing.Size(545, 39);
            this.namber.TabIndex = 30;
            this.namber.Text = "Enter an integer in  the range of 1 throught 10";
            this.namber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 39);
            this.label5.TabIndex = 30;
            this.label5.Text = "Range checker Application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(109, 129);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(474, 50);
            this.txtnumber.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 478);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namber);
            this.Controls.Add(this.rangedecision);
            this.Controls.Add(this.txtrangedecision);
            this.Controls.Add(this.btnclears);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclears;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label txtrangedecision;
        private System.Windows.Forms.Label rangedecision;
        private System.Windows.Forms.Label namber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumber;
    }
}

