namespace GettingStartedApp.Entities;

class Student
{
    public int Id { get; set; }
    public required string Fullname { get; set; }
    public required DateTime BirthDate { get; set; }
    public int? CountryId { get; set; }
    public int? GroupId { get; set; }

    public override string ToString()
    {
        return $"Student Info:\n" +
               $"- ID: {Id}\n" +
               $"- Full Name: {Fullname}\n" +
               $"- Birth Date: {BirthDate}\n" +
               $"- Country ID: {(CountryId.HasValue ? CountryId.Value.ToString() : "N/A")}\n" +
               $"- Group ID: {(GroupId.HasValue ? GroupId.Value.ToString() : "N/A")}";
    }
}