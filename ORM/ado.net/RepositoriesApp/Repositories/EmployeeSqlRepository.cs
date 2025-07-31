namespace RepositoriesApp.Repositories;

using Microsoft.Data.SqlClient;
using RepositoriesApp.Entities;

class EmployeeSqlRepository
{
    private const string connectionString = "Server=localhost;Database=EmployeesDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
    private readonly SqlConnection connection;

    public EmployeeSqlRepository()
    {
        this.connection = new SqlConnection(connectionString);
        this.connection.Open();
    }

    public void Create(Employee employee)
    {
        int affectedRowsCount = new SqlCommand(
            cmdText:    $@"INSERT INTO Employees (FirstName, LastName)
                        VALUES (N'{employee.FirstName}', N'{employee.LastName}');",
            connection: this.connection)
            .ExecuteNonQuery();
    }

    public Employee? SearchById(int id)
    {
        var reader = new SqlCommand(
            cmdText:    $@"select top 1 *
                        from Employees
                        where Id = {id}",
            connection: this.connection)
            .ExecuteReader();

        var employeeIsFound = reader.Read();

        //if(employeeIsFound == false)
        //{
        //    throw new ArgumentException("Employee not found by id " + id);
        //}

        if (employeeIsFound == false)
        {
            reader.Close();
            return null;
        }

        var foundEmployee = new Employee
        {
            Id = reader.GetInt32(0),
            FirstName = reader.IsDBNull(1) == false ? reader.GetString(1) : null,
            LastName = reader.IsDBNull(2) == false ? reader.GetString(2) : null,
        };

        reader.Close();

        return foundEmployee;
    }

    public void Update(int id, Employee changedEmployee)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
