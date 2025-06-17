using IsAsApp.Interfaces;

namespace IsAsApp.Models;

class Pistol : Weapon, IShootable, IThrowable
{
    public void Shoot()
    {
        Console.WriteLine("ratatatata");
    }

    public void Throw()
    {
        Console.WriteLine("pistol is throwing...");
    }

    public override void Use()
    {
        this.Shoot();
        this.Throw();
    }
}