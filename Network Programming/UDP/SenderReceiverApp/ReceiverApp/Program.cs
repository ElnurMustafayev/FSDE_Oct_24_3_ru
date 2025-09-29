using System.Net;
using System.Net.Sockets;
using System.Text;

const string eofKey = "FILE_ENDED!!!";
byte[] eofKeyInBytes = Encoding.ASCII.GetBytes(eofKey);

var udpClient = new UdpClient(8001);


while (true)
{
    IPEndPoint? remoteIpEndpoint;

    List<byte> buffer = new List<byte>();

    while (true)
    {
        var receivedPacket = await udpClient.ReceiveAsync();
        remoteIpEndpoint = receivedPacket.RemoteEndPoint;

        // bad
        // if (Encoding.ASCII.GetString(receivedPacket.Buffer) == eofKey)
        // {
        //     break;
        // }

        // good
        if (receivedPacket.Buffer.Length == eofKeyInBytes.Length && Encoding.ASCII.GetString(receivedPacket.Buffer) == eofKey)
        {
            break;
        }

        buffer.AddRange(receivedPacket.Buffer);
    }

    var filepath = $"./Images/{Guid.NewGuid().ToString("N")}.jpg";

    await File.WriteAllBytesAsync(filepath, buffer.ToArray());

    System.Console.WriteLine("{0}:{1}: file saved in: '{2}'",
        remoteIpEndpoint.Address,
        remoteIpEndpoint.Port,
        filepath);
}