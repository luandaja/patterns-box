using System.Net;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RepositoryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("{bookId}")]
        public ActionResult GetBook(int bookId)
        {
            var response = _bookRepository.GetById(bookId);
            return StatusCode((int)HttpStatusCode.OK, response);
        }
    }
}
