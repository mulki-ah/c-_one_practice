namespace Assigmnt_2_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.btnaddcurse = new System.Windows.Forms.Button();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.listboxcourse = new System.Windows.Forms.ListBox();
            this.listboxdisblay = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblnumberofcourse = new System.Windows.Forms.Label();
            this.txtnumofcourse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(426, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "student INFO";
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(11, 104);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(180, 18);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Student Id:";
            // 
            // lblage
            // 
            this.lblage.Location = new System.Drawing.Point(11, 64);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(180, 18);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "Student Age:";
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(11, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(180, 18);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Student Name:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(206, 102);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(215, 27);
            this.txtid.TabIndex = 2;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(206, 64);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(215, 27);
            this.txtage.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(206, 30);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(215, 27);
            this.txtname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.btnremove);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtcourse);
            this.groupBox2.Controls.Add(this.btnaddcurse);
            this.groupBox2.Controls.Add(this.lblcourse);
            this.groupBox2.Controls.Add(this.lblprice);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(429, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information:";
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Linen;
            this.btnremove.Location = new System.Drawing.Point(259, 120);
            this.btnremove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(140, 49);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "Remove Courses";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(189, 69);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(197, 27);
            this.txtprice.TabIndex = 10;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(189, 34);
            this.txtcourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(197, 27);
            this.txtcourse.TabIndex = 9;
            // 
            // btnaddcurse
            // 
            this.btnaddcurse.BackColor = System.Drawing.Color.Linen;
            this.btnaddcurse.Location = new System.Drawing.Point(36, 124);
            this.btnaddcurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddcurse.Name = "btnaddcurse";
            this.btnaddcurse.Size = new System.Drawing.Size(139, 45);
            this.btnaddcurse.TabIndex = 11;
            this.btnaddcurse.Text = "add\r\n";
            this.btnaddcurse.UseVisualStyleBackColor = false;
            this.btnaddcurse.Click += new System.EventHandler(this.btnaddcurse_Click);
            // 
            // lblcourse
            // 
            this.lblcourse.Location = new System.Drawing.Point(20, 34);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(137, 18);
            this.lblcourse.TabIndex = 7;
            this.lblcourse.Text = "Corse Name:";
            // 
            // lblprice
            // 
            this.lblprice.Location = new System.Drawing.Point(20, 71);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(137, 18);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Course Price $:";
            // 
            // listboxcourse
            // 
            this.listboxcourse.BackColor = System.Drawing.Color.Aqua;
            this.listboxcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxcourse.FormattingEnabled = true;
            this.listboxcourse.ItemHeight = 16;
            this.listboxcourse.Location = new System.Drawing.Point(30, 471);
            this.listboxcourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxcourse.Name = "listboxcourse";
            this.listboxcourse.Size = new System.Drawing.Size(429, 82);
            this.listboxcourse.TabIndex = 0;
            // 
            // listboxdisblay
            // 
            this.listboxdisblay.BackColor = System.Drawing.Color.Aqua;
            this.listboxdisblay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxdisblay.FormattingEnabled = true;
            this.listboxdisblay.ItemHeight = 19;
            this.listboxdisblay.Location = new System.Drawing.Point(476, 32);
            this.listboxdisblay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxdisblay.Name = "listboxdisblay";
            this.listboxdisblay.Size = new System.Drawing.Size(315, 422);
            this.listboxdisblay.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Linen;
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(476, 484);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(109, 58);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Linen;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(607, 484);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 58);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Linen;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(737, 484);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 58);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblnumberofcourse
            // 
            this.lblnumberofcourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofcourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnumberofcourse.Location = new System.Drawing.Point(26, 578);
            this.lblnumberofcourse.Name = "lblnumberofcourse";
            this.lblnumberofcourse.Size = new System.Drawing.Size(443, 29);
            this.lblnumberofcourse.TabIndex = 6;
            this.lblnumberofcourse.Text = "Number Of Registing Courses:";
            // 
            // txtnumofcourse
            // 
            this.txtnumofcourse.BackColor = System.Drawing.Color.Aqua;
            this.txtnumofcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumofcourse.Location = new System.Drawing.Point(30, 619);
            this.txtnumofcourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnumofcourse.Multiline = true;
            this.txtnumofcourse.Name = "txtnumofcourse";
            this.txtnumofcourse.Size = new System.Drawing.Size(429, 50);
            this.txtnumofcourse.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 735);
            this.Controls.Add(this.txtnumofcourse);
            this.Controls.Add(this.lblnumberofcourse);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listboxdisblay);
            this.Controls.Add(this.listboxcourse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxcourse;
        private System.Windows.Forms.ListBox listboxdisblay;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnaddcurse;
        private System.Windows.Forms.Label lblnumberofcourse;
        private System.Windows.Forms.TextBox txtnumofcourse;
    }
}

