using ReadIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Add(string title, string author);
        Book Delete(int id);
        Book Edit(int id, string title, string author);
        Book GetById(int id);
    }
}
