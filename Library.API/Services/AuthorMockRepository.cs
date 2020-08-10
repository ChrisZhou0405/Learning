using Library.API.Data;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class AuthorMockRepository:IAuthorRepository
    {
        public AuthorDto GetAuthor(Guid authorld)
        {
            var author = LibraryMockData.Current.Authors.FirstOrDefault(au =>au.Id ==authorld);
            return author;
        }
        public IEnumerable<AuthorDto> GetAuthors()
        {
            return LibraryMockData.Current.Authors;
        }
        public bool IsAuthorExists(Guid authorld)
        {
            return LibraryMockData.Current.Authors.Any(au => au.Id == authorld);
        }

    }
}
