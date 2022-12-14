using System;

namespace Practice1
{
    class Director
    {
        


        private List<Video> _videos = new List<Video>();
    
        public void AddVideo(Video libraryVideo)
        {
            _videos.Add(libraryVideo);
        }
            
            
        public void CreateVideos()        
        {      
            Video video1 = new Video();
            video1._title = "How to Change a Tire";
            video1._author = "John Fell";
            video1._length = "1200 seconds";
            AddVideo(video1);
            
            Comment comment1 = new Comment();
            comment1._commenter = "Henry Fell";
            comment1._comment = "I loved learning how to change a tire!";
            video1.AddComment(comment1);

            Comment comment2 = new Comment();
            comment2._commenter = "Paul Weadon";
            comment2._comment = "Changing a tire has never looked so easy!";
            video1.AddComment(comment2);

            Comment comment3 = new Comment();
            comment3._commenter = "Bud Driver";
            comment3._comment = "I couldn't have made a more descriptive video. Excellent work!";
            video1.AddComment(comment3);
        
            Video video2 = new Video();
            video2._title = "How to Read a Bedtime Story";
            video2._author = "Lisa Fell";
            video2._length = "1000 seconds";
            AddVideo(video2);

            Comment comment4 = new Comment();
            comment4._commenter = "Blair Fell";
            comment4._comment = "I love learning how to read bedtime stories!";
            video2.AddComment(comment4);

            Comment comment5 = new Comment();
            comment5._commenter = "Ethan Weadon";
            comment5._comment = "Reading bedtime stories is my favorite!";
            video2.AddComment(comment5);
            
            Comment comment6 = new Comment();
            comment6._commenter = "Grant Ashford";
            comment6._comment = "My go-to video for learning about reading stories.";
            video2.AddComment(comment6);

            Video video3 = new Video();
            video3._title = "How to Draw a Dragon";
            video3._author = "Zoey Fell";
            video3._length = "1200 seconds";
            AddVideo(video3);


            Comment comment7 = new Comment();
            comment7._commenter = "Junior Smith";
            comment7._comment = "My dragon drawing has improved immensly from watching Zoey's videos";
            video3.AddComment(comment7);

            Comment comment8 = new Comment();
            comment8._commenter = "Jennifer Parker";
            comment8._comment = "I never knew how much I would enjoy drawing dragons!";
            video3.AddComment(comment8);

            Comment comment9 = new Comment();
            comment9._commenter = "Bilbo Baggins";
            comment9._comment = "Learn to draw dragons like Zoey. They are extremely authentic!";
            video3.AddComment(comment9);
    }


        
        //displays the title, author, length, number of comments
        //(from the method) and then list out all of the comments for that video
        
        public void DisplayDetails()
        {
            foreach (Video video in _videos)
            {
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length}");
                Console.WriteLine($"Comments: {video.GetNumberofComments()}");
                Console.WriteLine("**************************");

                foreach (Comment comment in video._comments)
                {
                    Console.WriteLine($"{comment._commenter}");
                    Console.WriteLine($"{comment._comment}");
                    Console.WriteLine("************************");
                }



            }
        }
    }
}