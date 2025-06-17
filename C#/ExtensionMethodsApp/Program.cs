using ExtensionMethodsApp;

string name = "bob";
string capitalizedName = name.Capitalize();

System.Console.WriteLine(capitalizedName);
//StringExtensions.Capitalize(name);

System.Console.WriteLine($"name: {name.IsCapitalized()}");
System.Console.WriteLine($"capitalizedName: {capitalizedName.IsCapitalized()}");

MyClass obj = new MyClass()
{
    Flag = true,
    Number = 10,
    Text = "test",
};
//obj.Text = "test";
//obj.Number = 10;
//obj.Flag = true;
int objectAsNumber = obj.GetAsNumber();
Console.WriteLine(objectAsNumber);