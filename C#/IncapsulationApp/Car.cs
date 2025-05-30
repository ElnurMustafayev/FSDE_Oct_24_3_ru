namespace IncapsulationApp;

class Car
{
    public const string DEFAULT_NAME = "UNKNOWN";

    private string name;
    private int maxSpeed;

    public string GetName() => this.name;

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Car name can not be empty!", nameof(this.name));
        }
        this.name = name;
    }

    public int GetMaxSpeed() => this.maxSpeed;

    public void SetMaxSpeed(int maxSpeed)
    {
        if (maxSpeed < 0)
        {
            throw new ArgumentException("Max speed can not be less than 0!", nameof(this.maxSpeed));
        }
        this.maxSpeed = maxSpeed;
    }

    public Car()
    {
        this.SetName(DEFAULT_NAME);
        this.SetMaxSpeed(default);
    }

    public Car(string name, int maxSpeed)
    {
        this.SetName(name);
        this.SetMaxSpeed(maxSpeed);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {this.GetName()}");
        Console.WriteLine($"MaxSpeed: {this.GetMaxSpeed()}");
    }
}

//namespace TestNs
//{
//    class Car
//    {
//        public string Name;
//        public int MaxSpeed;
//    }
//}