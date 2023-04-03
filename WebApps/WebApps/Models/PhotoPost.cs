namespace WebApps.Models
{
    public class PhotoPost : Post
    {
        public string imageURL { get; set; }
        public string caption { get; set; }

        public PhotoPost(string title, string author, string imageURL, string caption)
        {
            id = posts.Count + 1;
            title = title;
            author = author;
            dateTime = DateTime.Now;
            likes = 0;
            imageURL = imageURL;
            caption = caption;
        }

        public static void AddPhotoPost(string title, string author, string imageURL, string caption)
        {
            PhotoPost photoPost = new PhotoPost(title, author, imageURL, caption);
            posts.Add(photoPost);
        }
    }
}
