namespace PersonelResume.Models
{
    public class Experience
    {
        public required string Duration { get; set; }
        public required string Company { get; set; }
        public required string Role { get; set; }
        public required string Description { get; set; }
    }
}