namespace InheritanceApp.Models;

class Vehicle
{
    private int maxSpeed = 0;
    public string Name { get; set; }
    public int MaxSpeed
    {
        get => this.maxSpeed;
        set
        {
            if (value >= 0)
            {
                this.maxSpeed = value;
            }
        }
    }

    public Vehicle(string name, int maxSpeed)
    {
        this.Name = name;
        this.MaxSpeed = maxSpeed;
    }

    public void Move()
    {
        Console.WriteLine("???");
    }

    protected void Boom() => Console.WriteLine("B-O-O-M");
}