namespace InheritanceApp.Models;

class Car : Vehicle
{
    public int WheelsCount { get; set; } = 4;

    public Car(string name, int maxSpeed = 0) : base(name, maxSpeed)
    {
        //base.Name = name;
    }

    public Car() : base("UNKNOWN CAR", maxSpeed: 0) { }
}