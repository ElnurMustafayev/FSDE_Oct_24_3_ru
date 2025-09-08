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



/*
ParameterizedThreadStart threadStart = (obj) =>
{
    if (obj is not CancellationToken token)
    {
        return;
    }

    while (true)
    {
        try
        {
            token.ThrowIfCancellationRequested();
            Thread.Sleep(500);
            Console.WriteLine("Thread tick");
        }
        catch
        {
            Console.WriteLine("rollback");
            break;
        }
    }
};

var thread = new Thread(threadStart);

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

thread.Start(cancellationTokenSource.Token);

Console.ReadKey();

cancellationTokenSource.Cancel();

while (true)
{
    Thread.Sleep(100);
    Console.WriteLine("Main");
}
*/


/*
var thread1 = new Thread(() =>
{
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"thread1: {Thread.CurrentThread.ManagedThreadId}");
    }
});

var thread2 = new Thread(() =>
{
    for (int i = 0; i < 30; i++)
    {
        Thread.Sleep(800);
        Console.WriteLine($"thread2: {Thread.CurrentThread.ManagedThreadId}");
    }
});

Console.WriteLine("Main start");
thread1.Start();
thread2.Start();
Console.WriteLine("Main middle");
thread1.Join();
thread2.Join();
Console.WriteLine("Main end");
*/



/*
var thread1 = new Thread(() =>
{
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"thread1: {Thread.CurrentThread.ManagedThreadId}");
    }
});
thread1.Start();

var thread2 = new Thread(() =>
{
    for (int i = 0; i < 30; i++)
    {
        Thread.Sleep(800);
        Console.WriteLine($"thread2: {Thread.CurrentThread.ManagedThreadId}");
        thread1.Join();
    }
});

thread2.Start();
*/

/*

create table Logs (
	[Id] int primary key identity,
	[Message] nvarchar(200) not null,
	[Priority] int
)

*/

//while (true)
//{
//    try
//    {
//        Console.Write("the first num: ");
//        var firstNum = Convert.ToInt32(Console.ReadLine());
//        Console.Write("the second num: ");
//        var secondNum = Convert.ToInt32(Console.ReadLine());

//        var result = firstNum / secondNum;

//        Console.WriteLine($"{firstNum} / {secondNum} = {result}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error: {ex.Message}");
//        new Thread(() =>
//        {
//            string connectionString = "Server=localhost;Database=LogsDb;User Id=admin;Password=admin;TrustServerCertificate=True;";

//            using var connection = new SqlConnection(connectionString);
//            connection.Open();

//            connection.Execute(
//                sql: $@"insert into Logs ([Message], [Priority])
//            values (@message, @priority)",
//                param: new
//                {
//                    message = ex.Message,
//                    priority = 15
//                });
//        }).Start();
//    }
//}



// 1. read from file ...                            - 10ms
// 2. get statistics from db                        - 120ms
// 3. insert something, statistics in another db    - 250ms
// sum: 4.5



/*

//var content = new Content();
var result = new ResultForInserts();

//var thread1 = new thread(() => content = File.Read());
var thread1 = new thread((result) => result.content = File.Read());     // 10 ms
var thread2 = new thread((result) => result.stats = db.GetStats());     // 120 ms
thread1.start(result);
thread2.start(result);

thread1.join();
thread2.join();

var result = anotherdb.insert(result.content, result.stats);            // 250 ms

// sum: 370 ms

*/