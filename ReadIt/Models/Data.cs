using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Models
{
    public static class Data
    {
        public static List<Book> Books { get; set; }

        static Data()
        {
            Books = new List<Book>();
        }
    }
}
