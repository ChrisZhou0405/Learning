using Library.API.Data;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class BookMockRepository:IBookRepository
    {
        public void AddBook(BookDto book)
        {
            LibraryMockData.Current.Books.Add(book);
        }

        public BookDto GetBookForAuthor(Guid authorld, Guid bookid)
        {
            return LibraryMockData.Current.Books.FirstOrDefault(b => b.Authorld == authorld && b.Id ==bookid);
        }
        public IEnumerable<BookDto> GetBooksForAuthor(Guid authorld)
        {
            return LibraryMockData.Current.Books.Where(b => b.Authorld ==authorld).ToList();
        }

    }
}
