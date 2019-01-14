using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pwinty.Recruitment
{
    public class ImageLoader
    {
        public Image LoadImage(string path)
        {
            return Image.FromFile(path);
        }
    }
}
