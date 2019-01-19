using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public Color CalculateAverageColour()
        { 
            double nPixels = ImageWidth * ImageHeight;
            double totalR = 0; 
            double totalG = 0; 
            double totalB = 0;

            for (int x = 0; x < ImageWidth; x++)
            {
                for (int y = 0; y < ImageHeight; y++)
                {
                    Color pixel = GetColourAtPixel(x, y);
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
            float r = (float)Math.Sqrt(totalR / nPixels);
            float g = (float)Math.Sqrt(totalG / nPixels);
            float b = (float)Math.Sqrt(totalB / nPixels);
            int R = (int)Math.Round(r);
            int G = (int)Math.Round(g);
            int B = (int)Math.Round(b);
            return Color.FromArgb(R,G,B);
        }

        public Color GetClosestReferenceColour()
        {
            Color imageColour = CalculateAverageColour();
            Color closestColourValue;
            string closestColourKey;
            byte r1 = imageColour.R;
            byte g1 = imageColour.G;
            byte b1 = imageColour.B;

            string[] keys = new string[_referenceColours.Keys.Count];
            _referenceColours.Keys.CopyTo(keys, 0);
            double[] deltaArray = new double[keys.Length];

            for (int i = 0; i < keys.Length; i++)
            {
                string key = keys[i];
                byte r2 = _referenceColours[key].R;
                byte g2 = _referenceColours[key].G;
                byte b2 = _referenceColours[key].B;

                var rDelta = Math.Abs(r2 - r1);
                var gDelta = Math.Abs(g2 - g1);
                var bDelta = Math.Abs(b2 - b1);

                double rgbDelta = Math.Pow(rDelta * 0.30, 2) + Math.Pow(gDelta * 0.59, 2) + Math.Pow(bDelta * 0.11, 2);
                deltaArray[i] = rgbDelta;
            }

            int minDelta = (int)deltaArray.Min();

            for (int i = 0; i < keys.Length; i++)
            {
                int currentDelta = (int)deltaArray[i];
                if (currentDelta == minDelta)
                {
                    closestColourKey = keys[i];
                    closestColourValue = _referenceColours[closestColourKey];
                }
            }

            return closestColourValue;
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


