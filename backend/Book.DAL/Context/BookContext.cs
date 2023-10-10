using Microsoft.EntityFrameworkCore;

namespace Book.DAL.Context;

public class BookContext: DbContext
{
    public DbSet<Entities.Book> Books { get; set; }
    
    public BookContext(DbContextOptions<BookContext> options): base(options)
    {
    }
}