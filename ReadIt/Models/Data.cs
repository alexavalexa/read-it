using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Models
{
    public class Data : IData
    {
        public List<Book> Books { get; set; }

        public Data()
        {
            this.Books = new List<Book>();
        }
    }
}
