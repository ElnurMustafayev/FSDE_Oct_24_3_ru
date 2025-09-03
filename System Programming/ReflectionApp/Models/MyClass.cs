namespace ReflectionApp.Models;

class MyClass
{
    public int Field1;
    public static string Field2;

    public bool Property1 { get; set; }
    private double property2 { get; set; }

    public MyClass(double privateProperty)
    {
        this.property2 = privateProperty;
    }

    public void PrintAll()
    {
        Console.WriteLine($"1. {this.Field1}");
        Console.WriteLine($"2. {MyClass.Field2}");
        Console.WriteLine($"3. {this.Property1}");
        Console.WriteLine($"4. {this.property2}");
    }

    public static double Sum(double num1, double num2)
    {
        return num1 + num2;
    }
}