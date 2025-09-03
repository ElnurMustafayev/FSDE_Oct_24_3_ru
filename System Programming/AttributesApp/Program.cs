/*
var users = new User[]
{
    new User("Bob", "Marley")
    {
        BirthDate = new DateTime(1983, 10, 5),
        IsMarried = false,
    },
    new User("Ann", "Brown")
};

var usersJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
{
    WriteIndented = true
});
Console.WriteLine(usersJson);
*/

using AttributesApp.Attributes;
using AttributesApp.Models;

void MyPrinter<T>(T obj)
{
    var properties = typeof(T)
        .GetProperties();

    foreach (var property in properties)
    {
        int tabsCount = 0;

        var tabsAttributeInfo = property.CustomAttributes
            .FirstOrDefault(attribute => attribute.AttributeType == typeof(TabsAttribute));

        if (tabsAttributeInfo is not null)
        {
            if (tabsAttributeInfo.ConstructorArguments.Any() == true
                && tabsAttributeInfo.ConstructorArguments[0].Value is int tabsCountValue)
                tabsCount = tabsCountValue;
        }

        string text = $"{property.Name}: {property.GetValue(obj)}";

        Console.WriteLine(text.PadLeft(text.Length + tabsCount, '\t'));
    }
}

var user = new User("Bob", "Marley")
{
    BirthDate = new DateTime(1983, 10, 5),
    IsMarried = false,
};

MyPrinter(user);