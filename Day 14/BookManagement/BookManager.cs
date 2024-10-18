using BookManagement.Entities;
using BookManagement.Entities.Types;
using BookManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookManager
    {
        private readonly IStorageService _storageService;

        public BookManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var book = new Book();
            book.Id = Guid.NewGuid().ToString();

            Console.WriteLine("Book name: ");
            book.BookName = Console.ReadLine();

            Console.WriteLine("Author: ");
            book.Author = Console.ReadLine();

            Console.WriteLine("Book Type: 1. Horror  2. Fictional 3. Sci-Fi 4. Romance 5. Drama: ");
            var bookTypeInput = Console.ReadLine();
            BookType bookType;

            if (bookTypeInput == "1")
            {
                bookType = BookType.Horror;
            }
            else if (bookTypeInput == "2")
            {
                bookType = BookType.Fictional;
            }
            else if (bookTypeInput == "3")
            {
                bookType = BookType.SciFi;
            }
            else if (bookTypeInput == "4")
            {
                bookType = BookType.Romance;
            }
            else if (bookTypeInput == "5")
            {
                bookType = BookType.Drama;
            }
            else
            {
                Console.WriteLine("Invalid bookType");
            }

            _storageService.Save(book);
        }

        public void Remove()
        {
            Console.WriteLine("Enter Book id: ");
            var id = Console.ReadLine();
            _storageService.Delete(id);

        }

        public void Search()
        {
            Console.WriteLine("Enter book name: ");
            var name = Console.ReadLine();

            var bk = _storageService.Search(name);
            if (bk == null)
            {
                Console.WriteLine("Not Found");
                return;
            }

            Console.WriteLine(bk);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

                var c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search(); 
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("INVALID");
                        break;
                }
            }
        }
    }
}
