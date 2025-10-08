using System.Net;


HttpClient httpClient = new HttpClient();

// var response = await httpClient.GetAsync("https://lb.itstep.org/attendance");

// var responseStr = await response.Content.ReadAsStringAsync();

// System.Console.WriteLine(responseStr);


var response = await httpClient.GetAsync("http://localhost:8080/routing?qwerty=abc111");

var responseStr = await response.Content.ReadAsStringAsync();

System.Console.WriteLine($"Content: {responseStr}");
System.Console.WriteLine($"Status code: {response.StatusCode}");






/*
WebClient client = new WebClient();

try {
    var uri = new Uri("https://cdnjs.com/libraries/normalize");

    var responseStr = client.DownloadString(uri);
    
    System.Console.WriteLine(responseStr);
}
catch(Exception ex) {
    System.Console.WriteLine($"Error: {ex}");
}
*/