using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pwinty.Recruitment
{
    public class ImageChecker
    {
        private readonly Bitmap _imageToCheck;
        public ImageChecker(Bitmap imageToCheck)
        {
            _imageToCheck = imageToCheck;

        }

        public Color CalculateAverageColour()
        {
            double nPixels = _imageToCheck.Width * _imageToCheck.Height;
            double totalR = 0; 
            double totalG = 0; 
            double totalB = 0;
            string s1 = "(";  
            string s2 = ",";  
            string s3 = ")";

            for (int x = 0; x < _imageToCheck.Width; x++)
            {
                for (int y = 0; y < _imageToCheck.Height; y++)
                {
                    Color pixel = _imageToCheck.GetPixel(x, y);
                    totalR += pixel.R * pixel.R;
                    totalG += pixel.G * pixel.R;
                    totalB += pixel.B * pixel.R;
                }
            }
            int R = (int)Math.Round(Math.Sqrt(totalR / nPixels));
            int G = (int)Math.Round(Math.Sqrt(totalG / nPixels));
            int B = (int)Math.Round(Math.Sqrt(totalB / nPixels));
            return Color.FromArgb(R,G,B);
        }
        private Color GetColourAtPixel(int x, int y)
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


