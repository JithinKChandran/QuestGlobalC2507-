using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Program
    {
        static List<string> musicFiles;
        static int currentIndex = -1;

        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filepath = Path.Combine(desktop, "MusicFiles");
            
            musicFiles = Directory.GetFiles(filepath, "*.mp3").ToList();

            if (musicFiles.Count == 0)
            {
                Console.WriteLine("No music files found.");
                return;
            }

            string input;
            do
            {
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Next");
                Console.WriteLine("4. Previous");
                Console.WriteLine("Type 'q' to quit.");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Start();
                        break;
                    case "2":
                        Stop();
                        break;
                    case "3":
                        Next();
                        break;
                    case "4":
                        Previous();
                        break;
                }
            } while (input.ToLower() != "q");
        }

        static void Start()
        {
            if (currentIndex == -1 && musicFiles.Count > 0)
            {
                currentIndex = 0;
                Console.WriteLine($"Playing {Path.GetFileName(musicFiles[currentIndex])}");
            }
            else
            {
                Console.WriteLine("Music already playing.");
            }
        }

        static void Stop()
        {
            if (currentIndex != -1)
            {
                Console.WriteLine($"Stopped {Path.GetFileName(musicFiles[currentIndex])}");
                currentIndex = -1;
            }
            else
            {
                Console.WriteLine("No music is playing.");
            }
        }

        static void Next()
        {
            if (currentIndex != -1 && currentIndex < musicFiles.Count - 1)
            {
                currentIndex++;
                Console.WriteLine($"Playing {Path.GetFileName(musicFiles[currentIndex])}");
            }
            else if (currentIndex == musicFiles.Count - 1)
            {
                Console.WriteLine("Already at the last song.");
            }
            else
            {
                Console.WriteLine("No music is playing.");
            }
        }

        static void Previous()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                Console.WriteLine($"Playing {Path.GetFileName(musicFiles[currentIndex])}");
            }
            else if (currentIndex == 0)
            {
                Console.WriteLine("Already at the first song.");
            }
            else
            {
                Console.WriteLine("No music is playing.");
            }
        }
    }
}

        
    
