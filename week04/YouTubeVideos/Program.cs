using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Get ready with me", "Erandy", 900);
        video1.AddComment(new Comment("Alice", "Love the outfit!"));
        video1.AddComment(new Comment("Josh", "nice video"));
        video1.AddComment(new Comment("Danna", "Breakfast recipe, please!"));

        Video video2 = new Video("Greek yogurt recipe", "Daniel", 500);
        video2.AddComment(new Comment("Hanna", "I wanna make this"));
        video2.AddComment(new Comment("Zac", "It seems easy to make"));
        video2.AddComment(new Comment("Greg", "Great vieo, thx"));

        VideoLibrary library = new VideoLibrary();
        library.AddVideo(video1);
        library.AddVideo(video2);

        foreach (Video video in library.GetAllVideos())
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");

            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($">>{comment.GetCommentName()}: {comment.GetCommentText()}");
            }
        }
    }
}