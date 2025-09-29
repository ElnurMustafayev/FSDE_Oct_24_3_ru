using System.Net;
using System.Net.Sockets;
using System.Text;

const string ip = "127.0.0.1";
const int port = 7777;
var listener = new TcpListener(IPAddress.Parse(ip), port);
listener.Start();
System.Console.WriteLine($"Server started '{ip}:{port}'...");

while (true)
{
    try
    {
        var tcpClient = await listener.AcceptTcpClientAsync();
        System.Console.WriteLine($"New client connected: {tcpClient.Client.RemoteEndPoint}");

        var stream = tcpClient.GetStream();

        var messageToClient = "Hello from Server!";
        var messageToClientInBytes = Encoding.ASCII.GetBytes(messageToClient);

        _ = Task.Run(async () =>
        {
            while (true)
            {
                await stream.WriteAsync(messageToClientInBytes);
                await stream.FlushAsync();

                Thread.Sleep(1000);
            }
        });
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex}");
    }
}