using Microsoft.AspNetCore.Mvc;
using Web_APi.Services;
using Web_APi.Models;

namespace Web_APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyBooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public MyBooksController(IBookService bookservice)
        {
            _bookService = bookservice;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_bookService.GetBookById(id));
        }

        [HttpPost]
        public IActionResult AddBook(Books newBooks)
        {
              return Ok(_bookService.AddBooks(newBooks));
        }

        [HttpPut]
        public IActionResult UpdateBooks(Books updateBooks)
        {
            return Ok(_bookService.UpdateBooks(updateBooks));
        }
    }
}