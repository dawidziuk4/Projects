using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;

namespace Pikselator
{
    public partial class Form1 : Form
    {
        private int prevVal = 0;
        int choice;
        private byte[] SourceFile { get; set; }
        OpenFileDialog openFile = new OpenFileDialog();
        
        
        public Form1()
        {
            InitializeComponent();
            
        }
        public void showComponents()
        {
            
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            
            openFile.Filter = "Bitmap files (*.bmp)|*.bmp";

            if (DialogResult.OK == openFile.ShowDialog())
            {
                
                this.pictureOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureOriginal.Image = new Bitmap(openFile.FileName);
                this.picturePixelated.SizeMode = PictureBoxSizeMode.StretchImage;

                int pixelSize = Image.GetPixelFormatSize(this.pictureOriginal.Image.PixelFormat);
               
            }
        }

        private unsafe void BtnPixelate_Click(object sender, EventArgs e)
        {
            showComponents();
            SourceFile = File.ReadAllBytes(openFile.FileName);

            int numOfThreads = trackBar.Value;
            int PixelateWidth = trackBar1.Value;
            bool isAsmLibraryOn = radioButton1.Checked;
            byte[] finished;
            Bitmap copy = new Bitmap((Bitmap)this.pictureOriginal.Image);         
            Stopwatch sw = Stopwatch.StartNew();
            finished = Pixelating.PrepareToPixelate(SourceFile, numOfThreads, PixelateWidth, isAsmLibraryOn);
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            copy = (Bitmap)tc.ConvertFrom(finished);
            sw.Stop();
            label3.Text = sw.ElapsedMilliseconds.ToString();
            this.picturePixelated.Image = copy;
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        
        private static Bitmap cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeChoice(1);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeChoice(2);
        }
        public void changeChoice(int x)
        {
            this.choice = x;
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void PicturePixelated_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar.Value.ToString();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
           
            if (trackBar1.Value % 2 == 0)
                if (prevVal < trackBar1.Value)
                    trackBar1.Value++;
                else if (prevVal > trackBar1.Value)
                          trackBar1.Value--;
       

            label5.Text = trackBar1.Value.ToString();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }

}
