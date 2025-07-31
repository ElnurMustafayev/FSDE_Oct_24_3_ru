namespace RepositoriesApp.Entities;

class Employee
{
    public required int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public override string ToString() => $"{Id}: {FirstName} {LastName}";
}