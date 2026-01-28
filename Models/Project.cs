namespace MikePortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Technologies { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}