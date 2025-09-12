using Dapper;
using Microsoft.Data.SqlClient;
using UsersThreadsApp.Models;

namespace UsersThreadsApp.Repositories;

class UserRepository
{
    public Task<User?> GetOldest()
    {
        return Task.Run(() =>
        {
            const string connectionString = "Server=localhost;Database=UsersDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var sqlQuery = @"select top 1 *
					        from Users
					        where DateOfBirth = (select min(u.DateOfBirth)
										        from Users u)";

            var oldestUser = connection.QueryFirstOrDefault<User>(sqlQuery);

            return oldestUser;
        });
    }

    public Task<IEnumerable<User>> GetAll()
    {
        return Task.Run(() =>
        {
            const string connectionString = "Server=localhost;Database=UsersDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var sqlQuery = @"select * from Users";

            var allUsers = connection.Query<User>(sqlQuery);

            return allUsers;
        });
    }
}
