namespace tip_tax_total_assiment
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtfood1price = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtfood2price = new System.Windows.Forms.TextBox();
            this.btncalcualte = new System.Windows.Forms.Button();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.food1pricelbl = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.food2pricelbl = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.salestxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfood1.Location = new System.Drawing.Point(248, 51);
            this.txtfood1.Multiline = true;
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(318, 41);
            this.txtfood1.TabIndex = 0;
            // 
            // txtfood1price
            // 
            this.txtfood1price.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfood1price.Location = new System.Drawing.Point(248, 130);
            this.txtfood1price.Multiline = true;
            this.txtfood1price.Name = "txtfood1price";
            this.txtfood1price.Size = new System.Drawing.Size(318, 41);
            this.txtfood1price.TabIndex = 0;
            this.txtfood1price.TextChanged += new System.EventHandler(this.txtfood1price_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfood2.Location = new System.Drawing.Point(248, 203);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(318, 41);
            this.txtfood2.TabIndex = 0;
            // 
            // txtfood2price
            // 
            this.txtfood2price.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfood2price.Location = new System.Drawing.Point(248, 282);
            this.txtfood2price.Multiline = true;
            this.txtfood2price.Name = "txtfood2price";
            this.txtfood2price.Size = new System.Drawing.Size(318, 41);
            this.txtfood2price.TabIndex = 0;
            // 
            // btncalcualte
            // 
            this.btncalcualte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncalcualte.Location = new System.Drawing.Point(300, 344);
            this.btncalcualte.Name = "btncalcualte";
            this.btncalcualte.Size = new System.Drawing.Size(174, 74);
            this.btncalcualte.TabIndex = 1;
            this.btncalcualte.Text = "Calcualte";
            this.btncalcualte.UseVisualStyleBackColor = true;
            this.btncalcualte.Click += new System.EventHandler(this.btncalcualte_Click);
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfood1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(3, 57);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(220, 35);
            this.lblfood1.TabIndex = 2;
            this.lblfood1.Text = "Enter Name food1";
            // 
            // food1pricelbl
            // 
            this.food1pricelbl.AutoSize = true;
            this.food1pricelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.food1pricelbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food1pricelbl.Location = new System.Drawing.Point(12, 136);
            this.food1pricelbl.Name = "food1pricelbl";
            this.food1pricelbl.Size = new System.Drawing.Size(211, 35);
            this.food1pricelbl.TabIndex = 2;
            this.food1pricelbl.Text = "Enter food1 price";
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfood2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood2.Location = new System.Drawing.Point(-4, 209);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(227, 35);
            this.lblfood2.TabIndex = 2;
            this.lblfood2.Text = "Enter  Name food2";
            // 
            // food2pricelbl
            // 
            this.food2pricelbl.AutoSize = true;
            this.food2pricelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.food2pricelbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food2pricelbl.Location = new System.Drawing.Point(12, 288);
            this.food2pricelbl.Name = "food2pricelbl";
            this.food2pricelbl.Size = new System.Drawing.Size(211, 35);
            this.food2pricelbl.TabIndex = 2;
            this.food2pricelbl.Text = "Enter food2 price";
            // 
            // sales
            // 
            this.sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sales.Location = new System.Drawing.Point(60, 470);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(182, 50);
            this.sales.TabIndex = 3;
            this.sales.Text = "sales text :";
            this.sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.amount.Location = new System.Drawing.Point(36, 553);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(206, 50);
            this.amount.TabIndex = 3;
            this.amount.Text = " total amount:";
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salestxt
            // 
            this.salestxt.Location = new System.Drawing.Point(248, 466);
            this.salestxt.Multiline = true;
            this.salestxt.Name = "salestxt";
            this.salestxt.Size = new System.Drawing.Size(336, 54);
            this.salestxt.TabIndex = 4;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(248, 545);
            this.amounttxt.Multiline = true;
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(360, 58);
            this.amounttxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 707);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.salestxt);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.food2pricelbl);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.food1pricelbl);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.btncalcualte);
            this.Controls.Add(this.txtfood2price);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfood1price);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtfood1price;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtfood2price;
        private System.Windows.Forms.Button btncalcualte;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label food1pricelbl;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label food2pricelbl;
        private System.Windows.Forms.Label sales;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox salestxt;
        private System.Windows.Forms.TextBox amounttxt;
    }
}

