using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Models
{
    public interface IData
    {
        List<Book> Books { get; set; }
    }
}
