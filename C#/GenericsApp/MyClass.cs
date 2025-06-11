namespace GenericsApp;

using GenericsApp.Models.Base;

class MyClass<T1, T2, T3> where T3 : class
{
    public T1 MyProperty { get; set; }

    public void GetInfo(T2 obj)
    {
        Console.WriteLine($"Type: '{typeof(T2)}'");
        Console.WriteLine($"Value: '{obj}'");
    }

    public static void ShowUserInfo<T4>(T4 user) where T4 : UserBase
    {
        Console.WriteLine(user.Name);
        Console.WriteLine(user.BirthDate);
    }
}
