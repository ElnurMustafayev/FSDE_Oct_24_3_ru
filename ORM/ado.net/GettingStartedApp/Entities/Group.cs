namespace GettingStartedApp.Entities;

class Group
{
    public required int Id { get; set; }
    public required string Name { get; set; }

    public override string ToString() => $"#{Id} {Name}";
}