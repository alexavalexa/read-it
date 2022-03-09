using ReadIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Services
{
    public class BookService : IBookService
    {
        private IData data;
        public BookService(IData data)
        {
            this.data = data;
        }
        public List<Book> GetAll()
        {
            return data.Books;
        }

        public Book Add(string title, string author)
        {
            Book book = new Book(title, author);
            data.Books.Add(book);
            return book;
        }


        public Book Edit(int id, string title, string author)
        {
            Book book = GetById(id);
            book.Title = title;
            book.Author = author;
            return book;
        }
        public Book Delete(int id)
        {
            Book book = GetById(id);
            data.Books.Remove(book);
            return book;
        }

        public  Book GetById(int id)
        {
            return data.Books.FirstOrDefault(p => p.Id == id);
        }

    }
}
