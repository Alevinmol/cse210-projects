using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to catch a pokemon", "Ash", 120);
        Video video2 = new Video("How to evolve a pokemon", "Brook", 150);
        Video video3 = new Video("How to beat a gym leader", "Misty", 130);

        Comment comment11 = new Comment("Charmander", "Thank you now I will get more pals");
        Comment comment12 = new Comment("Charmeleon", "I already knew that");
        Comment comment13 = new Comment("Charizard", "I love this trainer");
        Comment comment21 = new Comment("Geodude", "I need to make friends");
        Comment comment22 = new Comment("Onix", "How do I find a metal coat?");
        Comment comment23 = new Comment("Mudkip", "Thanks, super helpful");
        Comment comment31 = new Comment("Goldeen", "You make it sound easy");
        Comment comment32 = new Comment("Starmie", "I am ready to beat everyone");
        Comment comment33 = new Comment("Blastoise", "Good luck with that");

        video1._comments.Add(comment11);
        video1._comments.Add(comment12);
        video1._comments.Add(comment13);
        video2._comments.Add(comment21);
        video2._comments.Add(comment22);
        video2._comments.Add(comment23);
        video3._comments.Add(comment31);
        video3._comments.Add(comment32);
        video3._comments.Add(comment33);

        List<Video> videos =  new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video title: {video._title}.");
            Console.WriteLine($"Author: {video._author}.");
            Console.WriteLine($"Length: {video._length} seconds.");
            Console.WriteLine();
            int NumberOfComments = video.NumberOfComments();
            Console.WriteLine($"Number of comments: {NumberOfComments}.");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}