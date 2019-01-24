using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace Pwinty.Recruitment
{

    public class ImageChecker
    {
        private readonly Bitmap _imageToCheck;
        private Dictionary<string, Color> _referenceColours = new Dictionary<string, Color>()
        {
            {"red", Color.FromArgb(255,0,0) },
            { "olive",Color.FromArgb(128,128,0) },
            { "teal",Color.FromArgb(0,128,128) },
            { "purple",Color.FromArgb(128,0,128) }
        };

        public ImageChecker(Bitmap imageToCheck)
        {
            _imageToCheck = imageToCheck;
        }

        public struct PixelData
        {
            public byte red;
            public byte green;
            public byte blue;
        }

        public Color CalculateAverageColour()
        {
            //calculate the average colour used in the image
            //and return it

            //Count
            int red = 0;
            int green = 0;
            int blue = 0;

            int num_transparent = 0;
            int total = 0;

            //Loop width of image.
            for(int x = 0; x < ImageWidth; x++)
            {
                //Loop hieght of image.
                for (int y = 0; y < ImageHeight; y++)
                {
                    //For transparent task
                    //Check if transparent
                    if (GetColourAtPixel(x, y).A == 225)
                    {
                        num_transparent++;
                    }
                    else
                    {
                        //Get current pixel colour
                        Color clr = GetColourAtPixel(x, y);
                        //Add to tally count
                        red += clr.R;
                        green += clr.G;
                        blue += clr.B;

                        //Count total pixels for average calculation
                        total++;
                    }
                }
            }

            //Calculate average pixel colour
            int avgR = red / total;
            int avgG = green / total;
            int avgB = blue / total;

            return Color.FromArgb(avgR, avgG, avgB);
        }

        public unsafe Color CalculateAverageColourFaster()
        {
            int red = 0;
            int green = 0;
            int blue = 0;

            long[] total = new long[] { 0, 0, 0 };

            //Define the number of bits associated with one pixel
            int bppModifier = _imageToCheck.PixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb ? 3 : 4;
            //Lock bitmap bits
            BitmapData srcData = _imageToCheck.LockBits(new Rectangle(0, 0, ImageWidth, ImageHeight), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            //Get stride width
            int stride = srcData.Stride;
            //First line address
            IntPtr ptr = srcData.Scan0;

            byte* p = (byte*)(void*)ptr;
            //Loop bitmap
            for (int x = 0; x < ImageHeight; x++)
            {
                for (int y = 0; y < ImageWidth; y++)
                {
                    int bytes = (x * stride) + y * bppModifier;

                    red = p[bytes + 2];
                    green = p[bytes + 1];
                    blue = p[bytes];
                   
                    total[2] += red;
                    total[1] += green;
                    total[0] += blue;
                }
            }

            //Calculate avarage
            int count = ImageWidth * ImageHeight;
            int avgR = (int)(total[2] / count); //Red
            int avgG = (int)(total[1] / count); //Green
            int avgB = (int)(total[0] / count); //Blue

            //Unlock bits
            _imageToCheck.UnlockBits(srcData);

            return Color.FromArgb(avgR, avgG, avgB);

            
        }

        public Color GetClosestReferenceColour()
        {
            var imageColour = CalculateAverageColour();
            //work out which of the colours in the _referenceColours object
            //is most similar to imageColour

            //replace below with calculated value
            return new Color();
        }

        private Color GetColourAtPixel(int x,int y)
        {
            return _imageToCheck.GetPixel(x, y);
        }

        private int ImageWidth
        {
            get
            {
                return _imageToCheck.Width;
            }
        }

        private int ImageHeight
        {
            get
            {
                return _imageToCheck.Height;
            }
        }
    }
}
