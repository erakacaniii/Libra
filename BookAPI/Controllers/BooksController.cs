using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Dto;
using BookAPI.Services;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController(IBookService service) : ControllerBase
    {
        private IBookService _service = service;

        [HttpGet("All")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();

            return Ok(allBooks);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var newBook = _service.GetBookById(id);

            if (newBook == null)
                return NotFound($"book with id {id} could not be found.");

            return Ok(newBook);
        }


        [HttpPost]
        public IActionResult AddNewBook([FromBody] PostBookDto payload)
        {
            var newBook = _service.AddBook(payload);

            return Ok(newBook);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] PutBookDto payload, int id)
        {
            var updatedBook = _service.UpdateBook(payload, id);

            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);

            return Ok();
        }

    }
}