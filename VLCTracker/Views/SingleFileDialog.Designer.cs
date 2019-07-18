namespace VLCTracker.Views
{
    partial class SingleFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleFileDialog));
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnSingleFile = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(12, 9);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(313, 23);
            this.lblFilename.TabIndex = 0;
            this.lblFilename.Text = "<Filename>";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSingleFile
            // 
            this.btnSingleFile.Location = new System.Drawing.Point(85, 35);
            this.btnSingleFile.Name = "btnSingleFile";
            this.btnSingleFile.Size = new System.Drawing.Size(167, 23);
            this.btnSingleFile.TabIndex = 1;
            this.btnSingleFile.Text = "Open as a single file";
            this.btnSingleFile.UseVisualStyleBackColor = true;
            this.btnSingleFile.Click += new System.EventHandler(this.btnSingleFile_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Location = new System.Drawing.Point(85, 64);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(167, 23);
            this.btnSeries.TabIndex = 2;
            this.btnSeries.Text = "Initialize directory as a series";
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // SingleFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 95);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnSingleFile);
            this.Controls.Add(this.lblFilename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleFileDialog";
            this.Text = "VLC Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnSingleFile;
        private System.Windows.Forms.Button btnSeries;
    }
}