using System.Net;

HttpListener httpListener = new HttpListener();

httpListener.Prefixes.Add("http://*:8080/");

httpListener.Start();