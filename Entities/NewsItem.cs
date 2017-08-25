using System;

namespace NewsTicker.Entities
{
    public class NewsItem
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Payload { get; set; }
        public string Category { get; set; }
    }
}