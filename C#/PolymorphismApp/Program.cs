using PolymorphismApp.Models.Base;
using PolymorphismApp.Models;
using PolymorphismApp.Services;

Cat cat = new Cat("Rijik");
Dog dog = new Dog("Barsik");

Animal animal = cat;
animal.Say();   // meow
animal = dog;
animal.Say();   // huf


// Box box = new Box();
// box.PutAnimalIn(dog);
// box.PutAnimalIn(cat);