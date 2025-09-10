/*
var tokenSource = new CancellationTokenSource();

ThreadPool.QueueUserWorkItem((token) =>
{
    Console.WriteLine("Thread start");
    while (token.IsCancellationRequested == false)
    {
        Thread.Sleep(1000);
        Console.WriteLine(150);
    }
    Console.WriteLine("Thread end");
}, tokenSource.Token, true);

Console.ReadKey();
tokenSource.Cancel();
Console.ReadKey();
*/



/*
ThreadPool.QueueUserWorkItem((obj) =>
{
    var threadId = Thread.CurrentThread.ManagedThreadId;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"#1 Thread Id: {threadId}");
        Thread.Sleep(500);
    }
});

Console.ReadKey();

ThreadPool.QueueUserWorkItem((obj) =>
{
    var threadId = Thread.CurrentThread.ManagedThreadId;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"#2 Thread Id: {threadId}");
        Thread.Sleep(700);
    }
});

Console.ReadKey();
*/