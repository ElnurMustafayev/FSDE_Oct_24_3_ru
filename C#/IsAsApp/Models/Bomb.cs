using IsAsApp.Interfaces;

namespace IsAsApp.Models;

class Bomb : Weapon, IBoom, IThrowable
{
    public void Boom()
    {
        Console.WriteLine("BOOOOOOM");
    }

    public void Throw()
    {
        Console.WriteLine("bomb is throwing...");
    }

    public override void Use()
    {
        this.Throw();
        this.Boom();
    }
}