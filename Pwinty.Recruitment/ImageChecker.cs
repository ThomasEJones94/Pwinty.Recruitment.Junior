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
          
            for (int x = 0; x < _imageToCheck.Width; x++)
            {
                for (int y = 0; y < _imageToCheck.Height; y++)
                {
                    Color pixel = _imageToCheck.GetPixel(x, y);
                    float a = pixel.A / byte.MaxValue;
                    if ((int)Math.Round(a) == 0)
                    {
                        nPixels -= 1;
                    }
                    else
                    {
                        totalR += pixel.R * a * pixel.R * a;
                        totalG += pixel.G * a * pixel.R * a;
                        totalB += pixel.B * a * pixel.R * a;
                    }
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


