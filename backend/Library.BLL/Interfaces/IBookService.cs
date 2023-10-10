using Library.Common.DTO.Book;

namespace Library.BLL.Interfaces;

public interface IBookService
{
    Task<List<BookDto>> GetAllBooksAsync();
    Task<BookDto> GetBookByIdAsync(int bookId);
    Task<BookDto> CreateBookAsync(CreateBookDto bookDto);
    Task<BookDto> UpdateBookAsync(UpdateBookDto bookDto);
    Task DeleteBookAsync(int bookId);
}