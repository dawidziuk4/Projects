using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Pikselator
{
    class Pixelating
    {
        public const string CppFunctionsDLL = "C:\\Users\\dawid\\source\\repos\\Pikselator\\Debug\\PikselatorCpp.dll";
        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int pixelateAsembler(int a, int b);

        public Pixelating()
        {

        }
        
        public static bool ConvertToGray(Bitmap b)
        {
            for(int i=0;i<b.Width;i++)
                for(int j=0;j<b.Height;j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1+.587*g1+.114*b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j,Color.FromArgb(r1,g1,b1));

                }
            return true;
        }
        public static Bitmap pixelate(Bitmap image, Int32 pixelateSize, int numOfThreads)
        {

            int newWidth = image.Width / numOfThreads;
            int startingWidth = 0;
            int endingWidth = 0;
            Bitmap[] partOfImage = new Bitmap[numOfThreads];
            Thread[] threads = new Thread[numOfThreads];

            for (int i = 0; i < 64; i++)
            {
                Rectangle rect = new Rectangle(i * newWidth, 0, newWidth, image.Height);
                partOfImage[i] = new Bitmap(image, newWidth, image.Height);
                partOfImage[i] = image.Clone(rect, partOfImage[i].PixelFormat);
            }
            for (int i =0 ; i < numOfThreads; i++)
            {
                Rectangle rect = new Rectangle(i * newWidth, 0, newWidth, image.Height);
                partOfImage[i] = new Bitmap(image, newWidth, image.Height);
                partOfImage[i] = image.Clone(rect, partOfImage[i].PixelFormat);

                threads[i] = new Thread(() => { partOfImage[i] = pixelateThreaded(startingWidth*i, endingWidth * i + newWidth, i, partOfImage[i], pixelateSize, newWidth); } );
                threads[i].Start();
                threads[i].Join();
            }
            // look at every pixel in the rectangle while making sure we're within the image bounds
            image = MergedBitmaps(partOfImage, image.Width, image.Height,newWidth);
            return image;
        }

        //public static Bitmap pixelateAsm(Bitmap copy, int x, int num)
        //{
        //    pixelateAsembler(x, num);
        //}

        public static Bitmap pixelateThreaded(int startingWidth,int endingWidth, int numOfThread, Bitmap image, Int32 pixelateSize,int newWidth)
        {

          
            Bitmap partOfImage = new Bitmap(newWidth, image.Height);
            
            Console.Write("Im {0} thread", numOfThread);
           
                for (Int32 xx = startingWidth; xx < endingWidth; xx += pixelateSize)
                {
                    // sw = Stopwatch.StartNew();
                    for (Int32 yy = 0; yy < partOfImage.Height; yy += pixelateSize)
                    {
                        Int32 offsetX = pixelateSize / 2;
                        Int32 offsetY = pixelateSize / 2;

                        // make sure that the offset is within the boundry of the image
                        while (xx + offsetX >= partOfImage.Width) offsetX--;
                        while (yy + offsetY >= partOfImage.Height) offsetY--;

                        // get the pixel color in the center of the soon to be pixelated area
                        Color pixel = image.GetPixel(xx + offsetX, yy + offsetY);

                        // for each pixel in the pixelate size, set it to the center color
                        for (Int32 x = xx; x < xx + pixelateSize && x < partOfImage.Width; x++)
                            for (Int32 y = yy; y < yy + pixelateSize && y < partOfImage.Height; y++)
                            partOfImage.SetPixel(x, y, pixel);
                    }
                }
            return partOfImage;
        }
        public static Bitmap MergedBitmaps(Bitmap[] bmps,int width,int height,int newWidth)
        {
            Bitmap result = new Bitmap(width, height);
            Console.Write("Merging {0} btmps", bmps.Length);
            using (Graphics g = Graphics.FromImage(result))
            {
                for (int i = 0; i < bmps.Length; i++)
                {
                    Point p = new Point(i * newWidth,0);
                    g.DrawImage(bmps[i],p); 
                }
            }
            return result;
        }
        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }
      //  public static Bitmap[] splitBitmap(Bitmap src, int num)
       // {
           
        //}
    }
        
    }

