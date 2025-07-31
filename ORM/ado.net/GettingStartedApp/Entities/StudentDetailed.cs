using System.Diagnostics.Metrics;

namespace GettingStartedApp.Entities;

class StudentDetailed
{
    public required int Id { get; set; }
    public required string Fullname { get; set; }
    public required DateTime BirthDate { get; set; }
    public Country? Country { get; set; }
    public Group? Group { get; set; }

    public override string ToString()
    {
        return $"Student Info:\n" +
               $"- ID: {Id}\n" +
               $"- Full Name: {Fullname}\n" +
               $"- Birth Date: {BirthDate}\n" +
               $"- Country: {Country}\n" +
               $"- Group: {Group}";
    }
}