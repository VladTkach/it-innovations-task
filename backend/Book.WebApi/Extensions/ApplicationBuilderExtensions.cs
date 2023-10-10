using Book.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Book.WebApi.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void UseBookContext(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        using var context = scope?.ServiceProvider.GetRequiredService<BookContext>();
        context?.Database.Migrate();
    }
}