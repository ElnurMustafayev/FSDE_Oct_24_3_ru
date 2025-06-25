using System.Text;

// Stream stream = new FileStream(
//     path: "text.txt",
//     mode: FileMode.OpenOrCreate,
//     access: FileAccess.ReadWrite
// );

// string text = "Marley";

// foreach (var symbol in text)
// {
//     stream.WriteByte((byte)symbol);
// }
// stream.Flush();

// stream.Seek(0, SeekOrigin.End);

// byte[] textInBytes = Encoding.ASCII.GetBytes("," + text);
// stream.Write(textInBytes);
// stream.Flush();




// while (true)
// {
//     int readByteResult = stream.ReadByte();
//     if (readByteResult == -1)
//     {
//         break;
//     }

//     char currentSymbol = (char)readByteResult;
//     System.Console.Write(currentSymbol + " ");
// }




// byte[] buffer = new byte[1024];

// int readSymbolsCount = stream.Read(buffer);

// var text = Encoding.ASCII.GetString(buffer, 0, readSymbolsCount);

// System.Console.WriteLine(text);




// File.WriteAllText("text.txt", Console.ReadLine());
// File.AppendAllText("text.txt", Console.ReadLine());
// string text = File.ReadAllText("text.txt");
// System.Console.WriteLine(text);

// string[] lines = File.ReadAllLines("text.txt");
// foreach (var line in lines)
// {
//     System.Console.WriteLine($">>>{line}<<<");
// }




/*
Stream srcStream = new FileStream(
    path: "cat.jpg",
    mode: FileMode.Open,
    access: FileAccess.Read
);

Stream destStream = new FileStream(
    path: "copied.jpg",
    mode: FileMode.CreateNew,
    access: FileAccess.Write
);

while (true)
{
    byte[] buffer = new byte[1024];
    int bufferWrittenElementsCount = srcStream.Read(buffer);

    if (bufferWrittenElementsCount == 0)
    {
        break;
    }
    
    destStream.Write(buffer, 0, bufferWrittenElementsCount);
}

destStream.Flush();
*/