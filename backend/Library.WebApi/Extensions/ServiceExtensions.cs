using System.Reflection;
using Library.BLL.Interfaces;
using Library.BLL.Services;
using Library.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.WebApi.Extensions;

public static class ServiceExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
    }
    public static void AddLibraryContext(this IServiceCollection services, IConfiguration configuration)
    {
        var migrationAssembly = typeof(LibraryContext).Assembly.GetName().Name;
        services.AddDbContext<LibraryContext>(options =>
            options.UseSqlServer(configuration["ConnectionStrings:LibraryDBConnection"],
                opt => opt.MigrationsAssembly(migrationAssembly)));
    }
}