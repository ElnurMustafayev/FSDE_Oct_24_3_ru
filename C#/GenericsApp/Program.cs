//void ShowValue<T1, T2>(T1 obj)
//{
//    Console.WriteLine("- - - - - - - - - - - -");
//    Console.WriteLine(typeof(T2));
//    Console.WriteLine($"value: {obj}");
//    Console.WriteLine("- - - - - - - - - - - -");
//}

//ShowValue<int, bool>(777);
//ShowValue<int, char[]>('a');
//ShowValue<bool, int>(true);
//ShowValue<int[], Random>(new int[3]{ 1,2,3 });





//T Plus<T>(T num1, T num2)
//{
//    //T num3 = 123;
//    //return num1 + num2;
//}



//void ShowArray(int[] nums) {
//    Console.WriteLine($"Array of '{typeof(int)}' type: ");
//    for (int i = 0; i < nums.Length; i++)
//    {
//        Console.WriteLine($"[{i + 1}]: {nums[i]}");
//    }
//}

//void ShowArray<T>(T[] nums)
//{
//    if (typeof(T) == typeof(bool))
//        return;

//    //Console.WriteLine($"Array of '{typeof(T)}' type: ");
//    for (int i = 0; i < nums.Length; i++)
//    {
//        Console.WriteLine($"[{i + 1}]: {nums[i]}");
//    }
//}

//ShowArray(new int[] { 1 });
//ShowArray(new bool[] { true });
//ShowArray(new string[] { "one" });






using GenericsApp;
using GenericsApp.Models;
using GenericsApp.Models.Base;

//MyClass<string, int> obj = new MyClass<string, int>();

//obj.MyProperty = "Bob";
//Console.WriteLine(obj.MyProperty);
//obj.GetInfo(555);

UserBase student = new UserBase("Bob", DateTime.Now.AddYears(-30));
MyClass<int, bool, Random>.ShowUserInfo(student);
//MyClass<int, bool, Random>.ShowUserInfo(Random.Shared);