using System;
using System.Collections.Generic;
using System.Drawing;
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
            //calculate the average colour used in the image
            //and return it

            //dummy value for now
            return Color.FromArgb(100, 0, 0);
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
