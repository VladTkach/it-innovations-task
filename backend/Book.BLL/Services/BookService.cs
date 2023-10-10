using AutoMapper;
using Book.BLL.Interfaces;
using Book.BLL.Services.Abstract;
using Book.Common.DTO.Book;
using Book.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Book.BLL.Services;

public class BookService : BaseService, IBookService
{
    public BookService(BookContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<List<BookDto>> GetAllBooksAsync()
    {
        return _mapper.Map<List<BookDto>>(await _context.Books.ToListAsync());
    }

    public async Task<BookDto> GetBookByIdAsync(int bookId)
    {
        return _mapper.Map<BookDto>(await GetBookByIdInternalAsync(bookId));
    }

    public async Task<BookDto> CreateBookAsync(CreateBookDto bookDto)
    {
        var book = _mapper.Map<DAL.Entities.Book>(bookDto);
        var createBook = (await _context.AddAsync(book)).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<BookDto>(createBook);
    }

    public async Task<BookDto> UpdateBookAsync(UpdateBookDto bookDto)
    {
        var book = await GetBookByIdInternalAsync(bookDto.Id);
        _mapper.Map(bookDto, book);
        book.UpdatedAt = DateTime.Now;
        var updatedBook = _context.Books.Update(book).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<BookDto>(updatedBook);
    }

    public async Task DeleteBookAsync(int bookId)
    {
        var book = await GetBookByIdInternalAsync(bookId);
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
    }

    private async Task<DAL.Entities.Book> GetBookByIdInternalAsync(int bookId)
    {
        var book = await _context.Books.FindAsync(bookId);
        if (book is null)
        {
            throw new Exception("Not found");
        }

        return book;
    }
}