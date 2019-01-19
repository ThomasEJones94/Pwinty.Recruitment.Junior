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

This is the fourth task(advanced): Image-comparison

Inside ImageChecker.GetClosestReferenceColour() a loop iterates through each pair in the dictionary of reference colours to find the differences between the RGB values of the reference colours and the RGB values returned from ImageChecker.CalculateAverageColour().

Each value difference is multiplied by 0.3,0.59 and 0.11 for R,G and B respectively to weight each value according to our perception of these colours. Then they are squared and summed to give an overall RGB difference for each reference colour. These values are stored in 'deltaArray'.

'deltaArray' and 'keys'(an array containing the keys of the dictionary) are then used in a second loop to find the key to the minimum value which must be the closest to the average of the input image. The value paired with that key is returned.

