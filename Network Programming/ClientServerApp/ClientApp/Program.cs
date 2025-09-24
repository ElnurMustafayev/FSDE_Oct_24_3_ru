using System.Net.Sockets;
using System.Text;

var tcpClient = new TcpClient();

await tcpClient.ConnectAsync("localhost", 7777);

var stream = tcpClient.GetStream();

byte[] buffer = new byte[1000];

while (true)
{
    int size = await stream.ReadAsync(buffer, 0, 1000);
    
    var messageFromServer = Encoding.ASCII.GetString(buffer, 0, size);
    
    System.Console.WriteLine($"Server: {messageFromServer}");
}