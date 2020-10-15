﻿using Library.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
   public interface IBookEFRepository:IRepositoryBase<Book>,IRepositoryBase2<Book,Guid>
    {
    }
}
