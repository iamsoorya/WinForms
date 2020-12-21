
namespace WinFormsPhotoSlider
{
    partial class PhotoSlider
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletePhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.currentFileNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.totalFiles = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.fileDirectory = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startTime = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentTime);
            this.panel1.Controls.Add(this.endTime);
            this.panel1.Controls.Add(this.startTime);
            this.panel1.Controls.Add(this.deletePhoto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fileLocation);
            this.panel1.Controls.Add(this.currentFileNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 64);
            this.panel1.TabIndex = 0;
            // 
            // deletePhoto
            // 
            this.deletePhoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deletePhoto.Location = new System.Drawing.Point(720, 19);
            this.deletePhoto.Name = "deletePhoto";
            this.deletePhoto.Size = new System.Drawing.Size(75, 31);
            this.deletePhoto.TabIndex = 6;
            this.deletePhoto.Text = "Delete";
            this.deletePhoto.UseVisualStyleBackColor = true;
            this.deletePhoto.Click += new System.EventHandler(this.deletePhoto_Click);
            this.deletePhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deletePhoto_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current count";
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(12, 21);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(675, 26);
            this.fileLocation.TabIndex = 0;
            // 
            // currentFileNumber
            // 
            this.currentFileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFileNumber.Location = new System.Drawing.Point(1042, 21);
            this.currentFileNumber.Name = "currentFileNumber";
            this.currentFileNumber.Size = new System.Drawing.Size(93, 26);
            this.currentFileNumber.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 529);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.next);
            this.panel3.Controls.Add(this.previous);
            this.panel3.Controls.Add(this.totalFiles);
            this.panel3.Controls.Add(this.selectFolder);
            this.panel3.Controls.Add(this.fileDirectory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 64);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Files";
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next.Location = new System.Drawing.Point(837, 21);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 31);
            this.next.TabIndex = 5;
            this.next.Text = "> next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previous.Location = new System.Drawing.Point(720, 20);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 32);
            this.previous.TabIndex = 4;
            this.previous.Text = "< prev";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // totalFiles
            // 
            this.totalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFiles.Location = new System.Drawing.Point(1042, 19);
            this.totalFiles.Name = "totalFiles";
            this.totalFiles.Size = new System.Drawing.Size(93, 26);
            this.totalFiles.TabIndex = 3;
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(602, 20);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(75, 32);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "...";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // fileDirectory
            // 
            this.fileDirectory.Location = new System.Drawing.Point(12, 17);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(570, 26);
            this.fileDirectory.TabIndex = 1;
            this.fileDirectory.Text = "\\\\Hegdeatri\\backup\\PhotosAndVideos";
            // 
            // startTime
            // 
            this.startTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(808, 9);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(75, 20);
            this.startTime.TabIndex = 9;
            this.startTime.Text = "startTime";
            // 
            // endTime
            // 
            this.endTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endTime.AutoSize = true;
            this.endTime.Location = new System.Drawing.Point(809, 30);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(70, 20);
            this.endTime.TabIndex = 10;
            this.endTime.Text = "endTime";
            // 
            // currentTime
            // 
            this.currentTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(921, 3);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(51, 20);
            this.currentTime.TabIndex = 11;
            this.currentTime.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox totalFiles;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.TextBox fileDirectory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentFileNumber;
        private System.Windows.Forms.Button deletePhoto;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label currentTime;
    }
}

