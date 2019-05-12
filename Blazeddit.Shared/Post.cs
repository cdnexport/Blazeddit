namespace Blazeddit.Shared
{
    public class Post
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public string Permalink { get; set; }

        public long NumComments { get; set; }

        public Comment[] Comments { get; set; }
    }
}