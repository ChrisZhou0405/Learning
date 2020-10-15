using Library.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class AuthorEFRepository : RepositoryBase<Author, Guid>, IAuthorEFRepository
    {
        public AuthorEFRepository(DbContext dbContext):base(dbContext)
        { }
    }
}
