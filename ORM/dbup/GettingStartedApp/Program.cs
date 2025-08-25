// dotnet add package dbup

using System.Reflection;
using DbUp;
using DbUp.Engine;

const string connectionString = "Server=localhost;Database=MyMigrationsDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

UpgradeEngine upgrader = DeployChanges.To
    .SqlDatabase(connectionString)
    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
    .LogToConsole()
    .Build();

DatabaseUpgradeResult result = upgrader.PerformUpgrade();

System.Console.WriteLine();