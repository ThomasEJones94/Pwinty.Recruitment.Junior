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

- Task: Calculate the average colour
For this taks I took a simple approach of cycling through the height and width of the bitmap with two
'for' loops and reading the colour of each pixel with the GetColourAtPixel function. This process works
fine for smaller images but becomes a more of an issue when dealing with larger image.

I also use seperate variables for the avarage count of each number in case the total amount of each
coloured pixel is needed.

- Task: Transparency
For this task I simply check if the current pixel is transparent or not by checking if the alpha
value returns 255 then increment a count instead of adding that pixel to th colour tally count.

- Task: Performance
For this task it took many hours of research into wether or not unsafe code is the correct way of
of processing a bitmap faster than invoking GetPixel(). Unless I was to use the marshal.copy technique
of which I did not 100% understand, the only documented way was through using unsafe code.

For this task I break down each pixel into bytes and read the raw data in order to group as colour.

Pro-
Great for preformance critical code
Con-
cannot be verified to be safe, will only execute when the code is fully trusted. 
Unsafe code cannot be executed in an untrusted environment. 



