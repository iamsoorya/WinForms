using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class MultimediaOrganizer : Form
    {
        //private OpenFileDialog openFileDialog1;
        FolderBrowserDialog selectFolderDialog;

        public MultimediaOrganizer()
        {
            InitializeComponent();
            //openFileDialog1 = new OpenFileDialog();
            selectFolderDialog = new FolderBrowserDialog();
        }

        private void SetSourceDirText(string text)
        {
            sourceDir.Text = text;
        }

        private void SetDestinationDirText(string text)
        {
            destinationDir.Text = text;
        }

        private void SelectSourceDir_Click(object sender, EventArgs e)
        {
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetSourceDirText(selectFolderDialog.SelectedPath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void SelectDestinationDir_Click(object sender, EventArgs e)
        {
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetDestinationDirText(selectFolderDialog.SelectedPath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void CopyFiles_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            startTimeLabel.Text = DateTime.Now.ToLongTimeString();
            try
            {
                //StringBuilder sb = new StringBuilder();
                string str = string.Empty;
                List<FileInfo> fileInfoList = new List<FileInfo>();
                EnumerateFiles(sourceDir.Text, fileInfoList);
                str = ("Total files : " + fileInfoList.Count.ToString() + Environment.NewLine );
                displayResult.Text += str;
                int totalFiles = fileInfoList.Count;
                int fileCount = 0;
                foreach (var fi in fileInfoList)
                {
                    str = string.Empty;
                    Task<string> task = Task<string>.Factory.StartNew(() =>
                    {
                        try
                        {
                            Console.WriteLine();
                            str = (string.Format("{0}: {1}: {2}: {3}", fi.Name, fi.CreationTime, fi.LastAccessTime, fi.Length) + Environment.NewLine);
                            CopyToTarget(destinationDir.Text, fi, txtExtn.Text);
                            fileCount += 1;
                            return "Success!";
                        }
                        catch (Exception exp1)
                        {
                            return "Error: " + exp1.Message;
                        }
                    });
                    Task UITask = task.ContinueWith((ret) =>
                    {
                        displayResult.Text += str;
                        statusLabel.Text = "Copying..." + fi.Name;
                        endTimeLabel.Text = DateTime.Now.ToLongTimeString();
                        displayResult.SelectionStart = displayResult.TextLength;
                        displayResult.ScrollToCaret();
                        if (fileCount == totalFiles)
                        {
                            statusLabel.Text = "All files copied";
                            this.Cursor = Cursors.Default;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    
                }
            }

            catch (Exception exp2)
            {
                displayResult.Text += string.Format("{0}, {1}", "CopyFiles_Click", exp2);
            }
            finally
            {
                statusLabel.Text = "All files copied";
                this.Cursor = Cursors.Default;
            }
        }

        private void EnumerateFiles(string sFullPath, List<FileInfo> fileInfoList)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(sFullPath);
                FileInfo[] files;
                if (string.IsNullOrEmpty(txtExtn.Text))
                {
                    files = di.GetFiles();
                }
                else
                {
                    files = di.GetFiles("*" + txtExtn.Text);
                }
                foreach (FileInfo file in files)
                    fileInfoList.Add(file);

                //Scan recursively
                DirectoryInfo[] dirs = di.GetDirectories();
                if (dirs == null || dirs.Length < 1)
                    return;
                foreach (DirectoryInfo dir in dirs)
                    EnumerateFiles(dir.FullName, fileInfoList);

            }
            catch (Exception ex)
            {
                displayResult.Text += string.Format("{0}, {1}", "Exception in EnumerateFiles", ex);
            }
        }

        private void CopyToTarget(string destnDir, FileInfo fi, string extn)
        {
            try
            {
                DateTime dt = fi.LastWriteTime;
                if (fi.Extension.ToUpper() != extn.ToUpper()) return;
                CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                string monthName1 = ci.DateTimeFormat.GetMonthName(dt.Month);
                string monthName2 = ci.DateTimeFormat.GetAbbreviatedMonthName(dt.Month);
                string destinationPath = string.Empty; string monthNumber = string.Empty;
                if (dt.Month > 9) monthNumber = dt.Month.ToString(); else monthNumber = "0" + dt.Month.ToString();
                destinationPath = destnDir + "/" + extn.Substring(1) + "/" + dt.Year.ToString() + "/" + monthNumber + monthName2;
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                fi.MoveTo(destinationPath + "/" + fi.Name);
                //fi.CopyTo(destinationPath + "/" + fi.Name, true);
                string srcDir = fi.DirectoryName;
            }
            catch (Exception exp)
            {                
                FileStream fs = new FileStream(destnDir + "/" + "Exception.log", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.AutoFlush = true;                
                sw.WriteLine("Failed to copy : " + fi.FullName);
                sw.WriteLine(exp.Message);
                sw.WriteLine(exp.StackTrace);
                sw.WriteLine(exp.Source);
                sw.WriteLine("Failed to copy : " + fi.FullName);
                if (exp.InnerException != null) sw.WriteLine(exp.InnerException.Message);
                sw.WriteLine("");
                sw.Flush();
                sw.Close();
                fs.Close();
                
            }
            
        }
    }
}
