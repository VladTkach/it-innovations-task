using Book.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Book.WebApi.Extensions;

public static class ServiceExtensions
{
    public static void AddBookContext(this IServiceCollection services, IConfiguration configuration)
    {
        var migrationAssembly = typeof(BookContext).Assembly.GetName().Name;
        services.AddDbContext<BookContext>(options =>
            options.UseSqlServer(configuration["ConnectionStrings:BookDBConnection"],
                opt => opt.MigrationsAssembly(migrationAssembly)));
    }
}