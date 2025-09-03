//var user = new User("Bob");

//var userJson = JsonSerializer.Serialize(user, new JsonSerializerOptions
//{
//    WriteIndented = true
//});

//Console.WriteLine(userJson);



//User user = new User("Bob");

//// get metadata from object
//Type typeFromObject = user.GetType();

//// get metadata from type
//Type typeFromType = typeof(User);

//Console.WriteLine();

//var user = new User("Ann");


/*
{
    "Name": "Bob"
    "BirthDate": null
}
*/

//PropertyInfo[] properties = typeof(User)
//    .GetProperties();

//Console.WriteLine("{");
//foreach (var property in properties)
//{
//    var propValue = property.GetValue(user);
//    Console.WriteLine($"\t\"{property.Name}\": {propValue ?? "null"}");

//    //Console.WriteLine($"{property.PropertyType.FullName} {property.Name}");
//}
//Console.WriteLine("}");




/*
void ListMembers<T>(T obj)
{
    var type = typeof(T);

    var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

    foreach (var field in fields)
    {
        var fieldValue = field.GetValue(obj);
        Console.WriteLine($"\"{field.Name}\": <{fieldValue}>");
    }

    var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

    foreach (var property in properties)
    {
        var propertyValue = property.GetValue(obj);
        Console.WriteLine($"\"{property.Name}\": <{propertyValue}>");
    }
}

MyClass obj = new MyClass(222.22)
{
    Field1 = 100,
    Property1 = true,
};
MyClass.Field2 = "200str";

ListMembers(obj);
Console.WriteLine();

User user = new User("Bob");

ListMembers(user);
*/



/*
const string printAllMethodName = "PrintAll";

var obj = new MyClass(15.3);

var printMethod = typeof(MyClass)
    .GetMethod(printAllMethodName);
//.GetMethods()
//.First(method => method.Name == "PrintAll");

if (printMethod is null)
{
    Console.WriteLine($"{printAllMethodName} not found");
    return;
}

var result = printMethod.Invoke(obj, null);

Console.WriteLine(printMethod);
*/


using ReflectionApp.Models;

var staticMethodInfo = typeof(MyClass)
    .GetMethod(nameof(MyClass.Sum));

if (staticMethodInfo is null)
{
    throw new Exception($"Method {nameof(MyClass.Sum)} not found!");
}

var result = staticMethodInfo.Invoke(null, new object[] { 5, 2.5 });

Console.WriteLine(result);