namespace Hotel_Room_booking_calculator
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
            System.Windows.Forms.Label guestName;
            System.Windows.Forms.Label Room;
            System.Windows.Forms.Label numberOfnigts;
            System.Windows.Forms.Label price;
            System.Windows.Forms.Label label1;
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNight = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.serviceTax = new System.Windows.Forms.Label();
            this.DicouAmount = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guestName = new System.Windows.Forms.Label();
            Room = new System.Windows.Forms.Label();
            numberOfnigts = new System.Windows.Forms.Label();
            price = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.output.SuspendLayout();
            this.SuspendLayout();
            // 
            // guestName
            // 
            guestName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guestName.Location = new System.Drawing.Point(53, 132);
            guestName.Name = "guestName";
            guestName.Size = new System.Drawing.Size(281, 32);
            guestName.TabIndex = 0;
            guestName.Text = "Enter Guest Name            :";
            // 
            // Room
            // 
            Room.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Room.Location = new System.Drawing.Point(53, 168);
            Room.Name = "Room";
            Room.Size = new System.Drawing.Size(266, 32);
            Room.TabIndex = 0;
            Room.Text = "Enter Room type           :";
            // 
            // numberOfnigts
            // 
            numberOfnigts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfnigts.Location = new System.Drawing.Point(53, 210);
            numberOfnigts.Name = "numberOfnigts";
            numberOfnigts.Size = new System.Drawing.Size(281, 32);
            numberOfnigts.TabIndex = 0;
            numberOfnigts.Text = "Enter Number Of nights  :";
            // 
            // price
            // 
            price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price.Location = new System.Drawing.Point(53, 257);
            price.Name = "price";
            price.Size = new System.Drawing.Size(266, 32);
            price.TabIndex = 0;
            price.Text = "Enter price Per night     :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightSteelBlue;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(62, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(845, 70);
            label1.TabIndex = 3;
            label1.Text = "Hotel Room Booking Calculater";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(340, 128);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(535, 33);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRoomType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(340, 167);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(535, 33);
            this.txtRoomType.TabIndex = 1;
            // 
            // txtNight
            // 
            this.txtNight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNight.Location = new System.Drawing.Point(340, 206);
            this.txtNight.Multiline = true;
            this.txtNight.Name = "txtNight";
            this.txtNight.Size = new System.Drawing.Size(535, 33);
            this.txtNight.TabIndex = 1;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPriceNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceNight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceNight.Location = new System.Drawing.Point(340, 252);
            this.txtPriceNight.Multiline = true;
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(535, 33);
            this.txtPriceNight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(356, 317);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(233, 88);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Booking";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // serviceTax
            // 
            this.serviceTax.AutoSize = true;
            this.serviceTax.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTax.Location = new System.Drawing.Point(39, 32);
            this.serviceTax.Name = "serviceTax";
            this.serviceTax.Size = new System.Drawing.Size(222, 25);
            this.serviceTax.TabIndex = 0;
            this.serviceTax.Text = "Service Tax (10%)   :";
            // 
            // DicouAmount
            // 
            this.DicouAmount.AutoSize = true;
            this.DicouAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DicouAmount.Location = new System.Drawing.Point(6, 87);
            this.DicouAmount.Name = "DicouAmount";
            this.DicouAmount.Size = new System.Drawing.Size(255, 25);
            this.DicouAmount.TabIndex = 0;
            this.DicouAmount.Text = "Dicount Amount(5%)   :";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(99, 147);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(162, 25);
            this.totalAmount.TabIndex = 0;
            this.totalAmount.Text = "Total Amount :";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.output.Controls.Add(this.lblTotalAmount);
            this.output.Controls.Add(this.lblDiscount);
            this.output.Controls.Add(this.lblServiceTax);
            this.output.Controls.Add(this.serviceTax);
            this.output.Controls.Add(this.DicouAmount);
            this.output.Controls.Add(this.totalAmount);
            this.output.Location = new System.Drawing.Point(58, 428);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(817, 201);
            this.output.TabIndex = 4;
            this.output.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Location = new System.Drawing.Point(279, 147);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(446, 33);
            this.lblTotalAmount.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(279, 79);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(446, 33);
            this.lblDiscount.TabIndex = 2;
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblServiceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceTax.Location = new System.Drawing.Point(279, 23);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(446, 33);
            this.lblServiceTax.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(995, 708);
            this.Controls.Add(this.output);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNight);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(price);
            this.Controls.Add(numberOfnigts);
            this.Controls.Add(Room);
            this.Controls.Add(guestName);
            this.Name = "Form1";
            this.Text = "hotel";
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNight;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label serviceTax;
        private System.Windows.Forms.Label DicouAmount;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblServiceTax;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

