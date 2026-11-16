namespace Employee_attendence_management_system
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnrecord = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalrecord = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdpresent = new System.Windows.Forms.RadioButton();
            this.rdabsent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(480, 42);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 212);
            this.listBox1.TabIndex = 10;
            // 
            // btnrecord
            // 
            this.btnrecord.Location = new System.Drawing.Point(67, 383);
            this.btnrecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(128, 38);
            this.btnrecord.TabIndex = 11;
            this.btnrecord.Text = "Record";
            this.btnrecord.UseVisualStyleBackColor = true;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(214, 383);
            this.btnview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(128, 38);
            this.btnview.TabIndex = 12;
            this.btnview.Text = "view file";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(621, 377);
            this.btncount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(128, 38);
            this.btncount.TabIndex = 14;
            this.btncount.Text = "count record";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(368, 383);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(128, 38);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(621, 433);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 38);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(772, 377);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 38);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Records:";
            // 
            // lbltotalrecord
            // 
            this.lbltotalrecord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotalrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecord.ForeColor = System.Drawing.Color.White;
            this.lbltotalrecord.Location = new System.Drawing.Point(632, 276);
            this.lbltotalrecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalrecord.Name = "lbltotalrecord";
            this.lbltotalrecord.Size = new System.Drawing.Size(245, 25);
            this.lbltotalrecord.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(212, 43);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 30);
            this.txtid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(212, 96);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(193, 30);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department:";
            // 
            // txtdepartment
            // 
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(212, 150);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(193, 30);
            this.txtdepartment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attendence:";
            // 
            // rdpresent
            // 
            this.rdpresent.AutoSize = true;
            this.rdpresent.Location = new System.Drawing.Point(212, 209);
            this.rdpresent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdpresent.Name = "rdpresent";
            this.rdpresent.Size = new System.Drawing.Size(74, 20);
            this.rdpresent.TabIndex = 7;
            this.rdpresent.TabStop = true;
            this.rdpresent.Text = "Present";
            this.rdpresent.UseVisualStyleBackColor = true;
            // 
            // rdabsent
            // 
            this.rdabsent.AutoSize = true;
            this.rdabsent.Location = new System.Drawing.Point(328, 209);
            this.rdabsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdabsent.Name = "rdabsent";
            this.rdabsent.Size = new System.Drawing.Size(70, 20);
            this.rdabsent.TabIndex = 8;
            this.rdabsent.TabStop = true;
            this.rdabsent.Text = "Absent";
            this.rdabsent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdabsent);
            this.groupBox1.Controls.Add(this.rdpresent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(436, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendence Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 510);
            this.Controls.Add(this.lbltotalrecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalrecord;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdpresent;
        private System.Windows.Forms.RadioButton rdabsent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

