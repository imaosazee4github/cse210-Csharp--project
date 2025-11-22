using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Videos Program\n");

        //Create the video
        Video vid1 = new Video("Learning C#", "Code By Mosh", 900);
        vid1.AddComment(new Comment("Edwin", "Vety Thoughtful!"));
        vid1.AddComment(new Comment("Zara", "I Learned a lot."));
        vid1.AddComment(new Comment("Kelvin", "Thanks for the lesson!"));

        Video vid2 = new Video("How to Cook Nigeria Jollof Rice", "Nigerian Kitchen", 600);
        vid2.AddComment(new Comment("Blessing", "Looks delicious!"));
        vid2.AddComment(new Comment("Joshua", "I will try this recipe."));
        vid2.AddComment(new Comment("Osazee", "Great instructions!"));

        Video vid3 = new Video("React Js Beginners Guide", "FireShip", 300);
        vid3.AddComment(new Comment("Success", "This is awesome."));
        vid3.AddComment(new Comment("Elvis","Super clear explaination."));
        vid3.AddComment(new Comment("James", "Helped me understand props."));

        //Add all videos to a list
        List<Video>videos = new List<Video>(){vid1, vid2, vid3};

        //Display all videos
        foreach(Video v in videos)
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"Title:{v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments.");

            foreach(Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.GetName()}: {c.GetText()}");
            }
            Console.WriteLine("-----------\n");
        }
    }
}