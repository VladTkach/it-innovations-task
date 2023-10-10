using System.Reflection;
using Book.BLL.Interfaces;
using Book.BLL.Services;
using Book.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Book.WebApi.Extensions;

public static class ServiceExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
    }
    public static void AddBookContext(this IServiceCollection services, IConfiguration configuration)
    {
        var migrationAssembly = typeof(BookContext).Assembly.GetName().Name;
        services.AddDbContext<BookContext>(options =>
            options.UseSqlServer(configuration["ConnectionStrings:BookDBConnection"],
                opt => opt.MigrationsAssembly(migrationAssembly)));
    }

    public static void RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}