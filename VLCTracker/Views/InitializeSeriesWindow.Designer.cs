namespace VLCTracker.Views
{
    partial class InitializeSeriesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializeSeriesWindow));
            this.lbl1 = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(377, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Series Initialization";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.txtName);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.txtDirectory);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(15, 35);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(374, 63);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(64, 13);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(298, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 20);
            this.txtName.TabIndex = 3;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(162, 104);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // InitializeSeriesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 131);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitializeSeriesWindow";
            this.Text = "VLC Tracker";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
    }
}