//Thread thread = Thread.CurrentThread;

//Console.WriteLine(thread);


//ThreadStart threadMethod = () =>
//{
//    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
//    Console.WriteLine("Hello from Thread!");
//};
//Thread thread = new Thread(threadMethod);

//thread.Start();
//Console.WriteLine($"General Thread Id: {Thread.CurrentThread.ManagedThreadId}");
//Console.WriteLine(Thread.CurrentThread.ManagedThreadId);



/*
new Thread(() =>
{
    int counter = 0;
    while (counter != 70)
    {
        Thread.Sleep(100);
        Console.WriteLine($"Thread 1 {Thread.CurrentThread.ManagedThreadId} Counter: {counter++}");
    }
})
{
    IsBackground = false
}.Start();


var infinityThread = new Thread(() =>
{
    int counter = 0;
    while (counter != 150)
    {
        Thread.Sleep(100);
        Console.WriteLine($"Thread 2 {Thread.CurrentThread.ManagedThreadId} Counter: {counter++}");
    }
})
{
    IsBackground = true
};

infinityThread.Start();

for (int i = 0; i < 5; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine($"Main {Thread.CurrentThread.ManagedThreadId} TICK: {i}");
}
*/

//Environment.Exit(0);