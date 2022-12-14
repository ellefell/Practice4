using System.Linq;
namespace Practice1
{
    //Video class has the responsibility to track the title, author, and length (in seconds) of the video.
    public class Video
    {
        public string _title;
        public string _author;
        public string _length;

        //stores a list of comments 
        public List<Comment> _comments = new List<Comment>();

        public void AddComment(Comment inputComment)
        {
            _comments.Add(inputComment);
        }


    

        //A method to return the number of comments
        public int GetNumberofComments()
        {
            return _comments.Count;
        }

    }
}