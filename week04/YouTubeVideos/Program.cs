using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // create 3-4 videos
        // for simplicity, just using Title 1, Author 1, etc.
        Comment comment1 = new Comment("Name 1", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment2 = new Comment("Name 2", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment3 = new Comment("Name 3", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment4 = new Comment("Name 4", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment5 = new Comment("Name 5", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment6 = new Comment("Name 6", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment7 = new Comment("Name 7", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment8 = new Comment("Name 8", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment9 = new Comment("Name 9", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment10 = new Comment("Name 10", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment11 = new Comment("Name 11", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment12 = new Comment("Name 12", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment13 = new Comment("Name 13", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment14 = new Comment("Name 14", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment15 = new Comment("Name 15", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");
        Comment comment16 = new Comment("Name 16", "Lorem ipsum dolor sit amet consectetur adipiscing elit. Consectetur adipiscing elit quisque faucibus ex sapien vitae. Ex sapien vitae pellentesque sem placerat in id. Placerat in id cursus mi pretium tellus duis. Pretium tellus duis convallis tempus leo eu aenean.");

        List<Comment> comments1 = new List<Comment>();
        List<Comment> comments2 = new List<Comment>();
        List<Comment> comments3 = new List<Comment>();
        List<Comment> comments4 = new List<Comment>();

        comments1.Add(comment1);
        comments1.Add(comment5);
        comments1.Add(comment9);
        comments1.Add(comment13);

        comments2.Add(comment2);
        comments2.Add(comment6);
        comments2.Add(comment10);
        comments2.Add(comment14);

        comments3.Add(comment3);
        comments3.Add(comment7);
        comments3.Add(comment11);
        comments3.Add(comment15);

        comments4.Add(comment4);
        comments4.Add(comment8);
        comments4.Add(comment12);
        comments4.Add(comment16);

        Video video1 = new Video("Title 1", "Author 1", 50, comments1);
        Video video2 = new Video("Title 2", "Author 2", 600, comments2);
        Video video3 = new Video("Title 3", "Author 3", 125, comments3);
        Video video4 = new Video("Title 4", "Author 4", 1500, comments4);

        Console.WriteLine(video1.GetDisplayText());
        Console.WriteLine(video2.GetDisplayText());
        Console.WriteLine(video3.GetDisplayText());
        Console.WriteLine(video4.GetDisplayText());
    }
}