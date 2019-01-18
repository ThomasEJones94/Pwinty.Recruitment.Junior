using System;
using System.Drawing;

namespace Pwinty.Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var imageLoader = new ImageLoader();
            var image = imageLoader.LoadImage("/Users/ploutiskoumi/Projects/Pwinty.Recruitment.Junior/Pwinty.Recruitment/images/part1.png"); 

            var imageChecker = new ImageChecker((Bitmap)image);
            Console.WriteLine($"The average colour of the image is {imageChecker.CalculateAverageColour()}");
            Console.ReadKey();
        }

        
    }
}
