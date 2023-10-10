using Library.BLL.Interfaces;
using Library.Common.DTO.Book;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController: ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("all")]
    public async Task<ActionResult<List<BookDto>>> GetAllBook()
    {
        return Ok(await _bookService.GetAllBooksAsync());
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<BookDto>> GetBookById(int id)
    {
        return Ok(await _bookService.GetBookByIdAsync(id));
    }
    
    [HttpPost]
    public async Task<ActionResult<BookDto>> CreateBook(CreateBookDto bookDto)
    {
        return Ok(await _bookService.CreateBookAsync(bookDto));
    }

    [HttpPut]
    public async Task<ActionResult<BookDto>> UpdateBook(UpdateBookDto bookDto)
    {
        return Ok(await _bookService.UpdateBookAsync(bookDto));
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteBook(int id)
    {
        await _bookService.DeleteBookAsync(id);
        return NoContent();
    }
}