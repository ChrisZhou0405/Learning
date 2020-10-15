using Library.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class BookEFRepository:RepositoryBase<Book,Guid>,IBookEFRepository
    {
        public BookEFRepository(DbContext dbContext):base(dbContext)
        {
            
        }
    }
}
