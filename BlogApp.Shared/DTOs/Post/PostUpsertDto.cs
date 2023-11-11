namespace BlogApp.Shared.DTOs.Post;

public class PostUpsertDto
{
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required DateTime CreatedAt { get; set; }
    public int AppUserId { get; set; }
    public int CategoryId { get; set; }
}