using Dapper;
using GettingStartedApp.Exceptions;
using GettingStartedApp.Models;
using Microsoft.Data.SqlClient;

void PrintDangerMessage(string message)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine(message);

    Console.ResetColor();
}

const string connectionString = "Server=localhost;Database=UsersDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();

while(true)
{
    try
    {
        Console.Clear();
        Console.Write("Input user's id to delete: ");
        var idToDeleteStr = Console.ReadLine();

        if(int.TryParse(idToDeleteStr, out int idToDelete) == false)
        {
            throw new ArgumentException("Invalid Id input!", paramName: "id");
        }

        var foundUser = connection.QueryFirstOrDefault<User>(
            sql:    $@"select * from Users
                    where Id = @IdToDelete",
            param: new 
            {
                IdToDelete = idToDelete
            })
            ?? throw new NotFoundException(entityName: nameof(User));

        Console.WriteLine(foundUser);

        PrintDangerMessage(@$"Attention!!!
You want to delete user '{foundUser.Email}'!
Please input user's {nameof(foundUser.FirstName)} below:");

        var confirmFirstNameForDelete = Console.ReadLine();

        if(confirmFirstNameForDelete != foundUser.FirstName)
        {
            throw new ArgumentException("Invalid CAPTCHA input!", paramName: "confirm user FirstName");
        }

        var deletedItemsCount = connection.Execute(
            sql:    $@"delete from Users
                    where Id = @IdToDelete",
            param: new
            {
                IdToDelete = idToDelete
            });

        if(deletedItemsCount != 1)
        {
            throw new Exception(@$"Something went wrong in deletion...
Affected rows count: {deletedItemsCount}");
        }

        Console.WriteLine($"User '{foundUser.Email}' deleted successfully!");
        Console.ReadKey();
    }
    catch(NotFoundException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadKey();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"{ex.ParamName}: {ex.Message}");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Critical Error!!!");
        Console.WriteLine($"Error: {ex.ToString()}");
        Console.ReadKey();
    }
}