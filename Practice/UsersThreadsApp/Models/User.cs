namespace UsersThreadsApp.Models;

class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public User(string firstName, string lastName, string email)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
    }

    public User()
    {
        this.FirstName = string.Empty;
        this.LastName = string.Empty;
        this.Email = string.Empty;
    }

    public override string ToString()
    {
        return $@"{nameof(Id)}: {Id}
{nameof(FirstName)}: {FirstName}
{nameof(LastName)}: {LastName}
{nameof(Email)}: {Email}
{nameof(DateOfBirth)}: {DateOfBirth}";
    }
}