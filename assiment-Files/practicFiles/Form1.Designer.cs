namespace practicFiles
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnReadLines = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnClearContents = new System.Windows.Forms.Button();
            this.lstFileContents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(27, 40);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateFile.Size = new System.Drawing.Size(381, 77);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "creating new files";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btncreatenewFile_Click);
            // 
            // btnReadLines
            // 
            this.btnReadLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadLines.Location = new System.Drawing.Point(27, 158);
            this.btnReadLines.Name = "btnReadLines";
            this.btnReadLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReadLines.Size = new System.Drawing.Size(381, 77);
            this.btnReadLines.TabIndex = 0;
            this.btnReadLines.Text = "Reade lines";
            this.btnReadLines.UseVisualStyleBackColor = true;
            this.btnReadLines.Click += new System.EventHandler(this.btnReadLines_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(27, 269);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteFile.Size = new System.Drawing.Size(381, 77);
            this.btnDeleteFile.TabIndex = 0;
            this.btnDeleteFile.Text = "delete files";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnClearContents
            // 
            this.btnClearContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearContents.Location = new System.Drawing.Point(27, 376);
            this.btnClearContents.Name = "btnClearContents";
            this.btnClearContents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClearContents.Size = new System.Drawing.Size(381, 77);
            this.btnClearContents.TabIndex = 0;
            this.btnClearContents.Text = "Clear files";
            this.btnClearContents.UseVisualStyleBackColor = true;
            this.btnClearContents.Click += new System.EventHandler(this.btnClearContents_Click);
            // 
            // lstFileContents
            // 
            this.lstFileContents.FormattingEnabled = true;
            this.lstFileContents.ItemHeight = 16;
            this.lstFileContents.Location = new System.Drawing.Point(469, 45);
            this.lstFileContents.Name = "lstFileContents";
            this.lstFileContents.Size = new System.Drawing.Size(310, 436);
            this.lstFileContents.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 655);
            this.Controls.Add(this.lstFileContents);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnClearContents);
            this.Controls.Add(this.btnReadLines);
            this.Controls.Add(this.btnCreateFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnReadLines;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnClearContents;
        private System.Windows.Forms.ListBox lstFileContents;
    }
}

