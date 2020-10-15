using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
     public  interface IBookRepository
    {
        IEnumerable<BookDto> GetBooksForAuthor(Guid authorId); 
        BookDto GetBookForAuthor(Guid authorld, Guid bookid);
        void AddBook(BookDto book);
    }
}
