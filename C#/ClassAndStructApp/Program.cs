//using ClassAndStructApp.Models;

//MyClass obj1 = new MyClass();
//obj1.Num = 500;
//Console.WriteLine($"Num: {obj1.Num}");

//MyClass obj2 = obj1;
//Console.WriteLine($"Num: {obj1.Num}");
//obj2.Num = 777;
//Console.WriteLine($"Num: {obj1.Num}");



//MyStruct obj1 = new MyStruct();
//obj1.Num = 500;
//Console.WriteLine($"Num: {obj1.Num}");

//MyStruct obj2 = obj1;
//Console.WriteLine($"Num: {obj1.Num}");
//obj2.Num = 777;
//Console.WriteLine($"Num: {obj1.Num}");



//MyStruct obj1 = new MyStruct();
//obj1.Flags = [
//    true, false, true
//];

//MyStruct obj2 = obj1;

//obj2.Flags[0] = !obj2.Flags[0];
//Console.WriteLine();




//DateTime dateTime = new DateTime();
//dateTime = new DateTime(2025, month: 06, day: 11);
//DateTime changedDateTime = dateTime.AddDays(2);
//Console.WriteLine(changedDateTime);

//DateTime dateTime = DateTime.Now.AddHours(-4);
DateTime dateTime = DateTime.UtcNow;
Console.WriteLine(dateTime);
Console.WriteLine(DateTime.UtcNow);