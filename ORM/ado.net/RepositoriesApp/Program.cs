using RepositoriesApp.Entities;
using RepositoriesApp.Repositories;

var repository = new EmployeeSqlRepository();

repository.Create(new Employee
{
    Id = default,
    FirstName = "Test",
    LastName = "123456789012345678901234567890123456789012345678901234567890",
});

//var foundEmployee = repository.SearchById(5);

//if(foundEmployee != null)
//{
//    for (int i = 0; i < 1500; i++)
//    {
//        repository.Create(foundEmployee);
//    }
//}