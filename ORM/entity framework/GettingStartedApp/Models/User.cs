namespace GettingStartedApp.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime? BirthDate { get; set; }
}