namespace PhotoOrganizer
{
    partial class MultimediaOrganizer
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.copyFiles = new System.Windows.Forms.Button();
            this.selectDestinationDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationDir = new System.Windows.Forms.TextBox();
            this.selectSourceDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceDir = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.displayResult = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endTimeLabel);
            this.groupBox1.Controls.Add(this.startTimeLabel);
            this.groupBox1.Controls.Add(this.copyFiles);
            this.groupBox1.Controls.Add(this.selectDestinationDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.destinationDir);
            this.groupBox1.Controls.Add(this.selectSourceDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sourceDir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select source directory";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(608, 51);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "label3";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(606, 22);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "label3";
            // 
            // copyFiles
            // 
            this.copyFiles.Location = new System.Drawing.Point(713, 47);
            this.copyFiles.Name = "copyFiles";
            this.copyFiles.Size = new System.Drawing.Size(75, 20);
            this.copyFiles.TabIndex = 6;
            this.copyFiles.Text = "Copy Files";
            this.copyFiles.UseVisualStyleBackColor = true;
            this.copyFiles.Click += new System.EventHandler(this.CopyFiles_Click);
            // 
            // selectDestinationDir
            // 
            this.selectDestinationDir.Location = new System.Drawing.Point(541, 48);
            this.selectDestinationDir.Name = "selectDestinationDir";
            this.selectDestinationDir.Size = new System.Drawing.Size(52, 20);
            this.selectDestinationDir.TabIndex = 5;
            this.selectDestinationDir.Text = "•••";
            this.selectDestinationDir.UseVisualStyleBackColor = true;
            this.selectDestinationDir.Click += new System.EventHandler(this.SelectDestinationDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Directory :";
            // 
            // destinationDir
            // 
            this.destinationDir.Location = new System.Drawing.Point(115, 47);
            this.destinationDir.Name = "destinationDir";
            this.destinationDir.Size = new System.Drawing.Size(418, 20);
            this.destinationDir.TabIndex = 3;
            this.destinationDir.Text = "C:\\DestinationFile";
            // 
            // selectSourceDir
            // 
            this.selectSourceDir.Location = new System.Drawing.Point(541, 22);
            this.selectSourceDir.Name = "selectSourceDir";
            this.selectSourceDir.Size = new System.Drawing.Size(52, 20);
            this.selectSourceDir.TabIndex = 2;
            this.selectSourceDir.Text = "•••";
            this.selectSourceDir.UseVisualStyleBackColor = true;
            this.selectSourceDir.Click += new System.EventHandler(this.SelectSourceDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory :";
            // 
            // sourceDir
            // 
            this.sourceDir.Location = new System.Drawing.Point(115, 23);
            this.sourceDir.Name = "sourceDir";
            this.sourceDir.Size = new System.Drawing.Size(418, 20);
            this.sourceDir.TabIndex = 0;
            this.sourceDir.Text = "C:\\SourceFile";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 63);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 291);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.displayResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 289);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File copy status";
            // 
            // displayResult
            // 
            this.displayResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.displayResult.Location = new System.Drawing.Point(11, 19);
            this.displayResult.Multiline = true;
            this.displayResult.Name = "displayResult";
            this.displayResult.ReadOnly = true;
            this.displayResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayResult.Size = new System.Drawing.Size(533, 264);
            this.displayResult.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(558, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "label3";
            // 
            // MultimediaOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.HelpButton = true;
            this.Name = "MultimediaOrganizer";
            this.Text = "Multimedia Organizer";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectSourceDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceDir;
        private System.Windows.Forms.Button selectDestinationDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox displayResult;
        private System.Windows.Forms.Button copyFiles;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

