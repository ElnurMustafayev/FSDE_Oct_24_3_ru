using System.Net.Sockets;

var tcpClient = new TcpClient();

await tcpClient.ConnectAsync("localhost", 7777);

var stream = tcpClient.GetStream();
var reader = new StreamReader(stream);
var writer = new StreamWriter(stream)
{
    AutoFlush = true
};

System.Console.Write("Input your username: ");
var username = Console.ReadLine();

await writer.WriteLineAsync(username);

var welcomeMessageFromServer = await reader.ReadLineAsync();

if (welcomeMessageFromServer!.Contains("Welcome") == false)
{
    System.Console.WriteLine($"Error: {welcomeMessageFromServer}");
    return;
}

System.Console.WriteLine($"Server: {welcomeMessageFromServer}");

_ = Task.Run(async () =>
{
    try
    {
        while (true)
        {
            var anotherClientMessage = await reader.ReadLineAsync();
            System.Console.WriteLine(anotherClientMessage);
        }
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex}");
    }
});

while (true)
{
    var message = Console.ReadLine();
    await writer.WriteLineAsync(message);
}

/*

USER IDENTIFICATION

client:
    input username
    send username
server:
    get username
    send "Welcome {username}!"
client:
    see "Welcome {username}!"


USER CHATING

client: 
    input message
    send {message}
server:
    get {message} from user
    broadcast "{username}: {message}" to all another users
other clietns:
    get message
    see: "{username}: {message}"

*/


