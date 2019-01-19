# Intro

This short exercise is meant to simulate some of the day to day work we do at Pwinty. There are a number of tasks, intended to cater for a wide range of candidates. Don't worry if you can't do any of it, and feel free to ask for help.

To submit- please make a fork of this Git repo, commit and push your changes, and then share the repo with @tomgallard. 

Please use a seperate commit for each task. Add any notes/comments to the bottom of this file

# Prerequisites

0.) This is best run in Visual Studio community edition (it's free :)). Should work on either Mac or PC

1.) Open the solution file and run the console app. Observe it writes an ARGB (Alpha, Red, Green, Blue) value to the console

# Tasks

- Task: Calculate the average colour

Complete the code in the CalculateAverageColour function in ImageChecker.cs to calculate the average colour of the supplied image. Use your judgement as to what 'average' to use (mean, mode, median).

- Task: Transparency

Consider transparency. Should a transparent pixel (i.e one whose alpha is 0) count toward the average? Why/why not? What about semi-transparency? Ensure your code reflects your opinion. Add notes to this file if you feel you need to

- Task: Performance

Think about how the performance of this function would change for a larger image. What could you do to make it faster? What 
tradeoffs would be involved? Update the code with your new approach

# Tasks (advanced)

- Task: Image Comparison

Checkout git branch feature/image-comparison

We now want to compare the average colour of the image to a number of pre-defined reference colours. Complete the GetClosestReferenceColour method to do so.

- Task: Functional test

Write a test for the above code. Consider what functionality needs testing and what types of tests need to be written.

# Notes / comments

This is the third task: Performance

There were several decisions made when writing the code in the function in tasks 1&2 that were for the sake of better performance. These include:
- Using a 'for' statement instead of a 'foreach' statement to iterate through each pixel of the image.
- Ensuring no unnecessary lines of code were contained in the function.

In this version, I have reduced the method call depth where multiple functions were used in the same line of code by creating an extra variables so that each line of code only calls one function.
Example:

Original:
    int R = (int)Math.Round(Math.Sqrt(totalR / nPixels));
    
Improved:
    float r = (float)Math.Sqrt(totalR / nPixels);
    int R = (int)Math.Round(r);
    
Both versions produce the same result. The trade off is that this increases the lines of code within the CalculateAverageColour() however it still runs faster due to reduced call depth. 

Using Stopwatch() from System.Diagnostics, the average elapsed ticks for the original code was consistently around 15700000. For the improved code the average elapsed ticks was consistently around 15300000.