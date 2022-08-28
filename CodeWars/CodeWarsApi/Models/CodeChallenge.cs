namespace CodeWarsApi.Models
{
    public class CodeChallenge
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string[] tags { get; set; }
        public string[] languages { get; set; }
        public Rank rank { get; set; }
        public User createdBy { get; set; }
        public string publishedAt { get; set; }
        public User approvedBy { get; set; }
        public string approvedAt { get; set; }
        public int totalCompleted { get; set; }
        public int totalAttempts { get; set; }
        public int totalStars { get; set; }
        public int voteScore { get; set; }
        public bool contributorsWanted { get; set; }
        public Unresolved unresolved { get; set; }
    }
}
