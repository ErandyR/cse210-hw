


public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _videoLength;
    }

    public void AddComment(Comment comment)
    {

        _comments.Add(comment);
    }
    public int GetCommentCount()
    {

        return _comments.Count;
    }

    public List<Comment> GetAllComments()
    {
        return _comments;
    }
}