using System.Net;

WebClient client = new WebClient();

try {
    var uri = new Uri("https://cdnjs.com/libraries/normalize");

    var responseStr = client.DownloadString(uri);
    
    System.Console.WriteLine(responseStr);
}
catch(Exception ex) {
    System.Console.WriteLine($"Error: {ex}");
}