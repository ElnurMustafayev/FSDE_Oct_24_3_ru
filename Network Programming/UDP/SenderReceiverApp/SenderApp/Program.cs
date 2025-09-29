using System.Net.Sockets;
using System.Text;

const int chunkSize = 10_000;
const string eofKey = "FILE_ENDED!!!";
byte[] eofKeyInBytes = Encoding.ASCII.GetBytes(eofKey);

var udpClient = new UdpClient(8002);


while (true)
{
    try
    {
        Console.Clear();
        System.Console.Write("Input filepath: ");
        var filepath = Console.ReadLine();

        ArgumentNullException.ThrowIfNullOrWhiteSpace(filepath, nameof(filepath));

        if (File.Exists(filepath) == false)
        {
            throw new ArgumentException("File doesn't exist!", nameof(filepath));
        }

        var fileInBytes = await File.ReadAllBytesAsync(filepath);

        /* break image
        for (int i = 4000; i < 5000; i++)
        {
            fileInBytes[i] = 0;
        }
        */

        var chunkCount = fileInBytes.Length / chunkSize;

        for (int i = 0; i < chunkCount; i++)
        {
            byte[] chunkInBytes = fileInBytes
                .Skip(i * chunkSize)
                .Take(chunkSize)
                .ToArray();

            Thread.Sleep(1);

            var sentBytesCount = await udpClient.SendAsync(
                chunkInBytes,
                chunkInBytes.Length,
                hostname: "localhost",
                port: 8001);

            System.Console.WriteLine($"Packet {i + 1} successfully sent! {sentBytesCount} bytes");
        }

        var eofSentBytesCount = await udpClient.SendAsync(
            eofKeyInBytes,
            eofKeyInBytes.Length,
            hostname: "localhost",
            port: 8001);
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex.Message}");
        continue;
    }
    finally
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}