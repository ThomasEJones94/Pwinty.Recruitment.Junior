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
            //calculate the average colour used in the image
            //and return it

            //dummy value for now
            return Color.FromArgb(100, 0, 0);
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
