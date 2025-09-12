using UsersThreadsApp.Repositories;

var repository = new UserRepository();

var allUsersTask = repository.GetAll();

var userTask = repository.GetOldest();
Console.WriteLine("The oldest:");
Console.WriteLine(userTask.Result);
Console.WriteLine();

var allUsers = allUsersTask.Result;

foreach (var user in allUsers)
{
    Console.WriteLine(user);
}