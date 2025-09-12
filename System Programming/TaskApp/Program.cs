/*
var task = new Task(() =>
{
    while (true)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Task: {Thread.CurrentThread.ManagedThreadId}");
    }
});

task.Start();

Console.ReadKey();
*/


/*
Task<int> task = new Task<int>(() =>
{
    const int loopLimit = 5;
    for (int i = 0; i < loopLimit; i++)
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("number loading...");
        Console.WriteLine($"progress: {i + 1}/{loopLimit}");
    }

    return 100;
});

task.Start();

var number = task.Result;

Console.WriteLine($"Result: {number}");
*/