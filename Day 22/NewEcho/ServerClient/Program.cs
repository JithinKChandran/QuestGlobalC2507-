using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientBuilder(); 
            var clientThread = new Thread(() =>
            { 
                client.Run(message =>
                { 
                    Console.WriteLine($"Processed in client: {message}"); 
                }); 
            });
            clientThread.Start(); 
        }
    }
}
