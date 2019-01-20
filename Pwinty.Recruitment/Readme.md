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

This is the fifth(advanced) task: Functional Test

I have written a test in Program.cs where one can enter image file paths and its expected closest reference colour based on their visual perception.

This tests the functionality of imageChecker.CalculateAverageColour() as well as imageChecker.GetClosestReferenceColour() because if either of these functions are not working well enough, the test will produce fails. Therefore, there is no need for unit tests.

Potential unit test for imageChecker.CalculateAverageColour():
    Method 1:
        -Use same input image into this function and into an online average colour generator and compare results.
    Method 2:
        -Input image solid block of known RGB values. Assess how close the output of the function is to the known input values.
        -Vary the opacity of a number of pixels and repeat the test. 
        
Potential unit test for imageChecker.GetClosestReferenceColour():
    -Enter Color values with RGB values that match the values for each key in _refernceColours. Assess if the output is the same as the input.
    -Enter Color values with RGB values where each value is +/-10 of the values in _referenceColours. Assess if the output produces the correct values of the corresponding input values.