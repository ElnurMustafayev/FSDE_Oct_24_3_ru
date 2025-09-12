/*
Task[] tasks = new Task[]
{
    Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("one");
    }),
    Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("two");
    }),
    Task.Run(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine("three");
    }),
};

Console.WriteLine("Start");
//Task.WaitAll(tasks);
Task.WaitAny(tasks);
Console.WriteLine("End");
*/



var result = Parallel.For(0, 10, (index) =>
{
    Thread.Sleep(index * 100);
    Console.WriteLine(index);
});

string[] names = [
    "Bob", "Ann", "John"
];

Parallel.ForEach(names, (name) =>
{
    Console.WriteLine(name);
});