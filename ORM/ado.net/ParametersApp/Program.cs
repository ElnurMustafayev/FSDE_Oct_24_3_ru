using Microsoft.Data.SqlClient;
using ParametersApp.Models;

const string connectionString = "Server=localhost;Database=UsersDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

User? GetUserByEmail(string email)
{
    using var connection = new SqlConnection(connectionString);

    connection.Open();

    var command = connection.CreateCommand();
    //command.CommandText = $"select * from Users where Email = N'{email}'"; // <--- SQL Injection

    command.CommandText = $"select * from Users where Email = @emailToSearch";
    command.Parameters.Add(new SqlParameter("emailToSearch", value: email));

    var reader = command.ExecuteReader();

    if (reader.Read() == false)
    {
        return null;
    }

    var foundUser = new User
    {
        Id = reader.GetInt32(0),
        FirstName = reader.GetString(1),
        LastName = reader.GetString(2),
        Email = reader.GetString(3),
    };

    if (reader.IsDBNull(4) == false)
    {
        foundUser.DateOfBirth = reader.GetDateTime(4);
    }

    return foundUser;
}

while (true)
{
    Console.Clear();
    Console.Write("Input email for search: ");
    var emailForSearch = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(emailForSearch))
    {
        System.Console.WriteLine($"Incorrect input: '{emailForSearch}'");
        System.Console.WriteLine("Press any key to try again...");

        Console.ReadKey(true);
        continue;
    }

    var foundUser = GetUserByEmail(emailForSearch);

    if (foundUser is null)
    {
        System.Console.WriteLine($"User not found by email: '{emailForSearch}'");
        System.Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);
        continue;
    }

    System.Console.WriteLine(foundUser);
    System.Console.WriteLine("Press any key to continue...");

    Console.ReadKey(true);
}