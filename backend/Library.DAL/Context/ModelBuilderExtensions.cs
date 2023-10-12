using Bogus;
using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Context;

public static class ModelBuilderExtensions
{
    private const int ENTITY_COUNT = 30;
    
    public static void Seed(this ModelBuilder modelBuilder)
    {
        Randomizer.Seed = new Random(654198);

        var books = GenerateRandomBook();

        modelBuilder.Entity<Book>().HasData(books);
    }

    private static ICollection<Book> GenerateRandomBook()
    {
        int bookId = 1;

        var booksFaker = new Faker<Book>()
            .RuleFor(p => p.Id, f => bookId++)
            .RuleFor(p => p.Name, f => f.Lorem.Word())
            .RuleFor(p => p.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.PageCount, f => f.Random.Number(50, 500))
            .RuleFor(p => p.CreatedAt, f => f.Date.Past(5))
            .RuleFor(p => p.UpdatedAt, (f, p) => p.CreatedAt);

        var books = booksFaker.Generate(ENTITY_COUNT);
        return books;
    }
}