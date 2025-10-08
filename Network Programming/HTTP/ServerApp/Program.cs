using System.Net;
using System.Text.Json;

HttpListener httpListener = new HttpListener();

httpListener.Prefixes.Add("http://*:8080/");

httpListener.Start();

Console.WriteLine("Server Started...");

while(true) {
    var context = await httpListener.GetContextAsync();

    using var writer = new StreamWriter(context.Response.OutputStream);
    context.Response.StatusCode = (int)HttpStatusCode.MovedPermanently;

    await writer.WriteLineAsync(JsonSerializer.Serialize(new
    {
        id = 100,
        name = "Bob",
        price = 15_000
    }));
    await writer.FlushAsync();

    System.Console.WriteLine(context);
}