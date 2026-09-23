namespace assiment1
{
    partial class form
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemsiter = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemister = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(93, 103);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(214, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the the student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(93, 148);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(193, 22);
            this.lblstudentid.TabIndex = 0;
            this.lblstudentid.Text = "Enter the the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(93, 191);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(200, 22);
            this.lbldepartment.TabIndex = 0;
            this.lbldepartment.Text = "Enter the the department";
            // 
            // lblsemsiter
            // 
            this.lblsemsiter.AutoSize = true;
            this.lblsemsiter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemsiter.Location = new System.Drawing.Point(93, 231);
            this.lblsemsiter.Name = "lblsemsiter";
            this.lblsemsiter.Size = new System.Drawing.Size(184, 22);
            this.lblsemsiter.TabIndex = 0;
            this.lblsemsiter.Text = "Enter the the  semister";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(310, 103);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(331, 29);
            this.txtname.TabIndex = 1;
            // 
            // txtstudentid
            // 
            this.txtstudentid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(310, 148);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(331, 29);
            this.txtstudentid.TabIndex = 1;
            // 
            // txtdepartment
            // 
            this.txtdepartment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(310, 191);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(331, 29);
            this.txtdepartment.TabIndex = 1;
            // 
            // txtsemister
            // 
            this.txtsemister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsemister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemister.Location = new System.Drawing.Point(310, 231);
            this.txtsemister.Multiline = true;
            this.txtsemister.Name = "txtsemister";
            this.txtsemister.Size = new System.Drawing.Size(331, 29);
            this.txtsemister.TabIndex = 1;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbloutput.Location = new System.Drawing.Point(76, 308);
            this.lbloutput.Multiline = true;
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(606, 60);
            this.lbloutput.TabIndex = 2;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(176, 404);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(163, 75);
            this.btnshowinfo.TabIndex = 3;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(375, 404);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(163, 75);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 501);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemister);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemsiter);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "form";
            this.Text = "studentform";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemsiter;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemister;
        private System.Windows.Forms.TextBox lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
    }
}

