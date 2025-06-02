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




        #region Accessors

        // Type -> T
        // field name -> Field

        // void SetField(T field)
        // T GetField();

        // void SetNumber(int number);
        // void SetText(string text);

        // int GetNumber();
        // string GetText();


        //Car car = new Car("Bmw", 260);
        //Car car = new Car();

        //car.SetMaxSpeed(-1_000_000);
        //car.SetMaxSpeed(0);

        //car.ShowInfo();

        #endregion

        #region Properties

        #region Getters

        //Car car = new Car();
        ////Console.WriteLine(car.MyProperty);
        //int result = car.MyProperty + car.MyProperty;
        //Console.WriteLine(car.MyProperty + car.MyProperty - car.MyProperty);
        //car.SetMaxSpeed(car.MyProperty);

        //Console.WriteLine(result);

        #endregion

        #region Setters

        //Car car = new Car();

        //car.MyProperty = 111;
        //car.MyProperty = 222;
        //car.MyProperty = 333;

        //Console.WriteLine(car.MyProperty);

        #endregion

        Car car = new Car();

        car.Name = "Bmw";
        car.MaxSpeed = 280;

        car.ShowInfo();

        #endregion

    }
}