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

        public Book Edit(int id, string title, string author)
        {
            Book book = GetById(id);
            book.Title = title;
            book.Author = author;
            return book;
        }
        public static Book GetById(int id)
        {
            return Data.Books.FirstOrDefault(p => p.Id == id);
        }
    }
}
