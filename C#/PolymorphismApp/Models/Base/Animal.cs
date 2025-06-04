namespace PolymorphismApp.Models.Base;

public abstract class Animal
{
    public string Name { get; private set; }

    public Animal(string name)
    {
        this.Name = name;
    }

    public void Show()
    {
        System.Console.WriteLine($"Name: \"{this.Name}\"");
    }

    //public virtual void Say() { }
    public abstract void Say();
}