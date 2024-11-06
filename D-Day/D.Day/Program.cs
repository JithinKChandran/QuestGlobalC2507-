using D.Day.Services;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net;
using System;
using System.IO;
using D.Day.Repository;
using NoteTakingApp.Repositories;

namespace D.Day
{
    internal class Program
    {
        private static void ConfigureLogging()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var logDirectory = Path.Combine(documentsPath, "NoteApp");
            Directory.CreateDirectory(logDirectory);

            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };

            var errorFileAppender = new FileAppender
            {
                File = Path.Combine(logDirectory, "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error
            };
            BasicConfigurator.Configure(repository, consoleAppender, errorFileAppender);
        }

        static void Main(string[] args)
        {
            ConfigureLogging();

            INoteRepository noteRepository = new JsonNoteRepository();
            NoteService noteService = new NoteService(noteRepository);

            while (true)
            {
                Console.WriteLine("1. New note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        noteService.CreateNote();
                        break;
                    case "2":
                        noteService.ViewNotes();
                        break;
                    case "3":
                        noteService.UpdateNote();
                        break;
                    case "4":
                        noteService.DeleteNote();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
