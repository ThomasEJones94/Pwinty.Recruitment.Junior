using System;
using System.Diagnostics;
using System.Drawing;

namespace Pwinty.Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please make this window wider for easier reading. \nThis is a functional test for functions within ImageChecker.\nThe user inputs an image and the reference colour they think it's the closest to. \nImages and  their expected closest matching reference colour can be added to array 'imageFilePaths'. \nSome images have been added for ease. Please adjust the image file paths and run this code again. \nOnce file paths have been adjusted, press any key to begin.");
            Console.ReadLine();
            var imageLoader = new ImageLoader();
            byte nSuccesses = 0;
            byte nFailures = 0;
            string[,] imageFilePaths = new string[,]
            {
                {"purple", "/Users/ploutiskoumi/Projects/Pwinty.Recruitment.Junior/Pwinty.Recruitment/images/hallmark_logo.png" },
                {"teal", "/Users/ploutiskoumi/Projects/Pwinty.Recruitment.Junior/Pwinty.Recruitment/images/google_l_green.png" },
                {"red", "/Users/ploutiskoumi/Projects/Pwinty.Recruitment.Junior/Pwinty.Recruitment/images/netflix_logo.png"},
                {"olive","/Users/ploutiskoumi/Projects/Pwinty.Recruitment.Junior/Pwinty.Recruitment/images/sprite_logo_green2.png"}
            };

            for (int i = 0; i<imageFilePaths.GetLength(0); i++)
            {
                Image image = imageLoader.LoadImage(imageFilePaths[i, 1]);
                ImageChecker imageChecker = new ImageChecker((Bitmap)image);

                Console.WriteLine($"Current input image:\n{imageFilePaths[i, 1]}");
                Console.WriteLine($"The average colour of the first image is {imageChecker.CalculateAverageColour()}");
                Console.WriteLine($"The closest matching colour to the first image is: {imageChecker.GetClosestReferenceColour()}");
                Console.WriteLine($"The expected closest matching colour is: {imageChecker._referenceColours[imageFilePaths[i,0]]}");

                if (imageChecker.GetClosestReferenceColour() == imageChecker._referenceColours[imageFilePaths[i, 0]])
                {
                    Console.WriteLine("SUCCESS. - input image matched to expected reference colour.");
                    nSuccesses++;
                }
                else
                {
                    Console.WriteLine("FAIL. - input image not matched to expected reference colour.");
                    nFailures++;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            Console.WriteLine("Test Complete.");
            Console.WriteLine($"Total Successes: {nSuccesses}\nTotal Failures: {nFailures}");
        }
        
    }
}
