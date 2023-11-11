namespace BlogApp.Server.Entities;

public class Post : IEntity
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required DateTime CreatedAt { get; set; }
    
    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
