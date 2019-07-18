namespace VLCTracker.Views
{
    partial class SeriesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesView));
            this.lblSelectedSeries = new System.Windows.Forms.Label();
            this.cmbSelectedSeries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRemaining = new System.Windows.Forms.ListBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.cmbWatched = new System.Windows.Forms.ListBox();
            this.lblWatched = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectedSeries
            // 
            this.lblSelectedSeries.AutoSize = true;
            this.lblSelectedSeries.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSeries.Location = new System.Drawing.Point(12, 9);
            this.lblSelectedSeries.Name = "lblSelectedSeries";
            this.lblSelectedSeries.Size = new System.Drawing.Size(96, 16);
            this.lblSelectedSeries.TabIndex = 0;
            this.lblSelectedSeries.Text = "Selected Series:";
            // 
            // cmbSelectedSeries
            // 
            this.cmbSelectedSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedSeries.FormattingEnabled = true;
            this.cmbSelectedSeries.Location = new System.Drawing.Point(114, 7);
            this.cmbSelectedSeries.Name = "cmbSelectedSeries";
            this.cmbSelectedSeries.Size = new System.Drawing.Size(346, 21);
            this.cmbSelectedSeries.TabIndex = 1;
            this.cmbSelectedSeries.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedSeries_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRemaining);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.cmbWatched);
            this.groupBox1.Controls.Add(this.lblWatched);
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Series Info";
            // 
            // cmbRemaining
            // 
            this.cmbRemaining.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemaining.FormattingEnabled = true;
            this.cmbRemaining.ItemHeight = 14;
            this.cmbRemaining.Location = new System.Drawing.Point(10, 180);
            this.cmbRemaining.Name = "cmbRemaining";
            this.cmbRemaining.Size = new System.Drawing.Size(428, 102);
            this.cmbRemaining.TabIndex = 5;
            this.cmbRemaining.DoubleClick += new System.EventHandler(this.cmbDoubleClick);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(7, 164);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(106, 13);
            this.lblRemaining.TabIndex = 4;
            this.lblRemaining.Text = "Episodes Remaining:";
            // 
            // cmbWatched
            // 
            this.cmbWatched.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWatched.FormattingEnabled = true;
            this.cmbWatched.ItemHeight = 14;
            this.cmbWatched.Location = new System.Drawing.Point(10, 59);
            this.cmbWatched.Name = "cmbWatched";
            this.cmbWatched.Size = new System.Drawing.Size(428, 102);
            this.cmbWatched.TabIndex = 3;
            this.cmbWatched.DoubleClick += new System.EventHandler(this.cmbDoubleClick);
            this.cmbWatched.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWatched_KeyDown);
            // 
            // lblWatched
            // 
            this.lblWatched.AutoSize = true;
            this.lblWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatched.Location = new System.Drawing.Point(7, 42);
            this.lblWatched.Name = "lblWatched";
            this.lblWatched.Size = new System.Drawing.Size(100, 13);
            this.lblWatched.TabIndex = 2;
            this.lblWatched.Text = "Episodes Watched:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(65, 17);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(373, 20);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDirectory_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // SeriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSelectedSeries);
            this.Controls.Add(this.lblSelectedSeries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeriesView";
            this.Text = "Series Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedSeries;
        private System.Windows.Forms.ComboBox cmbSelectedSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox cmbRemaining;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.ListBox cmbWatched;
        private System.Windows.Forms.Label lblWatched;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
    }
}