using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookManagement.Services
{

    class JsonFileStorage : IStorageService
    {
        private readonly string _storageDirectory;

        public JsonFileStorage()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentPath, "BookManagement", "JsonData");
            Directory.CreateDirectory(_storageDirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public Book GetById(string id)
        {
            return default;
        }

        public void Save(Book book)
        {
            var jsonText = JsonConvert.SerializeObject(book);
            var filePath = Path.Combine(_storageDirectory, $"{book.Id}.json");
            File.WriteAllText(filePath, jsonText);
        }
        public Book Search(string name)
        {
            var files = Directory.GetFiles(_storageDirectory);
            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Book book = JsonConvert.DeserializeObject<Book>(fileContentJson);

                var bookName = book.BookName.ToLowerInvariant();
                var bookkToSearch = name.ToLowerInvariant();

                if (bookName.Contains(bookkToSearch))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
