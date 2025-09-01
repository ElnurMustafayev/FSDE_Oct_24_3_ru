using System.Text.Json.Serialization;

namespace ReflectionApp.Models;

class User
{
    public readonly Guid Id;

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("birth_date")]
    public DateTime? BirthDate { get; set; }

    public User(string name)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
    }
}