// 1. dotnet add package Microsoft.EntityFrameworkCore --version 9.0.8
// 2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.8
// 3. dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.8
// 4. dotnet tool install --global dotnet-ef
// 5. dotnet-ef migrations add "Init Project"
// 6. dotnet-ef database update

using GettingStartedApp.Data;
using GettingStartedApp.Models;

var dbContext = new MyDbContext();

var users = new List<User>
{
    new User() {
        Name = "Bob",
        BirthDate = new DateTime(1964, 2, 16)
    },
    new User() {
        Name = "Ann",
        BirthDate = new DateTime(2000, 2, 2)
    },
    new User() {
        Name = "John",
        BirthDate = new DateTime(1994, 12, 12)
    }
};

dbContext.Users.AddRange(users);