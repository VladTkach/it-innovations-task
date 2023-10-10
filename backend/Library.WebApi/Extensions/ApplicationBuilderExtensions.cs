using Library.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.WebApi.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void UseLibraryContext(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        using var context = scope?.ServiceProvider.GetRequiredService<LibraryContext>();
        context?.Database.Migrate();
    }
}