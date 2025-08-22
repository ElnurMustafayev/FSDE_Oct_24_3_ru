using System.Text.Json.Serialization;

namespace GettingStartedApp.Models;

public class User
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public override string ToString()
    {
        return $"{Id}: {FirstName} {LastName} ({Email}), Born: {DateOfBirth:yyyy-MM-dd}";
    }
}