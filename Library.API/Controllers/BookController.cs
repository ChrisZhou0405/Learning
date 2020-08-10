using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Library.API.Controllers
{
    [Route("api/authors/{authorId}/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookRepository BookRepository;
        public IAuthorRepository AuthorRepository;

        public BookController(IBookRepository bookRepository,IAuthorRepository authorRepository)
        {
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
        }

        /// <summary>
        /// 获取某个作者下所有书籍
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public ActionResult<List<BookDto>> GetBooks(Guid authorId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            else
            {
               return BookRepository.GetBooksForAuthor(authorId).ToList();
            }
        }

        /// <summary>
        /// 获取作者具体的某一本书
        /// </summary>
        /// <param name="authorId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet("{bookId}")]
        public ActionResult<BookDto> GetBook(Guid authorId,Guid bookId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var tagetBook= BookRepository.GetBookForAuthor(authorId, bookId);
            if (tagetBook==null)
            {
                return NotFound();
            }
            else
            {
                return tagetBook;
            }
        }
    }
}
