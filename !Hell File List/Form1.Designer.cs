namespace _Hell_File_List
{
    partial class fIndex
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
            this.cbSubfolder = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.cbSeparator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSubfolder);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose folder:";
            // 
            // cbSubfolder
            // 
            this.cbSubfolder.AutoSize = true;
            this.cbSubfolder.Enabled = false;
            this.cbSubfolder.Location = new System.Drawing.Point(6, 45);
            this.cbSubfolder.Name = "cbSubfolder";
            this.cbSubfolder.Size = new System.Drawing.Size(97, 17);
            this.cbSubfolder.TabIndex = 2;
            this.cbSubfolder.Text = "Scan subfolder";
            this.cbSubfolder.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(6, 19);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(350, 20);
            this.tbPath.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Give file names";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbSeparator
            // 
            this.cbSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeparator.FormattingEnabled = true;
            this.cbSeparator.Items.AddRange(new object[] {
            "New Line",
            ":",
            "::",
            ":;",
            "_",
            "-",
            "/",
            "|",
            "space"});
            this.cbSeparator.Location = new System.Drawing.Point(85, 78);
            this.cbSeparator.Name = "cbSeparator";
            this.cbSeparator.Size = new System.Drawing.Size(283, 21);
            this.cbSeparator.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Separator:";
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 108);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeparator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbSeparator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSubfolder;
        private System.ComponentModel.BackgroundWorker bw;
    }
}

