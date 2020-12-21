using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Security;

namespace WinFormsPhotoSlider
{
    public partial class PhotoSlider : Form
    {
        public PhotoSlider()
        {
            InitializeComponent();
            selectFolderDialog = new FolderBrowserDialog();
        }

        private FolderBrowserDialog selectFolderDialog;
        private bool timeStopped = false;
        private int counter = 0;
        private string[] files;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            startTime.Text = DateTime.Now.ToLongTimeString();
            counter++;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            files = System.IO.Directory.GetFiles(fileDirectory.Text, "*.*", System.IO.SearchOption.AllDirectories);
            totalFiles.Text = files.Length.ToString();
        }

        private void timer1_Tick(object Sender, EventArgs e)
        {
            if (counter >= files.Count())
            {
                timer1.Enabled = false;
                timer1.Stop();
                timeStopped = true;
                endTime.Text = DateTime.Now.ToLongTimeString();
                return;
            }
            currentTime.Text = DateTime.Now.ToLongTimeString();
            LoadFile();
            counter++;
        }
        private string fileName = string.Empty;
        private FileInfo fi = null;
        void LoadFile()
        {
            fileName = files[counter];
            fi = new FileInfo(fileName);
            if (fi.Extension.ToLower() == ".mpg") return;
            try
            {                
                using (var image = new Bitmap(fileName))
                {   
                    var img2 = PerformImageResizeAndPutOnCanvas(files[counter], pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = img2;
                    pictureBox1.WaitOnLoad = true;
                    fileLocation.Text = files[counter];
                    currentFileNumber.Text = counter.ToString();
                }
            }
            catch (Exception exp)
            {
                //MessageBox.Show(fileName + Environment.NewLine + exp.Message + Environment.NewLine + exp.StackTrace);
                WriteExceptionToFile(exp);
            }
        }

        public ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(t => t.MimeType == mimeType);
        }

        public Image PutOnCanvas(Image image, int width, int height, Color canvasColor)
        {
            try
            {
                if (width == 0) width = 1280;
                if (height == 0) height = 615;
                var res = new Bitmap(width, height);
                using (var g = Graphics.FromImage(res))
                {
                    g.Clear(canvasColor);
                    var x = (width - image.Width) / 2;
                    var y = (height - image.Height) / 2;
                    g.DrawImageUnscaled(image, x, y, image.Width, image.Height);
                }

                return res;
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message + Environment.NewLine + exp.StackTrace);
                WriteExceptionToFile(exp);
            }
            return null;
        }

        public Image ResizeImage(Image image, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            if (onlyResizeIfWider && image.Width <= newWidth) newWidth = image.Width;

            var newHeight = image.Height * newWidth / image.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead  
                newWidth = image.Width * maxHeight / image.Height;
                newHeight = maxHeight;
            }

            try
            {
                if (newWidth == 0) newWidth = 1280;
                if (newHeight == 0) newHeight = 615;
                var res = new Bitmap(newWidth, newHeight);

                using (var graphic = Graphics.FromImage(res))
                {
                    graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphic.SmoothingMode = SmoothingMode.HighQuality;
                    graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphic.CompositingQuality = CompositingQuality.HighQuality;
                    graphic.DrawImage(image, 0, 0, newWidth, newHeight);
                }

                return res;
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message + Environment.NewLine + exp.StackTrace);
                WriteExceptionToFile(exp);
            }
            return null;
        }

        public Image PerformImageResizeAndPutOnCanvas(string file, int pWidth, int pHeight)
        {
            System.Drawing.Image imgBef;
            imgBef = System.Drawing.Image.FromFile(file);

            System.Drawing.Image _imgR;
            _imgR = ResizeImage(imgBef, pWidth, pHeight, true);

            System.Drawing.Image _img2;
            _img2 = PutOnCanvas(_imgR, pWidth, pHeight, System.Drawing.Color.White);

            imgBef.Dispose();
            _imgR.Dispose();

            return _img2;            

        }
      
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timeStopped)
            {
                timer1.Stop();
                timeStopped = true;
            }
            else
            {
                timer1.Start();
                timeStopped = false;
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            counter--;
            LoadFile();
        }

        private void next_Click(object sender, EventArgs e)
        {
            counter++;
            LoadFile();
        }

        private void WriteExceptionToFile(Exception exp)
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + "Exception.log", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.AutoFlush = true;
            sw.WriteLine("Filename : " + fileName);
            sw.WriteLine(exp.Message);
            sw.WriteLine(exp.StackTrace);
            sw.WriteLine(exp.Source);
            if (exp.InnerException != null) sw.WriteLine(exp.InnerException.Message);
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileDirectory.Text = selectFolderDialog.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void deletePhoto_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeStopped = true;
            File.Move(fileName, @"C:\PhotoTobeDeleted\" + fi.Name);
            timer1.Start();
            timeStopped = false;
        }


        private void deletePhoto_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            timeStopped = true;
        }
    }
}
