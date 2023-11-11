namespace BlogApp.Server.Entities;

public class Category : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
}