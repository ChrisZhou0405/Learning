using Library.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private IAuthorEFRepository _authorRepository = null;
        private IBookEFRepository _bookRepository = null;
        public LibraryDbContext LibraryDbContext { get; }
        public RepositoryWrapper(LibraryDbContext libraryDbContext)
        {
            LibraryDbContext = libraryDbContext;
        }
        public IAuthorEFRepository Author => _authorRepository ?? new AuthorEFRepository(LibraryDbContext);
        public IBookEFRepository Book => _bookRepository ?? new BookEFRepository(LibraryDbContext);

    }
}
