namespace BlogApp.Shared.DTOs.AppUser;

public class AppUserReadOnlyDto
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Bio { get; set; }
    public int Age { get; set; }
}