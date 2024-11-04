using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Net
{
    internal class Program
    {
        static void MakeRequestUser()
        {
            string targetUrl = "https://jsonplaceholder.typicode.com/users";
            var client = new HttpClient();
            var response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }
        static void MakeRequestPost(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var client = new HttpClient();
            var response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }

        static async Task MakeRequestPostAsync(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var client = new HttpClient();

            var response = await client.GetAsync(targetUrl);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            await Task.Delay(1000);
            Console.WriteLine(responseContent);
        }

        static async Task<int> Multiply(int number)
        {
            await Task.Delay(1000);
            return number * 2;
        }

        // Cancellation Token.

        static async Task LongRunningactivity(CancellationToken cancellationToken)
        {
            int downloadPercent = 0;
            while (downloadPercent < 101)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelling download");
                    break;
                }
                Console.WriteLine("Downloading... "+ downloadPercent++ + "%");
                await Task.Delay(2500);
            }
        }
        public static async Task Main(string[] args)
        {
            MakeRequestUser();
            MakeRequestPost(1);

            for (int i = 1; i < 10; i++)
            {
                await MakeRequestPostAsync(i);
            }

            var tasks = new List<Task<int>>();
            tasks.Add(Task.Run(() => Multiply(2)));
            tasks.Add(Task.Run(() => Multiply(5)));
            tasks.Add(Task.Run(() => Multiply(8)));

            int[] results = await Task .WhenAll(tasks);
            Console.WriteLine(string.Join(", ", results));

            var cancellationToken = new CancellationToken();
            var task = LongRunningactivity(cancellationToken.Token);

            Console.WriteLine("Press q to exit:");
            if (Console.ReadKey().KeyChar == 'q')
            {
                cancellationToken.Cancel();
            }

            await task;
        }
    }
}
