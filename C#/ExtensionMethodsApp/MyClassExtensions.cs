namespace ExtensionMethodsApp;

public static class MyClassExtensions
{
    public static int GetAsNumber(this MyClass obj)
    {
        int result = obj.Number + obj.Text.Length + Convert.ToInt32(obj.Flag);

        return result;
    }
}