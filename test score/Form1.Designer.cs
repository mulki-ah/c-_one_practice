namespace Assiment_using_if_elseif
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaverage = new System.Windows.Forms.Label();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(164, 279);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncalculate.Size = new System.Drawing.Size(163, 134);
            this.btncalculate.TabIndex = 20;
            this.btncalculate.Text = "calcualte average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(348, 353);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(177, 60);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(348, 270);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(177, 60);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.lblaverage);
            this.groupBox1.Controls.Add(this.txtscore3);
            this.groupBox1.Controls.Add(this.txtscore2);
            this.groupBox1.Controls.Add(this.txtscore1);
            this.groupBox1.Controls.Add(this.average);
            this.groupBox1.Controls.Add(this.score3);
            this.groupBox1.Controls.Add(this.score2);
            this.groupBox1.Controls.Add(this.score1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 235);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter three Test Score";
            // 
            // lblaverage
            // 
            this.lblaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverage.Location = new System.Drawing.Point(243, 191);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(320, 38);
            this.lblaverage.TabIndex = 12;
            // 
            // txtscore3
            // 
            this.txtscore3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtscore3.Location = new System.Drawing.Point(243, 147);
            this.txtscore3.Multiline = true;
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(320, 37);
            this.txtscore3.TabIndex = 8;
            // 
            // txtscore2
            // 
            this.txtscore2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtscore2.Location = new System.Drawing.Point(243, 101);
            this.txtscore2.Multiline = true;
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(320, 37);
            this.txtscore2.TabIndex = 10;
            // 
            // txtscore1
            // 
            this.txtscore1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtscore1.Location = new System.Drawing.Point(243, 58);
            this.txtscore1.Multiline = true;
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(320, 37);
            this.txtscore1.TabIndex = 11;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average.Location = new System.Drawing.Point(154, 194);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(81, 23);
            this.average.TabIndex = 2;
            this.average.Text = "Average";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3.Location = new System.Drawing.Point(114, 152);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(121, 23);
            this.score3.TabIndex = 3;
            this.score3.Text = "Test score #3";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(114, 110);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(121, 23);
            this.score2.TabIndex = 5;
            this.score2.Text = "Test score #2";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(111, 67);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(124, 23);
            this.score1.TabIndex = 6;
            this.score1.Text = "Test Score #1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label lblaverage;
    }
}

