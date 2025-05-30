//using TestNs;

namespace IncapsulationApp;

class Program
{
    public static void Main()
    {
        //TestNs.Car car;
        //IncapsulationApp.Car car;



        //Car car = new Car();

        //car.Name = "bmw";
        //car.MaxSpeed = 260;

        //car.ShowInfo();





        //Car car = new Car("Bmw", 260);
        Car car = new Car();

        //car.SetMaxSpeed(-1_000_000);
        car.SetMaxSpeed(0);

        car.ShowInfo();
    }
}