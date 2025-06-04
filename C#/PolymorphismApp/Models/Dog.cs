namespace PolymorphismApp.Models;

using PolymorphismApp.Models.Base;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void Say()
    {
        int hufCount = Random.Shared.Next(3, 10);

        for (int i = 0; i < hufCount; i++)
        {
            System.Console.Write("huf\t");
        }
        System.Console.WriteLine();
    }
}