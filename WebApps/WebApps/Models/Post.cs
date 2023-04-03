namespace WebApps.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime dateTime { get; set; }
        public int likes { get; set; }

        public static List<Post> posts = new List<Post>();

        public static void AddPost(Post post)
        {
            posts.Add(post);
        }
    }
}
