namespace IncapsulationApp;

class Car
{
    public const string DEFAULT_NAME = "UNKNOWN";

    private string name;
    private int maxSpeed;


    // Properties
    public int MaxSpeed
    {
        get
        {
            return this.maxSpeed;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Max speed can not be less than 0!", nameof(this.maxSpeed));
            }
            this.maxSpeed = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Car name can not be empty!", nameof(this.name));
            }
            this.name = value;
        }
    }

    public string Info
    {
        get
        {
            return $"{this.Name}: {this.MaxSpeed} km/h";
        }
    }

    public int MyProperty
    {
        get
        {
            Console.WriteLine("GETTER!");
            return 150;
        }
        set
        {
            Console.WriteLine($"Destination value: {value}");
        }
    }


    // Accessors
    /*
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
    */

    public Car()
    {
        this.Name = DEFAULT_NAME;
        this.MaxSpeed = default;
        //this.SetName(DEFAULT_NAME);
        //this.SetMaxSpeed(default);
    }

    public Car(string name, int maxSpeed)
    {
        this.Name = name;
        this.MaxSpeed = maxSpeed;
        //this.SetName(name);
        //this.SetMaxSpeed(maxSpeed);
    }

    public void ShowInfo()
    {
        //Console.WriteLine($"Name: {this.GetName()}");
        //Console.WriteLine($"MaxSpeed: {this.GetMaxSpeed()}");

        Console.WriteLine($"{nameof(this.Name)}: {this.Name}");
        Console.WriteLine($"{nameof(this.MaxSpeed)}: {this.MaxSpeed}");
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