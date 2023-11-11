using System.ComponentModel.DataAnnotations;

namespace BlogApp.Server.Entities;

public class AppUser : IEntity
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Bio { get; set; }
    
    [Range(0, 120)]
    public int Age { get; set; }
}