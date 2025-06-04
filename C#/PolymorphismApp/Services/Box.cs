using PolymorphismApp.Models.Base;

namespace PolymorphismApp.Services;

public class Box
{
    public void PutAnimalIn(Animal animal)
    {
        System.Console.WriteLine("Animal is putting in box...");
        animal.Say();
    }
}