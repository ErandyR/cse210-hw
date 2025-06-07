

public class VideoLibrary
{
    private List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public List<Video> GetAllVideos()
    {
        return _videos;
    }
}