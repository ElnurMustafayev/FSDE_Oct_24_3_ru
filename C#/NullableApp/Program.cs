//// value types
//DateTime? dateTime = new DateTime(1964, 10, 20);

//if(dateTime.HasValue)
//{
//    Console.WriteLine(dateTime.Value.AddYears(100));
//}




//// reference types
// void MyMethod(string text)
// {
//     System.Console.WriteLine(text.ToUpper());
// }

// MyMethod("TEXT");
// MyMethod("null");




using NullableApp.Models;

Person person = new Person("Bob", "Marley")
{
    BirthDate = new DateTime(1964, 10, 20),
    IsMarried = null,
};

person.ShowInfo();