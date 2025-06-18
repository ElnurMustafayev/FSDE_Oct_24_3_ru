namespace ObjectApp.Models;

class Person
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        //Person newPerson = base.MemberwiseClone() as Person;
        return $"{this.Name}: {this.BirthDate.ToShortDateString()}";
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
        //return Name.Length + this.BirthDate.Year;
    }

    public override bool Equals(object? obj)
    {
        if(obj is not Person)
        {
            return false;
        }
        var anotherPerson = (Person)obj;

        return this.Name == anotherPerson.Name;
    }
}