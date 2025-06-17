using IsAsApp.Interfaces;
using IsAsApp.Models;

//Bomb bomb = new Bomb();

//if(bomb is IShootable)
//{
//    Console.WriteLine("IS");
//}
//else if (bomb is not IShootable)
//{
//    Console.WriteLine("IS NOT");
//}


/*
Weapon weapon = new KamikazeCar();

bool isThrowable = weapon is IThrowable;
Console.WriteLine($"Weapon is Throwable: {isThrowable}");

//IThrowable throwable = (IThrowable)weapon;
IThrowable throwable = weapon as IThrowable;

if(throwable is null)
{
    return;
}

throwable.Throw();
*/




Hero hero = new Hero();
hero.Weapons = [
    new Bomb(),
    new Pistol(),
    new KamikazeCar(),
];

hero.UseWeapon(2);
hero.ThrowAllWeapons();
