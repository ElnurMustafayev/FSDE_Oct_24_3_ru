using IsAsApp.Interfaces;

namespace IsAsApp.Models;

class KamikazeCar : Weapon, IBoom
{
    public void Boom()
    {
        Console.WriteLine("BOOM!!!");
    }

    public override void Use()
    {
        this.Boom();
        this.Boom();
        this.Boom();
    }
}