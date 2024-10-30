using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerClient
{
    internal class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1"; 
        private const int port = 8000; 
        private TcpClient _client; 
        private void Connect()
        { 
            var ip = IPAddress.Parse(ipAddress);
            _client = new TcpClient(); 
            _client.Connect(ip, port); 
        }
        public void Run(Action<string> callback)
        {
            Connect(); 
            Console.WriteLine($"Connected to Server at {ipAddress}:{port}"); 
            while (true)
            {
                Console.WriteLine("Client: "); 
                var message = Console.ReadLine(); 
                byte[] data = Encoding.ASCII.GetBytes(message);
                _client.GetStream().Write(data, 0, data.Length); 

                byte[] response = new byte[1024]; 
                var dataLength = _client.GetStream().Read(response, 0, response.Length); 
                var responseText = Encoding.ASCII.GetString(response, 0, dataLength); 
                Console.WriteLine("Server: " + responseText); callback(responseText); 
            }
        } 
    }      
}
