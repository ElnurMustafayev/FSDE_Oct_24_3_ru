using System.Net;
using System.Net.Sockets;

const string ip = "127.0.0.1";
const int port = 7777;
var listener = new TcpListener(IPAddress.Parse(ip), port);
listener.Start();
System.Console.WriteLine($"Server started '{ip}:{port}'...");

Dictionary<string, NetworkStream> users = new Dictionary<string, NetworkStream>();

while (true)
{
    try
    {
        var tcpClient = await listener.AcceptTcpClientAsync();
        System.Console.WriteLine($"New client connected: {tcpClient.Client.RemoteEndPoint}");

        _ = Task.Run(async () =>
        {
            try
            {
                var stream = tcpClient.GetStream();
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream)
                {
                    AutoFlush = true
                };

                var clientUsername = await reader.ReadLineAsync();

                if (string.IsNullOrWhiteSpace(clientUsername) == true)
                {
                    await writer.WriteLineAsync($"Username can not be empty!");
                    return;
                }

                if (users.ContainsKey(clientUsername) == true)
                {
                    await writer.WriteLineAsync($"Username {clientUsername} already exist!");
                    return;
                }

                users.Add(clientUsername, stream);

                await writer.WriteLineAsync($"Welcome {clientUsername}!");

                while (true)
                {
                    var clientMessage = await reader.ReadLineAsync();

                    foreach (var user in users)
                    {
                        if (user.Key == clientUsername)
                        {
                            continue;
                        }

                        var anotherUserWriter = new StreamWriter(user.Value)
                        {
                            AutoFlush = true
                        };
                        await anotherUserWriter.WriteLineAsync($"{clientUsername}: {clientMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex}");
            }
        });
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex}");
    }
}