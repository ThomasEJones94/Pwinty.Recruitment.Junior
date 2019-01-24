using System;
using System.Diagnostics;
using System.Drawing;

namespace Pwinty.Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stopwatch sw = new Stopwatch();

            Console.WriteLine("Hello World!");
            var imageLoader = new ImageLoader();
            var image = imageLoader.LoadImage(@"images\part1.png");

            var imageChecker = new ImageChecker((Bitmap)image);

            
            Console.WriteLine($"The average colour of the image is: {imageChecker.CalculateAverageColour()}");

            
            Console.WriteLine($"The average colour of the image using unsafe is: {imageChecker.CalculateAverageColourFaster()}");
            

            //TimeSpan ts = sw.Elapsed;
            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds);
            //Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadKey();
        }

        
    }
}
