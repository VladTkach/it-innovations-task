using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Context;

public class BookContext: DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public BookContext(DbContextOptions<BookContext> options): base(options)
    {
    }
}