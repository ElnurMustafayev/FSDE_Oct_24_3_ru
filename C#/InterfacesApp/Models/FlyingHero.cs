using InterfacesApp.Models.Base;

namespace InterfacesApp.Models;

class FlyingHero : Hero, IFliable
{
    public void Fly()
    {
        Console.WriteLine("Hero flies...");
    }
}