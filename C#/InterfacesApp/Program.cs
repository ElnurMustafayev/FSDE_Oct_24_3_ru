using InterfacesApp.Models;
using InterfacesApp.Models.Base;

//FlyingArcher flyingArcher = new FlyingArcher();
//flyingArcher.Fly();

//FlyingHero flyingHero = new FlyingHero();
//flyingHero.Fly();

IFliable[] fliables = [
    new FlyingArcher(),
    new FlyingHero(),
];

for (int i = 0; i < fliables.Length; i++)
{
    fliables[i].Fly();
}

ITest test = new FlyingArcher();
test = new Hero();

test.Method1();
test.Method2();
test.Method2();