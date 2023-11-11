using System.ComponentModel.DataAnnotations;

namespace BlogApp.Shared.DTOs.AppUser;

public class AppUserUpsertDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Bio { get; set; }
    
    [Range(0, 120)]
    public int Age { get; set; }
}
