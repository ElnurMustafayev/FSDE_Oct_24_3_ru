//var mutex = new Mutex(false, "MyMutex");

//mutex.WaitOne();

//Console.WriteLine("App started");
//Console.WriteLine("Press any key to exit");

//Console.ReadKey();

//mutex.ReleaseMutex();






//var mutex = new Mutex(false, "MyMutex");

object locker = new object();

int num = 0;

var task1 = Task.Run(() =>
{
    for (int i = 0; i < 1_000_000; i++)
    {
        num++;

        //Interlocked.Increment(ref num);
        //lock (locker)
        //{
        //Monitor.Enter(locker);
        //mutex.WaitOne();
        //num++;
        //mutex.ReleaseMutex();
        //Monitor.Exit(locker);
        //}
    }
    Console.WriteLine("Task 1 end...");
});

var task2 = Task.Run(() =>
{
    for (int i = 0; i < 1_000_000; i++)
    {
        num++;

        //Interlocked.Increment(ref num);
        //lock (locker)
        //{
        //Monitor.Enter(locker);
        //mutex.WaitOne();
        //num++;
        //mutex.ReleaseMutex();
        //Monitor.Exit(locker);
        //}
    }
    Console.WriteLine("Task 2 end...");
});

Console.ReadKey();
Console.WriteLine(num);