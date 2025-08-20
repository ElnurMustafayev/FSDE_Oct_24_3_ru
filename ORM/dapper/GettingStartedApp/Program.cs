using GettingStartedApp.Models;
using Microsoft.Data.SqlClient;
using Dapper;

const string connectionString = "Server=localhost;Database=UsersDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();

var users = connection.Query<User>("select * from Users where IsActive = true");

foreach (var user in users)
{
    Console.WriteLine($"{user.FirstName} {user.LastName}");
}

connection.QueryFirstOrDefault<User>("select * from Users where Id = 123");
connection.ExecuteScalar<long>("select 10");
var affectedRowsCount = connection.Execute("delete from Users where Id % 2 = 1");
//connection.Execute("exec myproc");

// using var command = new SqlCommand("select * from Users", connection);

// var reader = command.ExecuteReader();

// if (reader.Read() == false)
// {
//     return;
// }

// var foundUser = new User
// {
//     Id = reader.GetInt32(0),
//     FirstName = reader.GetString(1),
//     LastName = reader.GetString(2),
//     Email = reader.GetString(3),
// };

// System.Console.WriteLine(foundUser);