using Dapper;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=master;User Id=admin;Password=admin;TrustServerCertificate=True;";


void DoSomeWork()
{
    var text = File.ReadAllText("temp.txt");

    SqlConnection connection = new SqlConnection(connectionString);

    connection.Open();

    dynamic result = connection.QueryFirst($"select @text", new { text });

    Console.WriteLine($"Result from sql: {result}");
}

Task DoSomeWorkWithTask()
{
    return Task.Run(() =>
    {
        var text = File.ReadAllText("temp.txt");

        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

        dynamic result = connection.QueryFirst($"select @text", new { text });

        Console.WriteLine($"Result from sql: {result}");
    });
}

async Task DoSomeWorkAsync()
{
    Thread.Sleep(1000);
    Console.WriteLine("async method started...");

    var text = await File.ReadAllTextAsync("temp.txt");

    using SqlConnection connection = new SqlConnection(connectionString);

    await connection.OpenAsync();

    dynamic result = await connection.QueryFirstAsync($"select @text", new { text });

    Console.WriteLine($"Result from sql: {result}");
}

async Task<string> GetTextFromFileAsync()
{
    var text = await File.ReadAllTextAsync("temp.txt");

    return text;
}

/*
async Task Test()
{
    await Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Internal Task");
    });
}
*/

Console.WriteLine("Start");
//_ = Test();
//DoSomeWork();
//DoSomeWorkWithTask();
_ = DoSomeWorkAsync();
//var text = await GetTextFromFileAsync();
Console.WriteLine("End");

Console.ReadKey();







/*
Task<string> GetNameAsync()
{
    return Task.Run(() =>
    {
        return "Bob";
    });
}

//var name = GetNameAsync().Result;

var name = await GetNameAsync();

Console.WriteLine(name);
*/