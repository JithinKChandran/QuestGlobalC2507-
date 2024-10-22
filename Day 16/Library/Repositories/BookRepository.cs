using Library.Data;
using Library.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        public GenericResponse<Book> GetBookById(int Bookid)
        {
            var bok = DataStore.Books.FirstOrDefault(b => b.BookId == Bookid);
            if (bok == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = bok,
            };
        }

        public GenericResponse<Book> GetBookByName(string bookName)
        {
            var bok = DataStore.Books.FirstOrDefault(b => b.Title == bookName);
            if (bok == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = bok,
            };
        }
    }
}
