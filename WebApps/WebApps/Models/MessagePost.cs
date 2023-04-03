using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    public class MessagePost : Post
    {
        [Required, StringLength(500)]
        public string? message { get; set; }

        public MessagePost(string title, string author, string message)
        {
            id = posts.Count + 1;
            title = title;
            author = author;
            dateTime = DateTime.Now;
            likes = 0;
            message = message;
        }

        public static void AddMessagePost(string title, string author, string message)
        {
            MessagePost messagePost = new MessagePost(title, author, message);
            posts.Add(messagePost);
        }
    }
}
