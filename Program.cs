// See https://aka.ms/new-console-template for more information
using system;
using system.Net;

{
    string API_URL = "https://bpoamericas.co/Prueba/SecurityAPI/Security/LoginUser";
   

    var client = new WebClient();
    client.downloadstring(API_URL); 
}

