using InterfacesApp.Models.Base;

namespace InterfacesApp.Models;

class FlyingArcher : Archer, IFliable, ITest
{
    public void Fly()
    {
        Console.WriteLine("Archer flies...");
    }

    public void Method2() { }
}