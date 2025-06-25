namespace NullableApp.Models;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname => $"{Name} {Surname}";
    public DateTime? BirthDate { get; set; }
    public bool? IsMarried { get; set; }

    public Person(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"Fullname: {Fullname}");
        if (BirthDate.HasValue)
        {
            System.Console.WriteLine($"Birth date: {BirthDate.Value.ToShortDateString()}");
        }
        if (IsMarried.HasValue)
        {
            System.Console.WriteLine($"Married: {(IsMarried.Value ? "yes" : "no")}");
        }
    }
}