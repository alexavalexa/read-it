using ReadIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Services
{
    public class BookService
    {
        public Book Add(string title, string author)
        {
            Book book = new Book(title, author);
            Data.Books.Add(book);
            return book;
        }

        public List<Book> GetAll()
        {
            return Data.Books;
        }
    }
}
