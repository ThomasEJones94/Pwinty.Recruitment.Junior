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

- Task: Functional test

Write a test for the above code. Consider what functionality needs testing and what types of tests need to be written.

- Task: Test suite

Write a suite of tests that cover as much code as you consider necessary. Consider using different images of differing sizes in your tests. Consider using different types of tests to test different functionality.

- Task: Validation of input? Ensure we receive a valid filetype? 
- Task: Define image as a parameter? i.e `prog.exe --image="images\img1.png"` or in csproj properties debug info?
- Task: Consider Tools/frameworks? Out of scope? 

# Notes / comments

Add your notes here

