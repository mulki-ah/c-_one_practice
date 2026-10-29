namespace BMI_PROGRAM
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
            System.Windows.Forms.Label height;
            System.Windows.Forms.Label weight;
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.BMI = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.listOuput = new System.Windows.Forms.ListBox();
            this.btnexit = new System.Windows.Forms.Button();
            height = new System.Windows.Forms.Label();
            weight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // height
            // 
            height.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            height.Location = new System.Drawing.Point(59, 100);
            height.Name = "height";
            height.Size = new System.Drawing.Size(208, 32);
            height.TabIndex = 4;
            height.Text = "height meters :";
            height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weight
            // 
            weight.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weight.Location = new System.Drawing.Point(23, 38);
            weight.Name = "weight";
            weight.Size = new System.Drawing.Size(244, 39);
            weight.TabIndex = 5;
            weight.Text = "Weigth in kilogram(kg)         :";
            weight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtheight
            // 
            this.txtheight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtheight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtheight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheight.Location = new System.Drawing.Point(280, 93);
            this.txtheight.Multiline = true;
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(228, 39);
            this.txtheight.TabIndex = 8;
            // 
            // txtweight
            // 
            this.txtweight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(280, 38);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(228, 39);
            this.txtweight.TabIndex = 9;
            // 
            // BMI
            // 
            this.BMI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BMI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMI.Location = new System.Drawing.Point(202, 168);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(206, 57);
            this.BMI.TabIndex = 10;
            this.BMI.Text = "Calculate BMI";
            this.BMI.UseVisualStyleBackColor = false;
            this.BMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(64, 282);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(179, 54);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // listOuput
            // 
            this.listOuput.FormattingEnabled = true;
            this.listOuput.ItemHeight = 16;
            this.listOuput.Location = new System.Drawing.Point(520, 38);
            this.listOuput.Name = "listOuput";
            this.listOuput.Size = new System.Drawing.Size(227, 276);
            this.listOuput.TabIndex = 11;
            this.listOuput.SelectedIndexChanged += new System.EventHandler(this.listOuput_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(301, 282);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(179, 54);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.listOuput);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(height);
            this.Controls.Add(weight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Button BMI;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox listOuput;
        private System.Windows.Forms.Button btnexit;
    }
}

