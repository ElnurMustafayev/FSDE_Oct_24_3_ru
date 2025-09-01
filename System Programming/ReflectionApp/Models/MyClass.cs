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
}