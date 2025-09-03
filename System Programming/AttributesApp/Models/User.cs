namespace AttributesApp.Models;

using AttributesApp.Attributes;
using System.Text.Json.Serialization;

class User
{
    [Tabs(2)]
    [JsonPropertyName("firstname")]
    [JsonPropertyOrder(2)]
    public string Name { get; set; }

    [JsonPropertyOrder(3)]
    [Tabs(1)]
    public string Surname { get; set; }

    [JsonPropertyOrder(1)]
    public DateTime? BirthDate { get; set; }

    [JsonPropertyOrder(0)]
    public bool? IsMarried { get; set; }

    public User(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
}
