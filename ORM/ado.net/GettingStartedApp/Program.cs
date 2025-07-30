// dotnet add package Microsoft.Data.SqlClient --version 6.1.0
using GettingStartedApp.Entities;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=ExamDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

/*
SqlConnection connection = new SqlConnection(connectionString);

connection.Open();

var command = new SqlCommand("select count(*) from Students", connection);

var result = command.ExecuteScalar();

System.Console.WriteLine(result);
*/


List<Student> GetAllStudents()
{
    SqlConnection connection = new SqlConnection(connectionString);

    connection.Open();

    SqlCommand command = connection.CreateCommand();

    command.CommandText = "select * from Students";

    var reader = command.ExecuteReader();

    var students = new List<Student>();

    while (reader.Read())
    {
        var student = new Student()
        {
            Id = reader.GetInt32(0),
            Fullname = reader.GetString(1),
            BirthDate = reader.GetDateTime(2),
            CountryId = (int?)reader.GetValue(3),
            GroupId = (int?)reader.GetValue(4),
        };

        students.Add(student);
    }

    return students;
}

var students = GetAllStudents();

students.ForEach(student => Console.WriteLine(student));