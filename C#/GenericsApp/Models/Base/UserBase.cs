namespace GenericsApp.Models.Base;

class UserBase
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public UserBase(string name, DateTime birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }
}