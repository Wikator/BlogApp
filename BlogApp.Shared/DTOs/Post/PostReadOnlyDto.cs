using BlogApp.Shared.DTOs.AppUser;
using BlogApp.Shared.DTOs.Category;

namespace BlogApp.Shared.DTOs.Post;

public class PostReadOnlyDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required AppUserReadOnlyDto AppUser { get; set; }
    public required CategoryReadOnlyDto Category { get; set; }
}