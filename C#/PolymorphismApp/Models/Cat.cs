namespace PolymorphismApp.Models;

using PolymorphismApp.Models.Base;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Say()
    {
        System.Console.WriteLine("meow");
    }
}