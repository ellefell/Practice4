﻿/* Write a program to keep track of YouTube videos and comments left on them. 
As mentioned this could be part of a larger project to analyze them, but for this assignment, 
you will only need to worry about storing the information about a video and the comments.

Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. 
Each video also has responsibility to store a list of comments, and should have a method to return the number of comments. 
A comment should be defined by the Comment class which has the responsibility for 
tracking both the name of the person who made the comment and the text of the comment.

Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, 
and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments
 (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list. */






using System;


namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Practice 1.");

            Director director = new Director();
            director.CreateVideos();
            director.DisplayDetails();
        
        
        }

    }
}
