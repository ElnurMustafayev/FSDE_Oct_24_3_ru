// dotnet add package Microsoft.Data.SqlClient --version 6.1.0
using GettingStartedApp.Entities;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=StudentsDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

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
            CountryId = reader.GetValue(3),
            GroupId = reader.GetValue(4),
        };

        students.Add(student);
    }

    return students;
}

List<StudentDetailed> GetAllDetailedStudents()
{
    SqlConnection connection = new SqlConnection(connectionString);

    connection.Open();

    SqlCommand command = connection.CreateCommand();

    command.CommandText =   @"select *
                            from Students s
                            full join Countries c on s.CountryId = c.Id
                            full join Groups g on s.GroupId = g.Id";

    var reader = command.ExecuteReader();

    List<StudentDetailed> students = new List<StudentDetailed>();

    while(reader.Read())
    {
        var student = new StudentDetailed
        {
            Id = reader.GetInt32(0),
            Fullname = reader.GetString(1),
            BirthDate = reader.GetDateTime(2),

            //Country = new Country
            //{
            //    Id = reader.IsDBNull(5) == false ? reader.GetInt32(5) : -1,
            //    Name = reader.IsDBNull(6) == false ? reader.GetString(6) : "UNKNOWN",
            //},
            
            //Group = new Group
            //{
            //    Id = reader.IsDBNull(7) == false ? reader.GetInt32(7) : -1,
            //    Name = reader.IsDBNull(8) == false ? reader.GetString(8) : "UNKNOWN",
            //}
        };

        if (reader.IsDBNull(3) == false)
        {
            student.Country = new Country
            {
                Id = reader.GetInt32(5),
                Name = reader.GetString(6),
            };
        }

        if (reader.IsDBNull(4) == false)
        {
            student.Group = new Group
            {
                Id = reader.GetInt32(7),
                Name = reader.GetString(8),
            };
        }

        students.Add(student);
    }

    return students;
}

var students = GetAllDetailedStudents();

students.ForEach(student => Console.WriteLine(student));